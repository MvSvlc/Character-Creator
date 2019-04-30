namespace CharacterCreator
{
    partial class HomeControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.refreshButton = new System.Windows.Forms.Button();
            this.homeTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.homeSplitContainer2 = new System.Windows.Forms.SplitContainer();
            this.homeSplitContainer1 = new System.Windows.Forms.SplitContainer();
            this.homeSplitContainer3 = new System.Windows.Forms.SplitContainer();
            this.homeSplitContainer4 = new System.Windows.Forms.SplitContainer();
            this.slot1Label = new System.Windows.Forms.Label();
            this.slot2Label = new System.Windows.Forms.Label();
            this.slot3label = new System.Windows.Forms.Label();
            this.slot4Label = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.nameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.raceColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.classColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.subclassColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.backgroundColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.homeTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.homeSplitContainer2)).BeginInit();
            this.homeSplitContainer2.Panel1.SuspendLayout();
            this.homeSplitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.homeSplitContainer1)).BeginInit();
            this.homeSplitContainer1.Panel1.SuspendLayout();
            this.homeSplitContainer1.Panel2.SuspendLayout();
            this.homeSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.homeSplitContainer3)).BeginInit();
            this.homeSplitContainer3.Panel1.SuspendLayout();
            this.homeSplitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.homeSplitContainer4)).BeginInit();
            this.homeSplitContainer4.Panel1.SuspendLayout();
            this.homeSplitContainer4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.homeTableLayoutPanel);
            this.panel1.Controls.Add(this.refreshButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(757, 479);
            this.panel1.TabIndex = 2;
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(194, 433);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(75, 23);
            this.refreshButton.TabIndex = 0;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // homeTableLayoutPanel
            // 
            this.homeTableLayoutPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.homeTableLayoutPanel.ColumnCount = 1;
            this.homeTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.875F));
            this.homeTableLayoutPanel.Controls.Add(this.homeSplitContainer4, 0, 3);
            this.homeTableLayoutPanel.Controls.Add(this.homeSplitContainer3, 0, 2);
            this.homeTableLayoutPanel.Controls.Add(this.homeSplitContainer1, 0, 0);
            this.homeTableLayoutPanel.Controls.Add(this.homeSplitContainer2, 0, 1);
            this.homeTableLayoutPanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.homeTableLayoutPanel.Location = new System.Drawing.Point(37, 27);
            this.homeTableLayoutPanel.Name = "homeTableLayoutPanel";
            this.homeTableLayoutPanel.RowCount = 4;
            this.homeTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.homeTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.homeTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.homeTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.homeTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.homeTableLayoutPanel.Size = new System.Drawing.Size(662, 387);
            this.homeTableLayoutPanel.TabIndex = 1;
            // 
            // homeSplitContainer2
            // 
            this.homeSplitContainer2.Location = new System.Drawing.Point(3, 99);
            this.homeSplitContainer2.Name = "homeSplitContainer2";
            // 
            // homeSplitContainer2.Panel1
            // 
            this.homeSplitContainer2.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.homeSplitContainer2.Panel1.Controls.Add(this.slot2Label);
            // 
            // homeSplitContainer2.Panel2
            // 
            this.homeSplitContainer2.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.homeSplitContainer2.Size = new System.Drawing.Size(656, 90);
            this.homeSplitContainer2.SplitterDistance = 107;
            this.homeSplitContainer2.TabIndex = 5;
            // 
            // homeSplitContainer1
            // 
            this.homeSplitContainer1.Location = new System.Drawing.Point(3, 3);
            this.homeSplitContainer1.Name = "homeSplitContainer1";
            // 
            // homeSplitContainer1.Panel1
            // 
            this.homeSplitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.homeSplitContainer1.Panel1.Controls.Add(this.slot1Label);
            // 
            // homeSplitContainer1.Panel2
            // 
            this.homeSplitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.homeSplitContainer1.Panel2.Controls.Add(this.listView1);
            this.homeSplitContainer1.Size = new System.Drawing.Size(656, 90);
            this.homeSplitContainer1.SplitterDistance = 107;
            this.homeSplitContainer1.TabIndex = 6;
            // 
            // homeSplitContainer3
            // 
            this.homeSplitContainer3.Location = new System.Drawing.Point(3, 195);
            this.homeSplitContainer3.Name = "homeSplitContainer3";
            // 
            // homeSplitContainer3.Panel1
            // 
            this.homeSplitContainer3.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.homeSplitContainer3.Panel1.Controls.Add(this.slot3label);
            // 
            // homeSplitContainer3.Panel2
            // 
            this.homeSplitContainer3.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.homeSplitContainer3.Size = new System.Drawing.Size(656, 90);
            this.homeSplitContainer3.SplitterDistance = 107;
            this.homeSplitContainer3.TabIndex = 7;
            // 
            // homeSplitContainer4
            // 
            this.homeSplitContainer4.Location = new System.Drawing.Point(3, 291);
            this.homeSplitContainer4.Name = "homeSplitContainer4";
            // 
            // homeSplitContainer4.Panel1
            // 
            this.homeSplitContainer4.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.homeSplitContainer4.Panel1.Controls.Add(this.slot4Label);
            // 
            // homeSplitContainer4.Panel2
            // 
            this.homeSplitContainer4.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.homeSplitContainer4.Size = new System.Drawing.Size(656, 90);
            this.homeSplitContainer4.SplitterDistance = 107;
            this.homeSplitContainer4.TabIndex = 8;
            // 
            // slot1Label
            // 
            this.slot1Label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.slot1Label.AutoSize = true;
            this.slot1Label.ForeColor = System.Drawing.SystemColors.Control;
            this.slot1Label.Location = new System.Drawing.Point(38, 42);
            this.slot1Label.Name = "slot1Label";
            this.slot1Label.Size = new System.Drawing.Size(34, 13);
            this.slot1Label.TabIndex = 0;
            this.slot1Label.Text = "Slot 1";
            // 
            // slot2Label
            // 
            this.slot2Label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.slot2Label.AutoSize = true;
            this.slot2Label.ForeColor = System.Drawing.SystemColors.Control;
            this.slot2Label.Location = new System.Drawing.Point(36, 39);
            this.slot2Label.Name = "slot2Label";
            this.slot2Label.Size = new System.Drawing.Size(34, 13);
            this.slot2Label.TabIndex = 1;
            this.slot2Label.Text = "Slot 2";
            // 
            // slot3label
            // 
            this.slot3label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.slot3label.AutoSize = true;
            this.slot3label.ForeColor = System.Drawing.SystemColors.Control;
            this.slot3label.Location = new System.Drawing.Point(36, 39);
            this.slot3label.Name = "slot3label";
            this.slot3label.Size = new System.Drawing.Size(34, 13);
            this.slot3label.TabIndex = 1;
            this.slot3label.Text = "Slot 3";
            // 
            // slot4Label
            // 
            this.slot4Label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.slot4Label.AutoSize = true;
            this.slot4Label.ForeColor = System.Drawing.SystemColors.Control;
            this.slot4Label.Location = new System.Drawing.Point(36, 39);
            this.slot4Label.Name = "slot4Label";
            this.slot4Label.Size = new System.Drawing.Size(34, 13);
            this.slot4Label.TabIndex = 1;
            this.slot4Label.Text = "Slot 4";
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameColumn,
            this.raceColumn,
            this.classColumn,
            this.subclassColumn,
            this.backgroundColumn});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(545, 90);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // nameColumn
            // 
            this.nameColumn.Text = "Name";
            this.nameColumn.Width = 100;
            // 
            // raceColumn
            // 
            this.raceColumn.Text = "Race";
            this.raceColumn.Width = 100;
            // 
            // classColumn
            // 
            this.classColumn.Text = "Class";
            this.classColumn.Width = 100;
            // 
            // subclassColumn
            // 
            this.subclassColumn.Text = "Sub-Class";
            this.subclassColumn.Width = 100;
            // 
            // backgroundColumn
            // 
            this.backgroundColumn.Text = "Background";
            this.backgroundColumn.Width = 100;
            // 
            // HomeControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.panel1);
            this.Name = "HomeControl";
            this.Size = new System.Drawing.Size(757, 479);
            this.Load += new System.EventHandler(this.HomeControl_Load);
            this.panel1.ResumeLayout(false);
            this.homeTableLayoutPanel.ResumeLayout(false);
            this.homeSplitContainer2.Panel1.ResumeLayout(false);
            this.homeSplitContainer2.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.homeSplitContainer2)).EndInit();
            this.homeSplitContainer2.ResumeLayout(false);
            this.homeSplitContainer1.Panel1.ResumeLayout(false);
            this.homeSplitContainer1.Panel1.PerformLayout();
            this.homeSplitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.homeSplitContainer1)).EndInit();
            this.homeSplitContainer1.ResumeLayout(false);
            this.homeSplitContainer3.Panel1.ResumeLayout(false);
            this.homeSplitContainer3.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.homeSplitContainer3)).EndInit();
            this.homeSplitContainer3.ResumeLayout(false);
            this.homeSplitContainer4.Panel1.ResumeLayout(false);
            this.homeSplitContainer4.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.homeSplitContainer4)).EndInit();
            this.homeSplitContainer4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.TableLayoutPanel homeTableLayoutPanel;
        private System.Windows.Forms.SplitContainer homeSplitContainer2;
        private System.Windows.Forms.SplitContainer homeSplitContainer4;
        private System.Windows.Forms.Label slot4Label;
        private System.Windows.Forms.SplitContainer homeSplitContainer3;
        private System.Windows.Forms.Label slot3label;
        private System.Windows.Forms.SplitContainer homeSplitContainer1;
        private System.Windows.Forms.Label slot1Label;
        private System.Windows.Forms.Label slot2Label;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader nameColumn;
        private System.Windows.Forms.ColumnHeader raceColumn;
        private System.Windows.Forms.ColumnHeader classColumn;
        private System.Windows.Forms.ColumnHeader subclassColumn;
        private System.Windows.Forms.ColumnHeader backgroundColumn;
    }
}
