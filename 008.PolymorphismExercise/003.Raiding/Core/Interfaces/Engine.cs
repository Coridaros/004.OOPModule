using Raiding.Factories.Interfaces;
using Raiding.IO.Interfaces;
using Raiding.Models.Interfaces;

namespace Raiding.Core.Interfaces;

public class Engine : IEngine
{
    private readonly IReader reader;
    private readonly IWriter writer;
    private readonly IHeroFactory factories;

    public Engine(IReader reader, IWriter writer, IHeroFactory factories)
    {
        this.reader = reader;
        this.writer = writer;
        this.factories = factories;
    }

    public void Run()
    {
        int cnt = int.Parse(reader.ReadLine());

        List<IHero> heroes = new List<IHero>();

        while(cnt > 0)
        {
            try
            {
                string name = reader.ReadLine();
                string type = reader.ReadLine();

                IHero hero = factories.Create(type, name);

                heroes.Add(hero);

                cnt--;
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        foreach(var hero in heroes)
        {
            Console.WriteLine(hero.CastAbility()); 
        }

        int bossHelth = int.Parse(reader.ReadLine());

        int totalPower = heroes.Sum(hero => hero.Power);

        if(totalPower >= bossHelth)
        {
            Console.WriteLine("Victory!");
        }
        else
        {
            Console.WriteLine("Defeat...");
        }
    }
}
