using DefenceGame_lol.Entity;
using DefenceGame_lol.Entity.Champions;
using DefenceGame_lol.Repository;

namespace DefenceGame_lol.Manager;

public class GameManager
{
    public static GameManager Instance { get; private set; } = null!;
    public ChampionRepository ChampionRepository { get; private set; }
    public EnemyRepository EnemyRepository { get; private set; }
    public IChampions ActiveChampion { get; set; }
    public bool GameIsActive { get; set; }
    public int EnemyCount { get; set; }
    public int TimeCount { get; set; }
    public int PlayTime { get; set; }
    public int MaxEnemyCreated { get; set; }

    public GameManager(ChampionRepository championRepository, EnemyRepository enemyRepository)
    {
        ChampionRepository = championRepository;
        EnemyRepository = enemyRepository;
    }

    public void CreatePlayer(int championIndex)
    {
        IChampions champion = ChampionRepository.Champions[championIndex];
        ActiveChampion = champion;
    }
    
    public Label CreateEnemy()
    {
        Label enemyLabel = new Label();
        enemyLabel.Size = new Size(50, 50);
        enemyLabel.Location = new Point(1200, 500);
        enemyLabel.Font = new Font("Arial", 12f);
        enemyLabel.Visible = true;
        enemyLabel.BackColor = Color.Red;
        int playerLabelX = ActiveChampion.Label.Location.X;
        int randomSpeed = new Random().Next(2, 6);

        switch (PlayTime)
        {
            case <= 10:
                Enemy enemy = new Enemy(enemyLabel, playerLabelX, 1, 1, 3);
                EnemyRepository.Enemies.Add(enemy);
                break;
            case <= 20:
                enemy = new Enemy(enemyLabel, playerLabelX, 3, 1, randomSpeed);
                EnemyRepository.Enemies.Add(enemy);
                break;
            default:
                enemy = new Enemy(enemyLabel, playerLabelX, 10, 1, randomSpeed);
                EnemyRepository.Enemies.Add(enemy);
                break;
        }
        
        EnemyCount++;

        return enemyLabel;
    }
}