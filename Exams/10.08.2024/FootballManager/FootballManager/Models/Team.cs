using FootballManager.Models.Contracts;
using FootballManager.Utilities.Messages;

namespace FootballManager.Models;

public class Team : ITeam
{
    private string _name;

    public string Name
    {
        get
        {
            return _name;
        }
        private set
        {
            if(string.IsNullOrEmpty(value))
            {
                throw new ArgumentException(ExceptionMessages.TeamNameNull);
            }

            _name = value;
        }
    }

    public int ChampionshipPoints { get; private set; }

    public IManager TeamManager { get; private set; }

    public int PresentCondition
    {
        get
        {
            if(TeamManager == null)
            {
                return 0;
            }

            double result = 0;

            if(ChampionshipPoints == 0)
            {
                result = TeamManager.Ranking; 
            }
            else
            {
                result = ChampionshipPoints * TeamManager.Ranking;
            }

            return (int)Math.Floor(result);
        }
    }

    public Team(string name)
    {
        Name = name;
    }

    public void GainPoints(int points)
    {
        ChampionshipPoints += points;
    }

    public void ResetPoints()
    {
        ChampionshipPoints = 0;
    }

    public void SignWith(IManager manager)
    {
        TeamManager = manager;
    }

    public override string ToString()
    {
        return $"Team: {Name} Points: {ChampionshipPoints}";
    }
}
