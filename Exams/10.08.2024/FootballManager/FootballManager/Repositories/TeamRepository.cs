using FootballManager.Models.Contracts;
using FootballManager.Repositories.Contracts;

namespace FootballManager.Repositories;

public class TeamRepository : IRepository<ITeam>
{
    private const int MaximumCapacity = 10;
    private List<ITeam> _teams;

    public IReadOnlyCollection<ITeam> Models
    {
        get
        {
            return _teams.AsReadOnly();
        }
    }

    public int Capacity
    {
        get
        {
            return MaximumCapacity;
        }
    }

    public TeamRepository()
    {
        _teams = new List<ITeam>();
    }

    public void Add(ITeam model)
    {
        if(_teams.Count == MaximumCapacity)
        {
            return;
        }

        _teams.Add(model);
    }

    public bool Exists(string name)
    {
        return _teams.Any(t => t.Name == name);
    }

    public ITeam Get(string name)
    {
        return _teams.FirstOrDefault(t => t.Name == name);
    }

    public bool Remove(string name)
    {
        var team = Get(name);

        if(team == null)
        {
            return false;
        }

        _teams.Remove(team);

        return true;
    }
}
