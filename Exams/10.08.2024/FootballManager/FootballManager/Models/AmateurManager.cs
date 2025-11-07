namespace FootballManager.Models;

public class AmateurManager : Manager
{
    private const int InitialRanking = 15;

    public AmateurManager(string name)
        : base(name, InitialRanking)
    { }

    public override void RankingUpdate(double updateValue)
    {
        this.UpdateAndValidateRanking(updateValue * 0.75);
    }
}
