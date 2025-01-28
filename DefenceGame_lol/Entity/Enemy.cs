using Timer = System.Windows.Forms.Timer;

namespace DefenceGame_lol.Entity;

public class Enemy
{
    public Timer MoveTimer { get; set; }
    public Timer MoveToSlowTimer { get; set; }
    public Label Label { get; set; }
    public int TargetLabelX  { get; set; }
    public bool IsActive  { get; private set; }
    public bool Hit { get; set; }
    public int Health { get; set; }
    public int Damage { get; set; }
    public int Speed { get; set; }


    public Enemy(Label label, int targetLabelX, int health, int damage, int speed)
    {
        MoveTimer = new Timer();
        MoveToSlowTimer = new Timer();
        Label = label;
        TargetLabelX = targetLabelX;
        Health = health;
        Damage = damage;
        Speed = speed;
        IsActive = true;
        MoveTimer.Tick += MoveTimer_Tick!;
        MoveToSlowTimer.Tick += MoveToSlowTimer_Tick!;
        MoveTimer.Interval = 32;
        MoveToSlowTimer.Interval = 1000;
        MoveTimer.Start();
    }

    public void OnHit(int damage)
    {
        Health -= damage;
    }

    public void OnHitKnockBack(int knockBack)
    {
        int knockBackX = Label.Location.X + knockBack;
        Label.Location = new Point(knockBackX, Label.Location.Y);
        MoveTimer.Interval *= 2;
        MoveToSlowTimer.Start();
    }

    private void MoveToSlowTimer_Tick(object sender, EventArgs e)
    {
        MoveTimer.Interval /= 2;
        MoveToSlowTimer.Stop();
    }
    
    // 적 이동 타이머
    private void MoveTimer_Tick(object sender, EventArgs e)
    {
        int playerX = TargetLabelX + 60;
        int enemyX = Label.Location.X;

        if (enemyX < playerX || enemyX == playerX)
        {
            enemyX = playerX;
        }

        if (MoveToSlowTimer.Enabled)
        {
            enemyX -= Speed / 2;
        }
        else
        {
            enemyX -= Speed;
        }

        // 체력이 0 이면 비활성화
        if (Health <= 0)
        {
            IsActive = false;
            Label.Enabled = false;
            Label.Visible = false;
            MoveTimer.Stop();
        }

        Label.Location = new Point(enemyX, this.Label.Location.Y);
        Label.Text = Health.ToString(); // 체력 표시 (임시)
    }
}