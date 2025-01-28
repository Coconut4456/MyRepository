using DefenceGame_lol.Entity;

namespace DefenceGame_lol.Manager;

public class HitManager
{
    private readonly GameManager _gameManager = GameManager.Instance;
    
    public Enemy? CheckHit_NormalAttack()
    {
        int playerX = _gameManager.ActiveChampion.Label.Location.X + 60;
        int playerRange = _gameManager.ActiveChampion.NormalAtkRange;

        foreach (var enumEnemy in  _gameManager.EnemyRepository.Enemies.ToList())
        {
            if (_gameManager.ActiveChampion.AttackTimer.Enabled && playerX < enumEnemy.Label.Location.X && playerX + playerRange > enumEnemy.Label.Location.X)
            {
                enumEnemy.OnHit(_gameManager.ActiveChampion.Damage);
                
                if (enumEnemy.Health <= 0)
                {
                    enumEnemy.MoveTimer.Stop();
                    return enumEnemy;
                }
                
                enumEnemy.OnHitKnockBack(_gameManager.ActiveChampion.KnockBack);
            }
        }

        return null;
    }
}