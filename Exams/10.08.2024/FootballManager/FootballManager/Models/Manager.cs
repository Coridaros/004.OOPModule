using FootballManager.Models.Contracts;
using FootballManager.Utilities.Messages;

namespace FootballManager.Models;

public abstract class Manager : IManager
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
            if(string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException(ExceptionMessages.ManagerNameNull);
            }

            _name = value;
        }
    }

    public double Ranking { get; protected set; }

    public Manager(string name, double ranking)
    {
        Name = name;
        Ranking = ranking;
    }

    public abstract void RankingUpdate(double updateValue);

    public override string ToString()
    {
        return $"{Name} - {GetType().Name} (Ranking: {Ranking:F2})";
    }

    protected void UpdateAndValidateRanking(double updateValue)
    {
        Ranking += updateValue;

        if(Ranking < 0)
        {
            Ranking = 0;
        }

        if(Ranking > 100)
        {
            Ranking = 100;
        }
    }
}
