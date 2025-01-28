using DefenceGame_lol.Entity;
using DefenceGame_lol.Entity.Champions;
using DefenceGame_lol.Manager;
using DefenceGame_lol.Repository;
using Timer = System.Windows.Forms.Timer;

namespace DefenceGame_lol;

public partial class Form1 : Form
{
    private readonly GameManager _gameManager;
    private readonly HitManager _hitManager;
    private readonly Timer _createEnemyTimer = new();
    private readonly Timer _HitTimer = new();
    private readonly Timer _playTimeTimer = new();

    public Form1()
    {
        InitializeComponent();

        _gameManager = new GameManager(new ChampionRepository(), new EnemyRepository(new List<Enemy>()));
        _hitManager = new HitManager();

        KeyDown += Form1_KeyDown!;
        _createEnemyTimer.Tick += CreateEnemyTimer_Tick!;
        _playTimeTimer.Tick += PlayTimeTimer_Tick!;
        _HitTimer.Tick += UpDataTimer_Tick!;
        player1Button.Click += Player1Button_Click!;
        player2Button.Click += Player2Button_Click!;
        player3Button.Click += Player3Button_Click!;
        _createEnemyTimer.Interval = 1000; // 몹 생성 타이머
        _playTimeTimer.Interval = 1000; // 게임 진행 시간 타이머
        _HitTimer.Interval = 16; // 히트 판정 확인 타이머

        selectPlayerPanel.Visible = false;
        player1IconLabel.Text = "";
        player2IconLabel.Text = "";
        player3IconLabel.Text = "";

        SelectChampion();
    }

    // 게임 시작
    private void StartGame()
    {
        IChampions champion = _gameManager.ActiveChampion;
        _gameManager.ActiveChampion = champion;
        Controls.Add(champion.Label);
        Controls.Add(champion.AttackRangeLabel);
        champion.Label.Visible = true;
        _gameManager.GameIsActive = true;
        selectPlayerPanel.Enabled = false;
        selectPlayerPanel.Visible = false;
        _createEnemyTimer.Start();
        _HitTimer.Start();
        _playTimeTimer.Start();
        _gameManager.MaxEnemyCreated = 10;
    }

    // 게임 중단
    private void StopGame()
    {
        _createEnemyTimer.Stop();
        _HitTimer.Stop();
        _playTimeTimer.Stop();
        
        foreach (var enemy in _gameManager.EnemyRepository.Enemies)
        {
            Controls.Remove(enemy.Label);
        }

        _gameManager.PlayTime = 0;
        _gameManager.EnemyRepository.Enemies.Clear();
        _gameManager.ActiveChampion.Label.Visible = false;
        _gameManager.GameIsActive = false;
    }

    // 챔피언 선택
    private void SelectChampion()
    {
        selectPlayerPanel.Enabled = true;
        selectPlayerPanel.Visible = true;
        player1Button.Visible = true;
        player1IconLabel.Visible = true;
        player1DescLabel.Visible = true;
        player2Button.Visible = true;
        player2IconLabel.Visible = true;
        player2DescLabel.Visible = true;
        player3Button.Visible = true;
        player3IconLabel.Visible = true;
        player3DescLabel.Visible = true;

        player1Button.Text = "선택";
        player1DescLabel.Text = _gameManager.ChampionRepository.Champions[0].Name
                                + Environment.NewLine + _gameManager.ChampionRepository.Champions[0].Description;

        player2Button.Text = "선택";
        player2DescLabel.Text = _gameManager.ChampionRepository.Champions[1].Name
                                + Environment.NewLine + _gameManager.ChampionRepository.Champions[1].Description;

        player3Button.Text = "선택";
        player3DescLabel.Text = _gameManager.ChampionRepository.Champions[2].Name
                                + Environment.NewLine + _gameManager.ChampionRepository.Champions[2].Description;
    }

    // 히트 판정 확인 타이머
    private void UpDataTimer_Tick(object sender, EventArgs e)
    {
        Enemy? enemy = _hitManager.CheckHit_NormalAttack();

        if (enemy != null)
        {
            Controls.Remove(enemy.Label);
            _gameManager.EnemyRepository.Enemies.Remove(enemy);
        }
    }

    // 적 생성 타이머
    private void CreateEnemyTimer_Tick(object sender, EventArgs e)
    {
        int enemyCount = _gameManager.EnemyRepository.Enemies.Count;
        int enemyMax = _gameManager.MaxEnemyCreated;
        
        if (enemyCount < enemyMax)
            Controls.Add(_gameManager.CreateEnemy());
        
        List<int> createTime = [2000, 3000];
        _createEnemyTimer.Interval = new Random().Next(createTime[0], createTime[1]);
    }

    // 게임 진행 타이머
    private void PlayTimeTimer_Tick(object sender, EventArgs e)
    {
        _gameManager.PlayTime++;
    }

    // 키 입력 이벤트
    private void Form1_KeyDown(object sender, KeyEventArgs e)
    {
        if (!_gameManager.GameIsActive)
        {
            return;
        }

        switch (e.KeyCode)
        {
            case Keys.Space:
                _gameManager.ActiveChampion.Attack();
                break;
            case Keys.Back:
                StopGame();
                SelectChampion();
                break;
        }
    }

    // 캐릭터 슬롯 1 버튼
    private void Player1Button_Click(object sender, EventArgs e)
    {
        _gameManager.CreatePlayer(0);
        StartGame();
    }

    // 캐릭터 슬롯 2 버튼
    private void Player2Button_Click(object sender, EventArgs e)
    {
        _gameManager.CreatePlayer(1);
        StartGame();
    }

    // 캐릭터 슬롯 3 버튼
    private void Player3Button_Click(object sender, EventArgs e)
    {
        _gameManager.CreatePlayer(2);
        StartGame();
    }
}