namespace FoosballScoreboard.Forms
{
    partial class Main
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TpTournament = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtCompetition = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtTournamentName = new System.Windows.Forms.TextBox();
            this.TpScore = new System.Windows.Forms.TabPage();
            this.BtnSwitchTeams = new System.Windows.Forms.Button();
            this.GroupBoxBlack = new System.Windows.Forms.GroupBox();
            this.TxtBlackTeamName2 = new System.Windows.Forms.TextBox();
            this.LblBlackSets = new System.Windows.Forms.Label();
            this.LblBlackGoals = new System.Windows.Forms.Label();
            this.TxtBlackTeamName1 = new System.Windows.Forms.TextBox();
            this.TxtBlackGoals = new System.Windows.Forms.TextBox();
            this.BtnBlackSetDown = new System.Windows.Forms.Button();
            this.BtnBlackGoalUp = new System.Windows.Forms.Button();
            this.BtnBlackSetUp = new System.Windows.Forms.Button();
            this.BtnBlackDown = new System.Windows.Forms.Button();
            this.TxtBlackSets = new System.Windows.Forms.TextBox();
            this.GroupBoxGreen = new System.Windows.Forms.GroupBox();
            this.TxtGreenTeamName2 = new System.Windows.Forms.TextBox();
            this.LblGreenSets = new System.Windows.Forms.Label();
            this.LblGreenGoals = new System.Windows.Forms.Label();
            this.TxtGreenTeamName1 = new System.Windows.Forms.TextBox();
            this.BtnGreenUp = new System.Windows.Forms.Button();
            this.TxtGreenGoals = new System.Windows.Forms.TextBox();
            this.BtnGreenDown = new System.Windows.Forms.Button();
            this.BtnGreenSetDown = new System.Windows.Forms.Button();
            this.TxtGreenSets = new System.Windows.Forms.TextBox();
            this.BtnGreenSetUp = new System.Windows.Forms.Button();
            this.BtnResetScore = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenSavedPath = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtStage = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.TpTournament.SuspendLayout();
            this.TpScore.SuspendLayout();
            this.GroupBoxBlack.SuspendLayout();
            this.GroupBoxGreen.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.TpTournament);
            this.tabControl1.Controls.Add(this.TpScore);
            this.tabControl1.Location = new System.Drawing.Point(12, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(727, 431);
            this.tabControl1.TabIndex = 0;
            // 
            // TpTournament
            // 
            this.TpTournament.Controls.Add(this.comboBox1);
            this.TpTournament.Controls.Add(this.label4);
            this.TpTournament.Controls.Add(this.label3);
            this.TpTournament.Controls.Add(this.TxtStage);
            this.TpTournament.Controls.Add(this.label2);
            this.TpTournament.Controls.Add(this.TxtCompetition);
            this.TpTournament.Controls.Add(this.label1);
            this.TpTournament.Controls.Add(this.TxtTournamentName);
            this.TpTournament.Location = new System.Drawing.Point(4, 24);
            this.TpTournament.Name = "TpTournament";
            this.TpTournament.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.TpTournament.Size = new System.Drawing.Size(719, 403);
            this.TpTournament.TabIndex = 1;
            this.TpTournament.Text = "Tournament";
            this.TpTournament.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(24, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 28);
            this.label2.TabIndex = 22;
            this.label2.Text = "Competition";
            // 
            // TxtCompetition
            // 
            this.TxtCompetition.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtCompetition.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtCompetition.Location = new System.Drawing.Point(24, 120);
            this.TxtCompetition.Name = "TxtCompetition";
            this.TxtCompetition.Size = new System.Drawing.Size(388, 32);
            this.TxtCompetition.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(24, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 28);
            this.label1.TabIndex = 20;
            this.label1.Text = "Tournament Name";
            // 
            // TxtTournamentName
            // 
            this.TxtTournamentName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtTournamentName.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtTournamentName.Location = new System.Drawing.Point(24, 48);
            this.TxtTournamentName.Name = "TxtTournamentName";
            this.TxtTournamentName.Size = new System.Drawing.Size(693, 32);
            this.TxtTournamentName.TabIndex = 0;
            // 
            // TpScore
            // 
            this.TpScore.Controls.Add(this.BtnSwitchTeams);
            this.TpScore.Controls.Add(this.GroupBoxBlack);
            this.TpScore.Controls.Add(this.GroupBoxGreen);
            this.TpScore.Controls.Add(this.BtnResetScore);
            this.TpScore.Location = new System.Drawing.Point(4, 24);
            this.TpScore.Name = "TpScore";
            this.TpScore.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.TpScore.Size = new System.Drawing.Size(719, 403);
            this.TpScore.TabIndex = 0;
            this.TpScore.Text = "Score";
            this.TpScore.UseVisualStyleBackColor = true;
            // 
            // BtnSwitchTeams
            // 
            this.BtnSwitchTeams.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnSwitchTeams.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnSwitchTeams.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnSwitchTeams.Location = new System.Drawing.Point(312, 60);
            this.BtnSwitchTeams.Name = "BtnSwitchTeams";
            this.BtnSwitchTeams.Size = new System.Drawing.Size(98, 66);
            this.BtnSwitchTeams.TabIndex = 3;
            this.BtnSwitchTeams.Text = "Switch Teams";
            this.BtnSwitchTeams.UseVisualStyleBackColor = true;
            this.BtnSwitchTeams.Click += new System.EventHandler(this.BtnSwitchTeams_Click);
            // 
            // GroupBoxBlack
            // 
            this.GroupBoxBlack.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBoxBlack.Controls.Add(this.TxtBlackTeamName2);
            this.GroupBoxBlack.Controls.Add(this.LblBlackSets);
            this.GroupBoxBlack.Controls.Add(this.LblBlackGoals);
            this.GroupBoxBlack.Controls.Add(this.TxtBlackTeamName1);
            this.GroupBoxBlack.Controls.Add(this.TxtBlackGoals);
            this.GroupBoxBlack.Controls.Add(this.BtnBlackSetDown);
            this.GroupBoxBlack.Controls.Add(this.BtnBlackGoalUp);
            this.GroupBoxBlack.Controls.Add(this.BtnBlackSetUp);
            this.GroupBoxBlack.Controls.Add(this.BtnBlackDown);
            this.GroupBoxBlack.Controls.Add(this.TxtBlackSets);
            this.GroupBoxBlack.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GroupBoxBlack.Location = new System.Drawing.Point(425, 20);
            this.GroupBoxBlack.Name = "GroupBoxBlack";
            this.GroupBoxBlack.Size = new System.Drawing.Size(290, 377);
            this.GroupBoxBlack.TabIndex = 1;
            this.GroupBoxBlack.TabStop = false;
            this.GroupBoxBlack.Text = "Black";
            // 
            // TxtBlackTeamName2
            // 
            this.TxtBlackTeamName2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtBlackTeamName2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtBlackTeamName2.Location = new System.Drawing.Point(11, 78);
            this.TxtBlackTeamName2.Name = "TxtBlackTeamName2";
            this.TxtBlackTeamName2.Size = new System.Drawing.Size(273, 32);
            this.TxtBlackTeamName2.TabIndex = 1;
            // 
            // LblBlackSets
            // 
            this.LblBlackSets.AutoSize = true;
            this.LblBlackSets.Location = new System.Drawing.Point(130, 159);
            this.LblBlackSets.Name = "LblBlackSets";
            this.LblBlackSets.Size = new System.Drawing.Size(48, 28);
            this.LblBlackSets.TabIndex = 22;
            this.LblBlackSets.Text = "Sets";
            // 
            // LblBlackGoals
            // 
            this.LblBlackGoals.AutoSize = true;
            this.LblBlackGoals.Location = new System.Drawing.Point(6, 140);
            this.LblBlackGoals.Name = "LblBlackGoals";
            this.LblBlackGoals.Size = new System.Drawing.Size(61, 28);
            this.LblBlackGoals.TabIndex = 21;
            this.LblBlackGoals.Text = "Goals";
            // 
            // TxtBlackTeamName1
            // 
            this.TxtBlackTeamName1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtBlackTeamName1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtBlackTeamName1.Location = new System.Drawing.Point(11, 40);
            this.TxtBlackTeamName1.Name = "TxtBlackTeamName1";
            this.TxtBlackTeamName1.Size = new System.Drawing.Size(273, 32);
            this.TxtBlackTeamName1.TabIndex = 0;
            // 
            // TxtBlackGoals
            // 
            this.TxtBlackGoals.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtBlackGoals.Location = new System.Drawing.Point(6, 211);
            this.TxtBlackGoals.Name = "TxtBlackGoals";
            this.TxtBlackGoals.Size = new System.Drawing.Size(64, 52);
            this.TxtBlackGoals.TabIndex = 3;
            this.TxtBlackGoals.Text = "5";
            this.TxtBlackGoals.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnBlackSetDown
            // 
            this.BtnBlackSetDown.BackgroundImage = global::FoosballScoreboard.Forms.Properties.Resources.icons8_rangabzeichen_runter_96;
            this.BtnBlackSetDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnBlackSetDown.Location = new System.Drawing.Point(130, 256);
            this.BtnBlackSetDown.Name = "BtnBlackSetDown";
            this.BtnBlackSetDown.Size = new System.Drawing.Size(64, 20);
            this.BtnBlackSetDown.TabIndex = 7;
            this.BtnBlackSetDown.UseVisualStyleBackColor = true;
            this.BtnBlackSetDown.Click += new System.EventHandler(this.BtnBlackSetDown_Click);
            // 
            // BtnBlackGoalUp
            // 
            this.BtnBlackGoalUp.BackgroundImage = global::FoosballScoreboard.Forms.Properties.Resources.icons8_rangabzeichen_hoch_96;
            this.BtnBlackGoalUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnBlackGoalUp.Location = new System.Drawing.Point(6, 171);
            this.BtnBlackGoalUp.Name = "BtnBlackGoalUp";
            this.BtnBlackGoalUp.Size = new System.Drawing.Size(64, 32);
            this.BtnBlackGoalUp.TabIndex = 2;
            this.BtnBlackGoalUp.UseVisualStyleBackColor = true;
            this.BtnBlackGoalUp.Click += new System.EventHandler(this.BtnBlackGoalUp_Click);
            // 
            // BtnBlackSetUp
            // 
            this.BtnBlackSetUp.BackgroundImage = global::FoosballScoreboard.Forms.Properties.Resources.icons8_rangabzeichen_hoch_96;
            this.BtnBlackSetUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnBlackSetUp.Location = new System.Drawing.Point(130, 190);
            this.BtnBlackSetUp.Name = "BtnBlackSetUp";
            this.BtnBlackSetUp.Size = new System.Drawing.Size(64, 20);
            this.BtnBlackSetUp.TabIndex = 5;
            this.BtnBlackSetUp.UseVisualStyleBackColor = true;
            this.BtnBlackSetUp.Click += new System.EventHandler(this.BtnBlackSetUp_Click);
            // 
            // BtnBlackDown
            // 
            this.BtnBlackDown.BackgroundImage = global::FoosballScoreboard.Forms.Properties.Resources.icons8_rangabzeichen_runter_96;
            this.BtnBlackDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnBlackDown.Location = new System.Drawing.Point(6, 269);
            this.BtnBlackDown.Name = "BtnBlackDown";
            this.BtnBlackDown.Size = new System.Drawing.Size(64, 32);
            this.BtnBlackDown.TabIndex = 4;
            this.BtnBlackDown.UseVisualStyleBackColor = true;
            this.BtnBlackDown.Click += new System.EventHandler(this.BtnBlackDown_Click);
            // 
            // TxtBlackSets
            // 
            this.TxtBlackSets.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtBlackSets.Location = new System.Drawing.Point(130, 216);
            this.TxtBlackSets.Name = "TxtBlackSets";
            this.TxtBlackSets.Size = new System.Drawing.Size(64, 34);
            this.TxtBlackSets.TabIndex = 6;
            this.TxtBlackSets.Text = "5";
            this.TxtBlackSets.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // GroupBoxGreen
            // 
            this.GroupBoxGreen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.GroupBoxGreen.Controls.Add(this.TxtGreenTeamName2);
            this.GroupBoxGreen.Controls.Add(this.LblGreenSets);
            this.GroupBoxGreen.Controls.Add(this.LblGreenGoals);
            this.GroupBoxGreen.Controls.Add(this.TxtGreenTeamName1);
            this.GroupBoxGreen.Controls.Add(this.BtnGreenUp);
            this.GroupBoxGreen.Controls.Add(this.TxtGreenGoals);
            this.GroupBoxGreen.Controls.Add(this.BtnGreenDown);
            this.GroupBoxGreen.Controls.Add(this.BtnGreenSetDown);
            this.GroupBoxGreen.Controls.Add(this.TxtGreenSets);
            this.GroupBoxGreen.Controls.Add(this.BtnGreenSetUp);
            this.GroupBoxGreen.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GroupBoxGreen.Location = new System.Drawing.Point(6, 20);
            this.GroupBoxGreen.Name = "GroupBoxGreen";
            this.GroupBoxGreen.Size = new System.Drawing.Size(290, 377);
            this.GroupBoxGreen.TabIndex = 0;
            this.GroupBoxGreen.TabStop = false;
            this.GroupBoxGreen.Text = "Green";
            // 
            // TxtGreenTeamName2
            // 
            this.TxtGreenTeamName2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtGreenTeamName2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtGreenTeamName2.Location = new System.Drawing.Point(6, 78);
            this.TxtGreenTeamName2.Name = "TxtGreenTeamName2";
            this.TxtGreenTeamName2.Size = new System.Drawing.Size(273, 32);
            this.TxtGreenTeamName2.TabIndex = 1;
            // 
            // LblGreenSets
            // 
            this.LblGreenSets.AutoSize = true;
            this.LblGreenSets.Location = new System.Drawing.Point(125, 159);
            this.LblGreenSets.Name = "LblGreenSets";
            this.LblGreenSets.Size = new System.Drawing.Size(48, 28);
            this.LblGreenSets.TabIndex = 20;
            this.LblGreenSets.Text = "Sets";
            // 
            // LblGreenGoals
            // 
            this.LblGreenGoals.AutoSize = true;
            this.LblGreenGoals.Location = new System.Drawing.Point(5, 140);
            this.LblGreenGoals.Name = "LblGreenGoals";
            this.LblGreenGoals.Size = new System.Drawing.Size(61, 28);
            this.LblGreenGoals.TabIndex = 19;
            this.LblGreenGoals.Text = "Goals";
            // 
            // TxtGreenTeamName1
            // 
            this.TxtGreenTeamName1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtGreenTeamName1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtGreenTeamName1.Location = new System.Drawing.Point(6, 40);
            this.TxtGreenTeamName1.Name = "TxtGreenTeamName1";
            this.TxtGreenTeamName1.Size = new System.Drawing.Size(273, 32);
            this.TxtGreenTeamName1.TabIndex = 0;
            // 
            // BtnGreenUp
            // 
            this.BtnGreenUp.BackgroundImage = global::FoosballScoreboard.Forms.Properties.Resources.icons8_rangabzeichen_hoch_96;
            this.BtnGreenUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnGreenUp.Location = new System.Drawing.Point(6, 171);
            this.BtnGreenUp.Name = "BtnGreenUp";
            this.BtnGreenUp.Size = new System.Drawing.Size(64, 32);
            this.BtnGreenUp.TabIndex = 2;
            this.BtnGreenUp.UseVisualStyleBackColor = true;
            this.BtnGreenUp.Click += new System.EventHandler(this.BtnGreenUp_Click);
            // 
            // TxtGreenGoals
            // 
            this.TxtGreenGoals.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtGreenGoals.Location = new System.Drawing.Point(6, 209);
            this.TxtGreenGoals.Name = "TxtGreenGoals";
            this.TxtGreenGoals.Size = new System.Drawing.Size(64, 52);
            this.TxtGreenGoals.TabIndex = 3;
            this.TxtGreenGoals.Text = "5";
            this.TxtGreenGoals.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnGreenDown
            // 
            this.BtnGreenDown.BackgroundImage = global::FoosballScoreboard.Forms.Properties.Resources.icons8_rangabzeichen_runter_96;
            this.BtnGreenDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnGreenDown.Location = new System.Drawing.Point(6, 267);
            this.BtnGreenDown.Name = "BtnGreenDown";
            this.BtnGreenDown.Size = new System.Drawing.Size(64, 32);
            this.BtnGreenDown.TabIndex = 4;
            this.BtnGreenDown.UseVisualStyleBackColor = true;
            this.BtnGreenDown.Click += new System.EventHandler(this.BtnGreenDown_Click);
            // 
            // BtnGreenSetDown
            // 
            this.BtnGreenSetDown.BackgroundImage = global::FoosballScoreboard.Forms.Properties.Resources.icons8_rangabzeichen_runter_96;
            this.BtnGreenSetDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnGreenSetDown.Location = new System.Drawing.Point(125, 256);
            this.BtnGreenSetDown.Name = "BtnGreenSetDown";
            this.BtnGreenSetDown.Size = new System.Drawing.Size(64, 20);
            this.BtnGreenSetDown.TabIndex = 7;
            this.BtnGreenSetDown.UseVisualStyleBackColor = true;
            this.BtnGreenSetDown.Click += new System.EventHandler(this.BtnGreenSetDown_Click);
            // 
            // TxtGreenSets
            // 
            this.TxtGreenSets.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtGreenSets.Location = new System.Drawing.Point(125, 216);
            this.TxtGreenSets.Name = "TxtGreenSets";
            this.TxtGreenSets.Size = new System.Drawing.Size(64, 34);
            this.TxtGreenSets.TabIndex = 6;
            this.TxtGreenSets.Text = "5";
            this.TxtGreenSets.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnGreenSetUp
            // 
            this.BtnGreenSetUp.BackgroundImage = global::FoosballScoreboard.Forms.Properties.Resources.icons8_rangabzeichen_hoch_96;
            this.BtnGreenSetUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnGreenSetUp.Location = new System.Drawing.Point(125, 190);
            this.BtnGreenSetUp.Name = "BtnGreenSetUp";
            this.BtnGreenSetUp.Size = new System.Drawing.Size(64, 20);
            this.BtnGreenSetUp.TabIndex = 5;
            this.BtnGreenSetUp.UseVisualStyleBackColor = true;
            this.BtnGreenSetUp.Click += new System.EventHandler(this.BtnGreenSetUp_Click);
            // 
            // BtnResetScore
            // 
            this.BtnResetScore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnResetScore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnResetScore.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnResetScore.Location = new System.Drawing.Point(312, 331);
            this.BtnResetScore.Name = "BtnResetScore";
            this.BtnResetScore.Size = new System.Drawing.Size(98, 66);
            this.BtnResetScore.TabIndex = 2;
            this.BtnResetScore.Text = "Reset Score";
            this.BtnResetScore.UseVisualStyleBackColor = true;
            this.BtnResetScore.Click += new System.EventHandler(this.BtnResetScore_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(739, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenSavedPath});
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.dateiToolStripMenuItem.Text = "Datei";
            // 
            // OpenSavedPath
            // 
            this.OpenSavedPath.Name = "OpenSavedPath";
            this.OpenSavedPath.Size = new System.Drawing.Size(172, 22);
            this.OpenSavedPath.Text = "Speicherort öffnen";
            this.OpenSavedPath.Click += new System.EventHandler(this.OpenSavedPath_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(24, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 28);
            this.label3.TabIndex = 24;
            this.label3.Text = "Stage";
            // 
            // TxtStage
            // 
            this.TxtStage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtStage.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtStage.Location = new System.Drawing.Point(24, 198);
            this.TxtStage.Name = "TxtStage";
            this.TxtStage.Size = new System.Drawing.Size(388, 32);
            this.TxtStage.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(24, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 28);
            this.label4.TabIndex = 26;
            this.label4.Text = "Mode";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Best of 1",
            "Best of 3",
            "Best of 5"});
            this.comboBox1.Location = new System.Drawing.Point(24, 281);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(149, 33);
            this.comboBox1.TabIndex = 27;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 470);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Foosscroeboard+";
            this.Load += new System.EventHandler(this.Main_Load);
            this.tabControl1.ResumeLayout(false);
            this.TpTournament.ResumeLayout(false);
            this.TpTournament.PerformLayout();
            this.TpScore.ResumeLayout(false);
            this.GroupBoxBlack.ResumeLayout(false);
            this.GroupBoxBlack.PerformLayout();
            this.GroupBoxGreen.ResumeLayout(false);
            this.GroupBoxGreen.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TabControl tabControl1;
        private TabPage TpScore;
        private Button BtnBlackDown;
        private Button BtnBlackGoalUp;
        private TextBox TxtBlackGoals;
        private TextBox TxtBlackTeamName1;
        private Button BtnGreenDown;
        private TextBox TxtGreenGoals;
        private Button BtnGreenUp;
        private TextBox TxtGreenTeamName1;
        private TabPage TpTournament;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem dateiToolStripMenuItem;
        private ToolStripMenuItem OpenSavedPath;
        private Button BtnResetScore;
        private Button BtnBlackSetDown;
        private Button BtnBlackSetUp;
        private TextBox TxtBlackSets;
        private Button BtnGreenSetDown;
        private Button BtnGreenSetUp;
        private TextBox TxtGreenSets;
        private GroupBox GroupBoxGreen;
        private GroupBox GroupBoxBlack;
        private Label LblGreenGoals;
        private Label LblGreenSets;
        private Label LblBlackSets;
        private Label LblBlackGoals;
        private TextBox TxtBlackTeamName2;
        private TextBox TxtGreenTeamName2;
        private Label label2;
        private TextBox TxtCompetition;
        private Label label1;
        private TextBox TxtTournamentName;
        private Button BtnSwitchTeams;
        private ComboBox comboBox1;
        private Label label4;
        private Label label3;
        private TextBox TxtStage;
    }
}