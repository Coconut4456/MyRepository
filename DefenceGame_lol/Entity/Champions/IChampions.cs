using Timer = System.Windows.Forms.Timer;

namespace DefenceGame_lol.Entity.Champions;

public interface IChampions
{
    public Timer AttackColdDownTimer { get; }
    public Timer AttackTimer { get; }
    public Label AttackRangeLabel { get; set; }
    public Label Label { get; set; }
    public string Name { get; }
    public string Description { get; }
    public int Health { get; set; }
    public int Damage { get; set; }
    public int AttackSpeed { get; set; }
    public int NormalAtkRange { get; set; }
    public int KnockBack { get; set; }
    public int Level { get; set; }
    public int Exp { get; set; }
    public bool NormalAtkState { get; set; }
    public bool SkillAtkState { get; set; }
    public bool IsAttacking { get; set; }

    public void Attack();
}