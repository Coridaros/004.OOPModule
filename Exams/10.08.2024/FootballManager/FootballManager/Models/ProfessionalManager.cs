namespace FootballManager.Models;

public class ProfessionalManager : Manager
{
    private const int InitialRanking = 60;

    public ProfessionalManager(string name)
        : base(name, InitialRanking)
    { }

    public override void RankingUpdate(double updateValue)
    {
        this.UpdateAndValidateRanking(updateValue * 1.5);
    }
}
