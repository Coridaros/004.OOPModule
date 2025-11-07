using FootballManager.Core.Contracts;
using FootballManager.Models;
using FootballManager.Models.Contracts;
using FootballManager.Repositories;
using FootballManager.Utilities.Messages;
using System.Text;

namespace FootballManager.Core;

public class Controller : IController
{
    private TeamRepository championship;
    private readonly string[] managerTypes = new string[]
    {
        typeof(AmateurManager).Name,
        typeof(ProfessionalManager).Name,
        typeof(SeniorManager).Name
    };

    public Controller()
    {
        championship = new TeamRepository();
    }

    public string ChampionshipRankings()
    {
        var sortedTeams = championship.Models
            .OrderByDescending(t => t.ChampionshipPoints)
            .ThenByDescending(t => t.PresentCondition)
            .ToList();

        StringBuilder sb = new StringBuilder();

        sb.AppendLine("***Ranking Table***");

        int cnt = 1;

        foreach(var team in sortedTeams)
        {
            sb.AppendLine($"{cnt++}. {team}/{team.TeamManager}");
        }

        return sb.ToString().Trim();
    }

    public string JoinChampionship(string teamName)
    {
        if(championship.Models.Count == championship.Capacity)
        {
            return OutputMessages.ChampionshipFull;
        }

        if(championship.Exists(teamName))
        {
            return string.Format(OutputMessages.TeamWithSameNameExisting, teamName);
        }

        var team = new Team(teamName);

        championship.Add(team);

        return string.Format(OutputMessages.TeamSuccessfullyJoined, teamName);
    }

    public string MatchBetween(string teamOneName, string teamTwoName)
    {
        if(!championship.Exists(teamOneName) || !championship.Exists(teamTwoName))
        {
            return string.Format(OutputMessages.OneOfTheTeamDoesNotExist);
        }

        var teamOne = championship.Get(teamOneName);
        var teamTwo = championship.Get(teamTwoName);

        ITeam winner;
        ITeam losser;

        if(teamOne.PresentCondition > teamTwo.PresentCondition)
        {
            winner = teamOne;
            losser = teamTwo;
        }
        else if(teamTwo.PresentCondition > teamOne.PresentCondition)
        {
            winner = teamTwo;
            losser = teamOne;
        }
        else
        {
            teamOne.GainPoints(1);
            teamTwo.GainPoints(1);

            return string.Format(OutputMessages.MatchIsDraw, teamOneName, teamTwoName);
        }

        winner.GainPoints(3);
        winner.TeamManager?.RankingUpdate(5);
        losser.TeamManager?.RankingUpdate(-5);

        return string.Format(OutputMessages.TeamWinsMatch, winner.Name, losser.Name);
    }

    public string PromoteTeam(string droppingTeamName, string promotingTeamName, string managerTypeName, string managerName)
    {
        if(!championship.Exists(droppingTeamName))
        {
            return string.Format(OutputMessages.DroppingTeamDoesNotExist, droppingTeamName);
        }

        if(championship.Exists(promotingTeamName))
        {
            return string.Format(OutputMessages.TeamWithSameNameExisting, promotingTeamName);
        }

        var team = new Team(promotingTeamName);

        bool managerExists = false;

        foreach(var existingTeam in championship.Models)
        {
            if(existingTeam.TeamManager?.Name == managerName)
            {
                managerExists = true;
                break;
            }
        }

        if(!managerExists && managerTypes.Contains(managerTypeName))
        {
            var manager = CreateManager(managerName, managerTypeName);
            team.SignWith(manager);
        }

        foreach(var exisingTeam in championship.Models)
        {
            exisingTeam.ResetPoints();
        }

        championship.Remove(droppingTeamName);

        championship.Add(team);

        return string.Format(OutputMessages.TeamHasBeenPromoted, promotingTeamName);
    }

    public string SignManager(string teamName, string managerTypeName, string managerName)
    {
        if(!championship.Exists(teamName))
        {
            return string.Format(OutputMessages.TeamDoesNotTakePart, teamName);
        }

        if(!managerTypes.Contains(managerTypeName))
        {
            return string.Format(OutputMessages.ManagerTypeNotPresented, managerTypeName);
        }

        var team = championship.Get(teamName);

        if(team.TeamManager != null)
        {
            return string.Format(OutputMessages.TeamSignedWithAnotherManager, teamName, team.TeamManager.Name);
        }

        foreach(var existingTeam in championship.Models)
        {
            if(existingTeam.TeamManager?.Name == managerName)
            {
                return string.Format(OutputMessages.ManagerAssignedToAnotherTeam, managerName);
            }
        }

        var manager = CreateManager(managerName, managerTypeName);

        team.SignWith(manager);

        return string.Format(OutputMessages.TeamSuccessfullySignedWithManager, managerName, teamName);
    }

    private Manager CreateManager(string managerName, string managerTypeName)
    {
        if(managerTypeName == typeof(AmateurManager).Name)
        {
            return new AmateurManager(managerName);
        }
        else if(managerTypeName == typeof(SeniorManager).Name)
        {
            return new SeniorManager(managerName);
        }
        else if(managerTypeName == typeof(ProfessionalManager).Name)
        {
            return new ProfessionalManager(managerName);
        }

        return null;
    }
}
