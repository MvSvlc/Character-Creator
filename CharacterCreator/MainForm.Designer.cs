namespace CharacterCreator
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.overviewbtn = new System.Windows.Forms.Button();
            this.page5btn = new System.Windows.Forms.Button();
            this.page4btn = new System.Windows.Forms.Button();
            this.buttonStatsPage = new System.Windows.Forms.Button();
            this.buttonGeneralPage = new System.Windows.Forms.Button();
            this.buttonHome = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.homeControl1 = new CharacterCreator.HomeControl();
            this.generalControl1 = new CharacterCreator.GeneralControl();
            this.statsControl1 = new CharacterCreator.Page3Control();
            this.page4Control1 = new CharacterCreator.Page4Control();
            this.page5Control1 = new CharacterCreator.Page5Control();
            this.overviewControl1 = new CharacterCreator.OverviewControl();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(42)))), ((int)(((byte)(60)))));
            this.panel1.Controls.Add(this.overviewbtn);
            this.panel1.Controls.Add(this.page5btn);
            this.panel1.Controls.Add(this.page4btn);
            this.panel1.Controls.Add(this.buttonStatsPage);
            this.panel1.Controls.Add(this.buttonGeneralPage);
            this.panel1.Controls.Add(this.buttonHome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(203, 540);
            this.panel1.TabIndex = 13;
            // 
            // overviewbtn
            // 
            this.overviewbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.overviewbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.overviewbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.overviewbtn.Location = new System.Drawing.Point(0, 300);
            this.overviewbtn.Name = "overviewbtn";
            this.overviewbtn.Size = new System.Drawing.Size(203, 62);
            this.overviewbtn.TabIndex = 5;
            this.overviewbtn.Text = "Overview";
            this.overviewbtn.UseVisualStyleBackColor = true;
            this.overviewbtn.Click += new System.EventHandler(this.overviewbtn_Click);
            // 
            // page5btn
            // 
            this.page5btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.page5btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.page5btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.page5btn.Location = new System.Drawing.Point(0, 240);
            this.page5btn.Name = "page5btn";
            this.page5btn.Size = new System.Drawing.Size(203, 62);
            this.page5btn.TabIndex = 4;
            this.page5btn.Text = "Page 5";
            this.page5btn.UseVisualStyleBackColor = true;
            this.page5btn.Click += new System.EventHandler(this.page5btn_Click);
            // 
            // page4btn
            // 
            this.page4btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.page4btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.page4btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.page4btn.Location = new System.Drawing.Point(0, 180);
            this.page4btn.Name = "page4btn";
            this.page4btn.Size = new System.Drawing.Size(203, 62);
            this.page4btn.TabIndex = 3;
            this.page4btn.Text = "Page 4";
            this.page4btn.UseVisualStyleBackColor = true;
            this.page4btn.Click += new System.EventHandler(this.page4btn_Click);
            // 
            // buttonStatsPage
            // 
            this.buttonStatsPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStatsPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStatsPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.buttonStatsPage.Location = new System.Drawing.Point(0, 120);
            this.buttonStatsPage.Name = "buttonStatsPage";
            this.buttonStatsPage.Size = new System.Drawing.Size(203, 62);
            this.buttonStatsPage.TabIndex = 2;
            this.buttonStatsPage.Text = "Stats";
            this.buttonStatsPage.UseVisualStyleBackColor = true;
            this.buttonStatsPage.Click += new System.EventHandler(this.buttonStatsPage_Click);
            // 
            // buttonGeneralPage
            // 
            this.buttonGeneralPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGeneralPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGeneralPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.buttonGeneralPage.Location = new System.Drawing.Point(0, 60);
            this.buttonGeneralPage.Name = "buttonGeneralPage";
            this.buttonGeneralPage.Size = new System.Drawing.Size(203, 62);
            this.buttonGeneralPage.TabIndex = 1;
            this.buttonGeneralPage.Text = "General";
            this.buttonGeneralPage.UseVisualStyleBackColor = true;
            this.buttonGeneralPage.Click += new System.EventHandler(this.buttonGeneralPage_Click);
            // 
            // buttonHome
            // 
            this.buttonHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(130)))));
            this.buttonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.buttonHome.Location = new System.Drawing.Point(0, 0);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(203, 62);
            this.buttonHome.TabIndex = 0;
            this.buttonHome.Text = "Home";
            this.buttonHome.UseVisualStyleBackColor = true;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(42)))), ((int)(((byte)(60)))));
            this.panel2.Controls.Add(this.TitleLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(203, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(757, 61);
            this.panel2.TabIndex = 14;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoEllipsis = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.TitleLabel.Location = new System.Drawing.Point(0, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(757, 62);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Home";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // homeControl1
            // 
            this.homeControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.homeControl1.Location = new System.Drawing.Point(203, 61);
            this.homeControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.homeControl1.Name = "homeControl1";
            this.homeControl1.Size = new System.Drawing.Size(757, 479);
            this.homeControl1.TabIndex = 15;
            // 
            // GeneralControl1
            // 
            this.generalControl1.AutoSize = true;
            this.generalControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.generalControl1.Location = new System.Drawing.Point(203, 61);
            this.generalControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.generalControl1.Name = "GeneralControl1";
            this.generalControl1.Size = new System.Drawing.Size(757, 479);
            this.generalControl1.TabIndex = 16;
            // 
            // page3Control1
            // 
            this.statsControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statsControl1.Location = new System.Drawing.Point(203, 61);
            this.statsControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.statsControl1.Name = "page3Control1";
            this.statsControl1.Size = new System.Drawing.Size(757, 479);
            this.statsControl1.TabIndex = 17;
            // 
            // page4Control1
            // 
            this.page4Control1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.page4Control1.Location = new System.Drawing.Point(203, 61);
            this.page4Control1.Name = "page4Control1";
            this.page4Control1.Size = new System.Drawing.Size(757, 479);
            this.page4Control1.TabIndex = 18;
            // 
            // page5Control1
            // 
            this.page5Control1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.page5Control1.Location = new System.Drawing.Point(203, 61);
            this.page5Control1.Name = "page5Control1";
            this.page5Control1.Size = new System.Drawing.Size(757, 479);
            this.page5Control1.TabIndex = 19;
            // 
            // overviewControl1
            // 
            this.overviewControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.overviewControl1.Location = new System.Drawing.Point(203, 61);
            this.overviewControl1.Name = "overviewControl1";
            this.overviewControl1.Size = new System.Drawing.Size(757, 479);
            this.overviewControl1.TabIndex = 20;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(960, 540);
            this.Controls.Add(this.homeControl1);
            this.Controls.Add(this.generalControl1);
            this.Controls.Add(this.statsControl1);
            this.Controls.Add(this.page4Control1);
            this.Controls.Add(this.page5Control1);
            this.Controls.Add(this.overviewControl1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Character Creator";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button page5btn;
        private System.Windows.Forms.Button page4btn;
        private System.Windows.Forms.Button buttonStatsPage;
        private System.Windows.Forms.Button buttonGeneralPage;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Button overviewbtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label TitleLabel;
        private HomeControl homeControl1;
        private GeneralControl generalControl1;
        private Page3Control statsControl1;
        private Page4Control page4Control1;
        private Page5Control page5Control1;
        private OverviewControl overviewControl1;
    }
}

