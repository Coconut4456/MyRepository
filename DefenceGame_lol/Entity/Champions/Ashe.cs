﻿using Timer = System.Windows.Forms.Timer;

namespace DefenceGame_lol.Entity.Champions;

public class Ashe : IChampions
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

    public Ashe()
    {
        AttackColdDownTimer = new Timer();
        AttackTimer = new Timer();
        AttackColdDownTimer.Tick += AttackColdDown_Tick!;
        AttackTimer.Tick += AttackTimer_Tick!;
        
        {
            Health = 40;
            Damage = 1;
            AttackSpeed = 400;
            NormalAtkRange = 200;
            KnockBack = 20;
            Level = 1;
            Exp = 0;
            Name = "애 쉬";
            Description = "주무기 : 활"
                          + Environment.NewLine + "타입 : 원거리"
                          + Environment.NewLine + $"체력 : {Health.ToString()}"
                          + Environment.NewLine + $"공격력 : {Damage.ToString()}";
        }
        
        {
            Label label = new Label();
            label.BackColor = Color.DeepSkyBlue;
            label.BorderStyle = BorderStyle.FixedSingle;
            label.Location = new Point(80, 450);
            label.Size = new Size(60, 100);
            label.Visible = true;
            Label = label;
        }

        {
            Label rangeLabel = new Label();
            rangeLabel.BackColor = Color.Brown;
            rangeLabel.BorderStyle = BorderStyle.FixedSingle;
            rangeLabel.Location = new Point(145, 500);
            rangeLabel.Size = new Size(NormalAtkRange, 40);
            rangeLabel.Visible = false;
            AttackRangeLabel = rangeLabel;
        }

        AttackTimer.Interval = 100;
        AttackColdDownTimer.Interval = AttackSpeed;
        IsAttacking = false;
    }
    
    public void Attack()
    {
        if (IsAttacking)
            return;

        IsAttacking = true;
        AttackRangeLabel.Visible = true;
        AttackTimer.Start();
        AttackColdDownTimer.Start();
    }

    private void AttackTimer_Tick(object sender, EventArgs e)
    {
        AttackRangeLabel.Visible = false;
        AttackTimer.Stop();
    }

    private void AttackColdDown_Tick(object sender, EventArgs e)
    {
        IsAttacking = false;
        AttackColdDownTimer.Stop();
    }
}