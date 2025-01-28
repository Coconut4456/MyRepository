using System.Media;

namespace DefenceGame_lol;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        groundLabel = new System.Windows.Forms.Label();
        player1Button = new System.Windows.Forms.Button();
        selectPlayerPanel = new System.Windows.Forms.Panel();
        player3DescLabel = new System.Windows.Forms.Label();
        player3IconLabel = new System.Windows.Forms.Label();
        player2IconLabel = new System.Windows.Forms.Label();
        player1IconLabel = new System.Windows.Forms.Label();
        player2DescLabel = new System.Windows.Forms.Label();
        player1DescLabel = new System.Windows.Forms.Label();
        player3Button = new System.Windows.Forms.Button();
        player2Button = new System.Windows.Forms.Button();
        selectPlayerPanel.SuspendLayout();
        SuspendLayout();
        // 
        // groundLabel
        // 
        groundLabel.BackColor = System.Drawing.Color.White;
        groundLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        groundLabel.Location = new System.Drawing.Point(-12, 550);
        groundLabel.Name = "groundLabel";
        groundLabel.Size = new System.Drawing.Size(1225, 10);
        groundLabel.TabIndex = 0;
        // 
        // player1Button
        // 
        player1Button.BackColor = System.Drawing.Color.White;
        player1Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        player1Button.Location = new System.Drawing.Point(107, 286);
        player1Button.Name = "player1Button";
        player1Button.Size = new System.Drawing.Size(137, 40);
        player1Button.TabIndex = 3;
        player1Button.Text = "player1Button";
        player1Button.UseVisualStyleBackColor = false;
        // 
        // selectPlayerPanel
        // 
        selectPlayerPanel.BackColor = System.Drawing.Color.DimGray;
        selectPlayerPanel.Controls.Add(player3DescLabel);
        selectPlayerPanel.Controls.Add(player3IconLabel);
        selectPlayerPanel.Controls.Add(player2IconLabel);
        selectPlayerPanel.Controls.Add(player1IconLabel);
        selectPlayerPanel.Controls.Add(player2DescLabel);
        selectPlayerPanel.Controls.Add(player1DescLabel);
        selectPlayerPanel.Controls.Add(player3Button);
        selectPlayerPanel.Controls.Add(player2Button);
        selectPlayerPanel.Controls.Add(player1Button);
        selectPlayerPanel.Location = new System.Drawing.Point(93, 35);
        selectPlayerPanel.Name = "selectPlayerPanel";
        selectPlayerPanel.Size = new System.Drawing.Size(981, 348);
        selectPlayerPanel.TabIndex = 4;
        // 
        // player3DescLabel
        // 
        player3DescLabel.Location = new System.Drawing.Point(794, 45);
        player3DescLabel.Name = "player3DescLabel";
        player3DescLabel.Size = new System.Drawing.Size(155, 238);
        player3DescLabel.TabIndex = 12;
        player3DescLabel.Text = "player3DescLabel";
        // 
        // player3IconLabel
        // 
        player3IconLabel.Location = new System.Drawing.Point(646, 45);
        player3IconLabel.Name = "player3IconLabel";
        player3IconLabel.Size = new System.Drawing.Size(142, 238);
        player3IconLabel.TabIndex = 11;
        player3IconLabel.Text = "player3IconLabel";
        // 
        // player2IconLabel
        // 
        player2IconLabel.Location = new System.Drawing.Point(337, 45);
        player2IconLabel.Name = "player2IconLabel";
        player2IconLabel.Size = new System.Drawing.Size(142, 238);
        player2IconLabel.TabIndex = 10;
        player2IconLabel.Text = "player2IconLabel";
        // 
        // player1IconLabel
        // 
        player1IconLabel.Location = new System.Drawing.Point(26, 45);
        player1IconLabel.Name = "player1IconLabel";
        player1IconLabel.Size = new System.Drawing.Size(142, 238);
        player1IconLabel.TabIndex = 9;
        player1IconLabel.Text = "player1IconLabel";
        // 
        // player2DescLabel
        // 
        player2DescLabel.Location = new System.Drawing.Point(485, 45);
        player2DescLabel.Name = "player2DescLabel";
        player2DescLabel.Size = new System.Drawing.Size(155, 238);
        player2DescLabel.TabIndex = 7;
        player2DescLabel.Text = "player2DescLabel";
        // 
        // player1DescLabel
        // 
        player1DescLabel.Location = new System.Drawing.Point(174, 45);
        player1DescLabel.Name = "player1DescLabel";
        player1DescLabel.Size = new System.Drawing.Size(157, 238);
        player1DescLabel.TabIndex = 6;
        player1DescLabel.Text = "player1DescLabel";
        // 
        // player3Button
        // 
        player3Button.BackColor = System.Drawing.Color.White;
        player3Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        player3Button.Location = new System.Drawing.Point(724, 286);
        player3Button.Name = "player3Button";
        player3Button.Size = new System.Drawing.Size(137, 40);
        player3Button.TabIndex = 5;
        player3Button.Text = "player3Button";
        player3Button.UseVisualStyleBackColor = false;
        // 
        // player2Button
        // 
        player2Button.BackColor = System.Drawing.Color.White;
        player2Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        player2Button.Location = new System.Drawing.Point(416, 286);
        player2Button.Name = "player2Button";
        player2Button.Size = new System.Drawing.Size(137, 40);
        player2Button.TabIndex = 4;
        player2Button.Text = "player2Button";
        player2Button.UseVisualStyleBackColor = false;
        // 
        // Form1
        // 
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
        BackColor = System.Drawing.Color.Black;
        ClientSize = new System.Drawing.Size(1200, 760);
        Controls.Add(selectPlayerPanel);
        Controls.Add(groundLabel);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        Text = "Form1";
        selectPlayerPanel.ResumeLayout(false);
        ResumeLayout(false);
    }

    private System.Windows.Forms.Label player1DescLabel;
    private System.Windows.Forms.Label player2DescLabel;
    private System.Windows.Forms.Label player1IconLabel;

    private System.Windows.Forms.Button player2Button;
    private System.Windows.Forms.Button player3Button;
    private System.Windows.Forms.Label player3DescLabel;
    private System.Windows.Forms.Label player2IconLabel;
    private System.Windows.Forms.Label player3IconLabel;

    private System.Windows.Forms.Panel selectPlayerPanel;

    private System.Windows.Forms.Button player1Button;

    private System.Windows.Forms.Label groundLabel;

    #endregion
}