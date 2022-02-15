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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.GroupBoxBlack = new System.Windows.Forms.GroupBox();
            this.TxtBlackTeamName = new System.Windows.Forms.TextBox();
            this.TxtBlackGoals = new System.Windows.Forms.TextBox();
            this.BtnBlackSetDown = new System.Windows.Forms.Button();
            this.BtnBlackGoalUp = new System.Windows.Forms.Button();
            this.BtnBlackSetUp = new System.Windows.Forms.Button();
            this.BtnBlackDown = new System.Windows.Forms.Button();
            this.TxtBlackSets = new System.Windows.Forms.TextBox();
            this.GroupBoxGreen = new System.Windows.Forms.GroupBox();
            this.TxtGreenTeamName = new System.Windows.Forms.TextBox();
            this.BtnGreenUp = new System.Windows.Forms.Button();
            this.TxtGreenGoals = new System.Windows.Forms.TextBox();
            this.BtnGreenDown = new System.Windows.Forms.Button();
            this.BtnGreenSetDown = new System.Windows.Forms.Button();
            this.TxtGreenSets = new System.Windows.Forms.TextBox();
            this.BtnGreenSetUp = new System.Windows.Forms.Button();
            this.BtnResetScore = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.speicherortÖffnenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.GroupBoxBlack.SuspendLayout();
            this.GroupBoxGreen.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(702, 411);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.GroupBoxBlack);
            this.tabPage1.Controls.Add(this.GroupBoxGreen);
            this.tabPage1.Controls.Add(this.BtnResetScore);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(694, 383);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Score";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // GroupBoxBlack
            // 
            this.GroupBoxBlack.Controls.Add(this.TxtBlackTeamName);
            this.GroupBoxBlack.Controls.Add(this.TxtBlackGoals);
            this.GroupBoxBlack.Controls.Add(this.BtnBlackSetDown);
            this.GroupBoxBlack.Controls.Add(this.BtnBlackGoalUp);
            this.GroupBoxBlack.Controls.Add(this.BtnBlackSetUp);
            this.GroupBoxBlack.Controls.Add(this.BtnBlackDown);
            this.GroupBoxBlack.Controls.Add(this.TxtBlackSets);
            this.GroupBoxBlack.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GroupBoxBlack.Location = new System.Drawing.Point(486, 20);
            this.GroupBoxBlack.Name = "GroupBoxBlack";
            this.GroupBoxBlack.Size = new System.Drawing.Size(200, 245);
            this.GroupBoxBlack.TabIndex = 18;
            this.GroupBoxBlack.TabStop = false;
            this.GroupBoxBlack.Text = "Black";
            // 
            // TxtBlackTeamName
            // 
            this.TxtBlackTeamName.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtBlackTeamName.Location = new System.Drawing.Point(11, 40);
            this.TxtBlackTeamName.Name = "TxtBlackTeamName";
            this.TxtBlackTeamName.Size = new System.Drawing.Size(183, 32);
            this.TxtBlackTeamName.TabIndex = 4;
            // 
            // TxtBlackGoals
            // 
            this.TxtBlackGoals.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtBlackGoals.Location = new System.Drawing.Point(6, 145);
            this.TxtBlackGoals.Name = "TxtBlackGoals";
            this.TxtBlackGoals.Size = new System.Drawing.Size(64, 52);
            this.TxtBlackGoals.TabIndex = 6;
            this.TxtBlackGoals.Text = "5";
            this.TxtBlackGoals.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnBlackSetDown
            // 
            this.BtnBlackSetDown.BackgroundImage = global::FoosballScoreboard.Forms.Properties.Resources.icons8_rangabzeichen_runter_96;
            this.BtnBlackSetDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnBlackSetDown.Location = new System.Drawing.Point(130, 190);
            this.BtnBlackSetDown.Name = "BtnBlackSetDown";
            this.BtnBlackSetDown.Size = new System.Drawing.Size(64, 20);
            this.BtnBlackSetDown.TabIndex = 16;
            this.BtnBlackSetDown.UseVisualStyleBackColor = true;
            this.BtnBlackSetDown.Click += new System.EventHandler(this.BtnBlackSetDown_Click);
            // 
            // BtnBlackGoalUp
            // 
            this.BtnBlackGoalUp.BackgroundImage = global::FoosballScoreboard.Forms.Properties.Resources.icons8_rangabzeichen_hoch_96;
            this.BtnBlackGoalUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnBlackGoalUp.Location = new System.Drawing.Point(6, 105);
            this.BtnBlackGoalUp.Name = "BtnBlackGoalUp";
            this.BtnBlackGoalUp.Size = new System.Drawing.Size(64, 32);
            this.BtnBlackGoalUp.TabIndex = 7;
            this.BtnBlackGoalUp.UseVisualStyleBackColor = true;
            this.BtnBlackGoalUp.Click += new System.EventHandler(this.BtnBlackGoalUp_Click);
            // 
            // BtnBlackSetUp
            // 
            this.BtnBlackSetUp.BackgroundImage = global::FoosballScoreboard.Forms.Properties.Resources.icons8_rangabzeichen_hoch_96;
            this.BtnBlackSetUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnBlackSetUp.Location = new System.Drawing.Point(130, 124);
            this.BtnBlackSetUp.Name = "BtnBlackSetUp";
            this.BtnBlackSetUp.Size = new System.Drawing.Size(64, 20);
            this.BtnBlackSetUp.TabIndex = 15;
            this.BtnBlackSetUp.UseVisualStyleBackColor = true;
            this.BtnBlackSetUp.Click += new System.EventHandler(this.BtnBlackSetUp_Click);
            // 
            // BtnBlackDown
            // 
            this.BtnBlackDown.BackgroundImage = global::FoosballScoreboard.Forms.Properties.Resources.icons8_rangabzeichen_runter_96;
            this.BtnBlackDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnBlackDown.Location = new System.Drawing.Point(6, 203);
            this.BtnBlackDown.Name = "BtnBlackDown";
            this.BtnBlackDown.Size = new System.Drawing.Size(64, 32);
            this.BtnBlackDown.TabIndex = 8;
            this.BtnBlackDown.UseVisualStyleBackColor = true;
            this.BtnBlackDown.Click += new System.EventHandler(this.BtnBlackDown_Click);
            // 
            // TxtBlackSets
            // 
            this.TxtBlackSets.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtBlackSets.Location = new System.Drawing.Point(130, 150);
            this.TxtBlackSets.Name = "TxtBlackSets";
            this.TxtBlackSets.Size = new System.Drawing.Size(64, 34);
            this.TxtBlackSets.TabIndex = 14;
            this.TxtBlackSets.Text = "5";
            this.TxtBlackSets.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // GroupBoxGreen
            // 
            this.GroupBoxGreen.Controls.Add(this.TxtGreenTeamName);
            this.GroupBoxGreen.Controls.Add(this.BtnGreenUp);
            this.GroupBoxGreen.Controls.Add(this.TxtGreenGoals);
            this.GroupBoxGreen.Controls.Add(this.BtnGreenDown);
            this.GroupBoxGreen.Controls.Add(this.BtnGreenSetDown);
            this.GroupBoxGreen.Controls.Add(this.TxtGreenSets);
            this.GroupBoxGreen.Controls.Add(this.BtnGreenSetUp);
            this.GroupBoxGreen.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GroupBoxGreen.Location = new System.Drawing.Point(6, 20);
            this.GroupBoxGreen.Name = "GroupBoxGreen";
            this.GroupBoxGreen.Size = new System.Drawing.Size(200, 259);
            this.GroupBoxGreen.TabIndex = 17;
            this.GroupBoxGreen.TabStop = false;
            this.GroupBoxGreen.Text = "Green";
            // 
            // TxtGreenTeamName
            // 
            this.TxtGreenTeamName.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtGreenTeamName.Location = new System.Drawing.Point(6, 40);
            this.TxtGreenTeamName.Name = "TxtGreenTeamName";
            this.TxtGreenTeamName.Size = new System.Drawing.Size(183, 32);
            this.TxtGreenTeamName.TabIndex = 0;
            // 
            // BtnGreenUp
            // 
            this.BtnGreenUp.BackgroundImage = global::FoosballScoreboard.Forms.Properties.Resources.icons8_rangabzeichen_hoch_96;
            this.BtnGreenUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnGreenUp.Location = new System.Drawing.Point(6, 105);
            this.BtnGreenUp.Name = "BtnGreenUp";
            this.BtnGreenUp.Size = new System.Drawing.Size(64, 32);
            this.BtnGreenUp.TabIndex = 1;
            this.BtnGreenUp.UseVisualStyleBackColor = true;
            this.BtnGreenUp.Click += new System.EventHandler(this.BtnGreenUp_Click);
            // 
            // TxtGreenGoals
            // 
            this.TxtGreenGoals.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtGreenGoals.Location = new System.Drawing.Point(6, 143);
            this.TxtGreenGoals.Name = "TxtGreenGoals";
            this.TxtGreenGoals.Size = new System.Drawing.Size(64, 52);
            this.TxtGreenGoals.TabIndex = 2;
            this.TxtGreenGoals.Text = "5";
            this.TxtGreenGoals.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnGreenDown
            // 
            this.BtnGreenDown.BackgroundImage = global::FoosballScoreboard.Forms.Properties.Resources.icons8_rangabzeichen_runter_96;
            this.BtnGreenDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnGreenDown.Location = new System.Drawing.Point(6, 201);
            this.BtnGreenDown.Name = "BtnGreenDown";
            this.BtnGreenDown.Size = new System.Drawing.Size(64, 32);
            this.BtnGreenDown.TabIndex = 3;
            this.BtnGreenDown.UseVisualStyleBackColor = true;
            this.BtnGreenDown.Click += new System.EventHandler(this.BtnGreenDown_Click);
            // 
            // BtnGreenSetDown
            // 
            this.BtnGreenSetDown.BackgroundImage = global::FoosballScoreboard.Forms.Properties.Resources.icons8_rangabzeichen_runter_96;
            this.BtnGreenSetDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnGreenSetDown.Location = new System.Drawing.Point(125, 190);
            this.BtnGreenSetDown.Name = "BtnGreenSetDown";
            this.BtnGreenSetDown.Size = new System.Drawing.Size(64, 20);
            this.BtnGreenSetDown.TabIndex = 13;
            this.BtnGreenSetDown.UseVisualStyleBackColor = true;
            this.BtnGreenSetDown.Click += new System.EventHandler(this.BtnGreenSetDown_Click);
            // 
            // TxtGreenSets
            // 
            this.TxtGreenSets.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtGreenSets.Location = new System.Drawing.Point(125, 150);
            this.TxtGreenSets.Name = "TxtGreenSets";
            this.TxtGreenSets.Size = new System.Drawing.Size(64, 34);
            this.TxtGreenSets.TabIndex = 11;
            this.TxtGreenSets.Text = "5";
            this.TxtGreenSets.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnGreenSetUp
            // 
            this.BtnGreenSetUp.BackgroundImage = global::FoosballScoreboard.Forms.Properties.Resources.icons8_rangabzeichen_hoch_96;
            this.BtnGreenSetUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnGreenSetUp.Location = new System.Drawing.Point(125, 124);
            this.BtnGreenSetUp.Name = "BtnGreenSetUp";
            this.BtnGreenSetUp.Size = new System.Drawing.Size(64, 20);
            this.BtnGreenSetUp.TabIndex = 12;
            this.BtnGreenSetUp.UseVisualStyleBackColor = true;
            this.BtnGreenSetUp.Click += new System.EventHandler(this.BtnGreenSetUp_Click);
            // 
            // BtnResetScore
            // 
            this.BtnResetScore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnResetScore.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnResetScore.Location = new System.Drawing.Point(269, 302);
            this.BtnResetScore.Name = "BtnResetScore";
            this.BtnResetScore.Size = new System.Drawing.Size(146, 32);
            this.BtnResetScore.TabIndex = 10;
            this.BtnResetScore.Text = "Reset Score";
            this.BtnResetScore.UseVisualStyleBackColor = true;
            this.BtnResetScore.Click += new System.EventHandler(this.BtnResetScore_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(694, 383);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(714, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.speicherortÖffnenToolStripMenuItem});
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.dateiToolStripMenuItem.Text = "Datei";
            // 
            // speicherortÖffnenToolStripMenuItem
            // 
            this.speicherortÖffnenToolStripMenuItem.Name = "speicherortÖffnenToolStripMenuItem";
            this.speicherortÖffnenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.speicherortÖffnenToolStripMenuItem.Text = "Speicherort öffnen";
            this.speicherortÖffnenToolStripMenuItem.Click += new System.EventHandler(this.speicherortÖffnenToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
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
        private TabPage tabPage1;
        private Button BtnBlackDown;
        private Button BtnBlackGoalUp;
        private TextBox TxtBlackGoals;
        private TextBox TxtBlackTeamName;
        private Button BtnGreenDown;
        private TextBox TxtGreenGoals;
        private Button BtnGreenUp;
        private TextBox TxtGreenTeamName;
        private TabPage tabPage2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem dateiToolStripMenuItem;
        private ToolStripMenuItem speicherortÖffnenToolStripMenuItem;
        private Button BtnResetScore;
        private Button BtnBlackSetDown;
        private Button BtnBlackSetUp;
        private TextBox TxtBlackSets;
        private Button BtnGreenSetDown;
        private Button BtnGreenSetUp;
        private TextBox TxtGreenSets;
        private GroupBox GroupBoxGreen;
        private GroupBox GroupBoxBlack;
    }
}