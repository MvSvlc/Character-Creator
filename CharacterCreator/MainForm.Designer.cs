namespace CharacterCreator
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
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
            this.statsControl1 = new CharacterCreator.StatsControl();
            this.page4Control1 = new CharacterCreator.Page4Control();
            this.page5Control1 = new CharacterCreator.Page5Control();
            this.overviewControl1 = new CharacterCreator.OverviewControl();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(42)))), ((int)(((byte)(60)))));
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
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
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Location = new System.Drawing.Point(166, 498);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 30);
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.PictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(89, 498);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleLabel_MouseDown);
            this.pictureBox3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitleLabel_MouseMove);
            this.pictureBox3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TitleLabel_MouseUp);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(12, 498);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(1, 381);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 90);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
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
            // generalControl1
            // 
            this.generalControl1.AutoSize = true;
            this.generalControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.generalControl1.Location = new System.Drawing.Point(203, 61);
            this.generalControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.generalControl1.Name = "generalControl1";
            this.generalControl1.Size = new System.Drawing.Size(757, 479);
            this.generalControl1.TabIndex = 16;
            // 
            // statsControl1
            // 
            this.statsControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statsControl1.Location = new System.Drawing.Point(203, 61);
            this.statsControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.statsControl1.Name = "statsControl1";
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
            // MainForm
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
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Character Creator";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private StatsControl statsControl1;
        private Page4Control page4Control1;
        private Page5Control page5Control1;
        private OverviewControl overviewControl1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}

