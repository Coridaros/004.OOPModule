namespace FootballManager.Models;

public class SeniorManager : Manager
{
    private const int InitialRanking = 30;

    public SeniorManager(string name)
        : base(name, InitialRanking)
    { }

    public override void RankingUpdate(double updateValue)
    {
        this.UpdateAndValidateRanking(updateValue);
    }
}
