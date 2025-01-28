using DefenceGame_lol.Entity;

namespace DefenceGame_lol.Repository;

public class EnemyRepository
{
    public List<Enemy> Enemies { get; set; }

    public EnemyRepository(List<Enemy> enemies)
    {
        Enemies = enemies;
    }
}