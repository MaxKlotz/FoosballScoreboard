namespace FoosballScoreboard
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.btnGreenDown = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnGreenUp = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.speicherortÖffnenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnUpdateTeamNames = new System.Windows.Forms.Button();
            this.btnResetScore = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
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
            this.tabControl1.Size = new System.Drawing.Size(788, 411);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnResetScore);
            this.tabPage1.Controls.Add(this.btnUpdateTeamNames);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.textBox3);
            this.tabPage1.Controls.Add(this.textBox4);
            this.tabPage1.Controls.Add(this.btnGreenDown);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.btnGreenUp);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(780, 383);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Score";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::FoosballScoreboard.Properties.Resources.icons8_rangabzeichen_runter_96;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(522, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 32);
            this.button1.TabIndex = 8;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::FoosballScoreboard.Properties.Resources.icons8_rangabzeichen_hoch_96;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Location = new System.Drawing.Point(522, 85);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 32);
            this.button2.TabIndex = 7;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox3.Location = new System.Drawing.Point(522, 125);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(146, 52);
            this.textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox4.Location = new System.Drawing.Point(505, 47);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(183, 32);
            this.textBox4.TabIndex = 4;
            // 
            // btnGreenDown
            // 
            this.btnGreenDown.BackgroundImage = global::FoosballScoreboard.Properties.Resources.icons8_rangabzeichen_runter_96;
            this.btnGreenDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGreenDown.Location = new System.Drawing.Point(62, 183);
            this.btnGreenDown.Name = "btnGreenDown";
            this.btnGreenDown.Size = new System.Drawing.Size(146, 32);
            this.btnGreenDown.TabIndex = 3;
            this.btnGreenDown.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(62, 125);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(146, 52);
            this.textBox2.TabIndex = 2;
            // 
            // btnGreenUp
            // 
            this.btnGreenUp.BackgroundImage = global::FoosballScoreboard.Properties.Resources.icons8_rangabzeichen_hoch_96;
            this.btnGreenUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGreenUp.Location = new System.Drawing.Point(62, 87);
            this.btnGreenUp.Name = "btnGreenUp";
            this.btnGreenUp.Size = new System.Drawing.Size(146, 32);
            this.btnGreenUp.TabIndex = 1;
            this.btnGreenUp.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(45, 47);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(183, 32);
            this.textBox1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(780, 383);
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
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
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
            this.speicherortÖffnenToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.speicherortÖffnenToolStripMenuItem.Text = "Speicherort öffnen";
            // 
            // btnUpdateTeamNames
            // 
            this.btnUpdateTeamNames.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnUpdateTeamNames.Location = new System.Drawing.Point(294, 318);
            this.btnUpdateTeamNames.Name = "btnUpdateTeamNames";
            this.btnUpdateTeamNames.Size = new System.Drawing.Size(146, 32);
            this.btnUpdateTeamNames.TabIndex = 9;
            this.btnUpdateTeamNames.Text = "Update teams";
            this.btnUpdateTeamNames.UseVisualStyleBackColor = true;
            // 
            // btnResetScore
            // 
            this.btnResetScore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnResetScore.Location = new System.Drawing.Point(446, 318);
            this.btnResetScore.Name = "btnResetScore";
            this.btnResetScore.Size = new System.Drawing.Size(146, 32);
            this.btnResetScore.TabIndex = 10;
            this.btnResetScore.Text = "Reset Score";
            this.btnResetScore.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Button button1;
        private Button button2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button btnGreenDown;
        private TextBox textBox2;
        private Button btnGreenUp;
        private TextBox textBox1;
        private TabPage tabPage2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem dateiToolStripMenuItem;
        private ToolStripMenuItem speicherortÖffnenToolStripMenuItem;
        private Button btnResetScore;
        private Button btnUpdateTeamNames;
    }
}