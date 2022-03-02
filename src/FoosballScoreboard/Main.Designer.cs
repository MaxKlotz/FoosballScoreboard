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
            this.TpScore = new System.Windows.Forms.TabPage();
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
            this.TpTournament = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenSavedPath = new System.Windows.Forms.ToolStripMenuItem();
            this.TxtTournamentName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BtnApplyTournament = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.TpScore.SuspendLayout();
            this.GroupBoxBlack.SuspendLayout();
            this.GroupBoxGreen.SuspendLayout();
            this.TpTournament.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TpTournament);
            this.tabControl1.Controls.Add(this.TpScore);
            this.tabControl1.Location = new System.Drawing.Point(17, 45);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1003, 685);
            this.tabControl1.TabIndex = 0;
            // 
            // TpScore
            // 
            this.TpScore.Controls.Add(this.GroupBoxBlack);
            this.TpScore.Controls.Add(this.GroupBoxGreen);
            this.TpScore.Controls.Add(this.BtnResetScore);
            this.TpScore.Location = new System.Drawing.Point(4, 34);
            this.TpScore.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TpScore.Name = "TpScore";
            this.TpScore.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TpScore.Size = new System.Drawing.Size(995, 647);
            this.TpScore.TabIndex = 0;
            this.TpScore.Text = "Score";
            this.TpScore.UseVisualStyleBackColor = true;
            // 
            // GroupBoxBlack
            // 
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
            this.GroupBoxBlack.Location = new System.Drawing.Point(694, 33);
            this.GroupBoxBlack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GroupBoxBlack.Name = "GroupBoxBlack";
            this.GroupBoxBlack.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GroupBoxBlack.Size = new System.Drawing.Size(286, 523);
            this.GroupBoxBlack.TabIndex = 18;
            this.GroupBoxBlack.TabStop = false;
            this.GroupBoxBlack.Text = "Black";
            // 
            // TxtBlackTeamName2
            // 
            this.TxtBlackTeamName2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtBlackTeamName2.Location = new System.Drawing.Point(16, 130);
            this.TxtBlackTeamName2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtBlackTeamName2.Name = "TxtBlackTeamName2";
            this.TxtBlackTeamName2.Size = new System.Drawing.Size(260, 45);
            this.TxtBlackTeamName2.TabIndex = 22;
            // 
            // LblBlackSets
            // 
            this.LblBlackSets.AutoSize = true;
            this.LblBlackSets.Location = new System.Drawing.Point(186, 265);
            this.LblBlackSets.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblBlackSets.Name = "LblBlackSets";
            this.LblBlackSets.Size = new System.Drawing.Size(73, 41);
            this.LblBlackSets.TabIndex = 22;
            this.LblBlackSets.Text = "Sets";
            // 
            // LblBlackGoals
            // 
            this.LblBlackGoals.AutoSize = true;
            this.LblBlackGoals.Location = new System.Drawing.Point(9, 233);
            this.LblBlackGoals.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblBlackGoals.Name = "LblBlackGoals";
            this.LblBlackGoals.Size = new System.Drawing.Size(92, 41);
            this.LblBlackGoals.TabIndex = 21;
            this.LblBlackGoals.Text = "Goals";
            // 
            // TxtBlackTeamName1
            // 
            this.TxtBlackTeamName1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtBlackTeamName1.Location = new System.Drawing.Point(16, 67);
            this.TxtBlackTeamName1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtBlackTeamName1.Name = "TxtBlackTeamName1";
            this.TxtBlackTeamName1.Size = new System.Drawing.Size(260, 45);
            this.TxtBlackTeamName1.TabIndex = 4;
            // 
            // TxtBlackGoals
            // 
            this.TxtBlackGoals.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtBlackGoals.Location = new System.Drawing.Point(9, 352);
            this.TxtBlackGoals.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtBlackGoals.Name = "TxtBlackGoals";
            this.TxtBlackGoals.Size = new System.Drawing.Size(90, 74);
            this.TxtBlackGoals.TabIndex = 6;
            this.TxtBlackGoals.Text = "5";
            this.TxtBlackGoals.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnBlackSetDown
            // 
            this.BtnBlackSetDown.BackgroundImage = global::FoosballScoreboard.Forms.Properties.Resources.icons8_rangabzeichen_runter_96;
            this.BtnBlackSetDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnBlackSetDown.Location = new System.Drawing.Point(186, 427);
            this.BtnBlackSetDown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnBlackSetDown.Name = "BtnBlackSetDown";
            this.BtnBlackSetDown.Size = new System.Drawing.Size(91, 33);
            this.BtnBlackSetDown.TabIndex = 16;
            this.BtnBlackSetDown.UseVisualStyleBackColor = true;
            this.BtnBlackSetDown.Click += new System.EventHandler(this.BtnBlackSetDown_Click);
            // 
            // BtnBlackGoalUp
            // 
            this.BtnBlackGoalUp.BackgroundImage = global::FoosballScoreboard.Forms.Properties.Resources.icons8_rangabzeichen_hoch_96;
            this.BtnBlackGoalUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnBlackGoalUp.Location = new System.Drawing.Point(9, 285);
            this.BtnBlackGoalUp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnBlackGoalUp.Name = "BtnBlackGoalUp";
            this.BtnBlackGoalUp.Size = new System.Drawing.Size(91, 53);
            this.BtnBlackGoalUp.TabIndex = 7;
            this.BtnBlackGoalUp.UseVisualStyleBackColor = true;
            this.BtnBlackGoalUp.Click += new System.EventHandler(this.BtnBlackGoalUp_Click);
            // 
            // BtnBlackSetUp
            // 
            this.BtnBlackSetUp.BackgroundImage = global::FoosballScoreboard.Forms.Properties.Resources.icons8_rangabzeichen_hoch_96;
            this.BtnBlackSetUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnBlackSetUp.Location = new System.Drawing.Point(186, 317);
            this.BtnBlackSetUp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnBlackSetUp.Name = "BtnBlackSetUp";
            this.BtnBlackSetUp.Size = new System.Drawing.Size(91, 33);
            this.BtnBlackSetUp.TabIndex = 15;
            this.BtnBlackSetUp.UseVisualStyleBackColor = true;
            this.BtnBlackSetUp.Click += new System.EventHandler(this.BtnBlackSetUp_Click);
            // 
            // BtnBlackDown
            // 
            this.BtnBlackDown.BackgroundImage = global::FoosballScoreboard.Forms.Properties.Resources.icons8_rangabzeichen_runter_96;
            this.BtnBlackDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnBlackDown.Location = new System.Drawing.Point(9, 448);
            this.BtnBlackDown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnBlackDown.Name = "BtnBlackDown";
            this.BtnBlackDown.Size = new System.Drawing.Size(91, 53);
            this.BtnBlackDown.TabIndex = 8;
            this.BtnBlackDown.UseVisualStyleBackColor = true;
            this.BtnBlackDown.Click += new System.EventHandler(this.BtnBlackDown_Click);
            // 
            // TxtBlackSets
            // 
            this.TxtBlackSets.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtBlackSets.Location = new System.Drawing.Point(186, 360);
            this.TxtBlackSets.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtBlackSets.Name = "TxtBlackSets";
            this.TxtBlackSets.Size = new System.Drawing.Size(90, 47);
            this.TxtBlackSets.TabIndex = 14;
            this.TxtBlackSets.Text = "5";
            this.TxtBlackSets.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // GroupBoxGreen
            // 
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
            this.GroupBoxGreen.Location = new System.Drawing.Point(9, 33);
            this.GroupBoxGreen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GroupBoxGreen.Name = "GroupBoxGreen";
            this.GroupBoxGreen.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GroupBoxGreen.Size = new System.Drawing.Size(286, 523);
            this.GroupBoxGreen.TabIndex = 17;
            this.GroupBoxGreen.TabStop = false;
            this.GroupBoxGreen.Text = "Green";
            // 
            // TxtGreenTeamName2
            // 
            this.TxtGreenTeamName2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtGreenTeamName2.Location = new System.Drawing.Point(9, 130);
            this.TxtGreenTeamName2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtGreenTeamName2.Name = "TxtGreenTeamName2";
            this.TxtGreenTeamName2.Size = new System.Drawing.Size(260, 45);
            this.TxtGreenTeamName2.TabIndex = 21;
            // 
            // LblGreenSets
            // 
            this.LblGreenSets.AutoSize = true;
            this.LblGreenSets.Location = new System.Drawing.Point(179, 265);
            this.LblGreenSets.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblGreenSets.Name = "LblGreenSets";
            this.LblGreenSets.Size = new System.Drawing.Size(73, 41);
            this.LblGreenSets.TabIndex = 20;
            this.LblGreenSets.Text = "Sets";
            // 
            // LblGreenGoals
            // 
            this.LblGreenGoals.AutoSize = true;
            this.LblGreenGoals.Location = new System.Drawing.Point(7, 233);
            this.LblGreenGoals.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblGreenGoals.Name = "LblGreenGoals";
            this.LblGreenGoals.Size = new System.Drawing.Size(92, 41);
            this.LblGreenGoals.TabIndex = 19;
            this.LblGreenGoals.Text = "Goals";
            // 
            // TxtGreenTeamName1
            // 
            this.TxtGreenTeamName1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtGreenTeamName1.Location = new System.Drawing.Point(9, 67);
            this.TxtGreenTeamName1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtGreenTeamName1.Name = "TxtGreenTeamName1";
            this.TxtGreenTeamName1.Size = new System.Drawing.Size(260, 45);
            this.TxtGreenTeamName1.TabIndex = 0;
            // 
            // BtnGreenUp
            // 
            this.BtnGreenUp.BackgroundImage = global::FoosballScoreboard.Forms.Properties.Resources.icons8_rangabzeichen_hoch_96;
            this.BtnGreenUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnGreenUp.Location = new System.Drawing.Point(9, 285);
            this.BtnGreenUp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnGreenUp.Name = "BtnGreenUp";
            this.BtnGreenUp.Size = new System.Drawing.Size(91, 53);
            this.BtnGreenUp.TabIndex = 1;
            this.BtnGreenUp.UseVisualStyleBackColor = true;
            this.BtnGreenUp.Click += new System.EventHandler(this.BtnGreenUp_Click);
            // 
            // TxtGreenGoals
            // 
            this.TxtGreenGoals.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtGreenGoals.Location = new System.Drawing.Point(9, 348);
            this.TxtGreenGoals.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtGreenGoals.Name = "TxtGreenGoals";
            this.TxtGreenGoals.Size = new System.Drawing.Size(90, 74);
            this.TxtGreenGoals.TabIndex = 2;
            this.TxtGreenGoals.Text = "5";
            this.TxtGreenGoals.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnGreenDown
            // 
            this.BtnGreenDown.BackgroundImage = global::FoosballScoreboard.Forms.Properties.Resources.icons8_rangabzeichen_runter_96;
            this.BtnGreenDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnGreenDown.Location = new System.Drawing.Point(9, 445);
            this.BtnGreenDown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnGreenDown.Name = "BtnGreenDown";
            this.BtnGreenDown.Size = new System.Drawing.Size(91, 53);
            this.BtnGreenDown.TabIndex = 3;
            this.BtnGreenDown.UseVisualStyleBackColor = true;
            this.BtnGreenDown.Click += new System.EventHandler(this.BtnGreenDown_Click);
            // 
            // BtnGreenSetDown
            // 
            this.BtnGreenSetDown.BackgroundImage = global::FoosballScoreboard.Forms.Properties.Resources.icons8_rangabzeichen_runter_96;
            this.BtnGreenSetDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnGreenSetDown.Location = new System.Drawing.Point(179, 427);
            this.BtnGreenSetDown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnGreenSetDown.Name = "BtnGreenSetDown";
            this.BtnGreenSetDown.Size = new System.Drawing.Size(91, 33);
            this.BtnGreenSetDown.TabIndex = 13;
            this.BtnGreenSetDown.UseVisualStyleBackColor = true;
            this.BtnGreenSetDown.Click += new System.EventHandler(this.BtnGreenSetDown_Click);
            // 
            // TxtGreenSets
            // 
            this.TxtGreenSets.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtGreenSets.Location = new System.Drawing.Point(179, 360);
            this.TxtGreenSets.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtGreenSets.Name = "TxtGreenSets";
            this.TxtGreenSets.Size = new System.Drawing.Size(90, 47);
            this.TxtGreenSets.TabIndex = 11;
            this.TxtGreenSets.Text = "5";
            this.TxtGreenSets.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnGreenSetUp
            // 
            this.BtnGreenSetUp.BackgroundImage = global::FoosballScoreboard.Forms.Properties.Resources.icons8_rangabzeichen_hoch_96;
            this.BtnGreenSetUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnGreenSetUp.Location = new System.Drawing.Point(179, 317);
            this.BtnGreenSetUp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnGreenSetUp.Name = "BtnGreenSetUp";
            this.BtnGreenSetUp.Size = new System.Drawing.Size(91, 33);
            this.BtnGreenSetUp.TabIndex = 12;
            this.BtnGreenSetUp.UseVisualStyleBackColor = true;
            this.BtnGreenSetUp.Click += new System.EventHandler(this.BtnGreenSetUp_Click);
            // 
            // BtnResetScore
            // 
            this.BtnResetScore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnResetScore.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnResetScore.Location = new System.Drawing.Point(384, 503);
            this.BtnResetScore.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnResetScore.Name = "BtnResetScore";
            this.BtnResetScore.Size = new System.Drawing.Size(209, 53);
            this.BtnResetScore.TabIndex = 10;
            this.BtnResetScore.Text = "Reset Score";
            this.BtnResetScore.UseVisualStyleBackColor = true;
            this.BtnResetScore.Click += new System.EventHandler(this.BtnResetScore_Click);
            // 
            // TpTournament
            // 
            this.TpTournament.Controls.Add(this.BtnApplyTournament);
            this.TpTournament.Controls.Add(this.label2);
            this.TpTournament.Controls.Add(this.textBox1);
            this.TpTournament.Controls.Add(this.label1);
            this.TpTournament.Controls.Add(this.TxtTournamentName);
            this.TpTournament.Location = new System.Drawing.Point(4, 34);
            this.TpTournament.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TpTournament.Name = "TpTournament";
            this.TpTournament.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TpTournament.Size = new System.Drawing.Size(995, 647);
            this.TpTournament.TabIndex = 1;
            this.TpTournament.Text = "Tournament";
            this.TpTournament.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1020, 35);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenSavedPath});
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(69, 29);
            this.dateiToolStripMenuItem.Text = "Datei";
            // 
            // OpenSavedPath
            // 
            this.OpenSavedPath.Name = "OpenSavedPath";
            this.OpenSavedPath.Size = new System.Drawing.Size(261, 34);
            this.OpenSavedPath.Text = "Speicherort öffnen";
            this.OpenSavedPath.Click += new System.EventHandler(this.OpenSavedPath_Click);
            // 
            // TxtTournamentName
            // 
            this.TxtTournamentName.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtTournamentName.Location = new System.Drawing.Point(34, 80);
            this.TxtTournamentName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtTournamentName.Name = "TxtTournamentName";
            this.TxtTournamentName.Size = new System.Drawing.Size(952, 45);
            this.TxtTournamentName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(34, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 41);
            this.label1.TabIndex = 20;
            this.label1.Text = "Tournament Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(34, 154);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 41);
            this.label2.TabIndex = 22;
            this.label2.Text = "Competitions";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(34, 200);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(517, 45);
            this.textBox1.TabIndex = 21;
            // 
            // BtnApplyTournament
            // 
            this.BtnApplyTournament.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnApplyTournament.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnApplyTournament.Location = new System.Drawing.Point(778, 584);
            this.BtnApplyTournament.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnApplyTournament.Name = "BtnApplyTournament";
            this.BtnApplyTournament.Size = new System.Drawing.Size(209, 53);
            this.BtnApplyTournament.TabIndex = 23;
            this.BtnApplyTournament.Text = "Apply";
            this.BtnApplyTournament.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 750);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_Load);
            this.tabControl1.ResumeLayout(false);
            this.TpScore.ResumeLayout(false);
            this.GroupBoxBlack.ResumeLayout(false);
            this.GroupBoxBlack.PerformLayout();
            this.GroupBoxGreen.ResumeLayout(false);
            this.GroupBoxGreen.PerformLayout();
            this.TpTournament.ResumeLayout(false);
            this.TpTournament.PerformLayout();
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
        private Button BtnApplyTournament;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private TextBox TxtTournamentName;
    }
}