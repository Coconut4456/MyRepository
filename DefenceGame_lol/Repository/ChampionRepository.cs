using DefenceGame_lol.Entity.Champions;
using DefenceGame_lol.Entity;

namespace DefenceGame_lol.Repository;

public class ChampionRepository
{
    public List<IChampions> Champions { get; private set; }
    
    public ChampionRepository()
    {
        Champions = new List<IChampions>();
        Champions.Add(new Darius());
        Champions.Add(new LeeSin());
        Champions.Add(new Ashe());
    }
}