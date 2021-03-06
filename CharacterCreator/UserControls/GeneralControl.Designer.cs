﻿namespace CharacterCreator
{
    partial class GeneralControl
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
            this.GeneralSaveButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.AlignmentLabel = new System.Windows.Forms.Label();
            this.comboBoxBackground = new System.Windows.Forms.ComboBox();
            this.labelName = new System.Windows.Forms.Label();
            this.comboBoxRace = new System.Windows.Forms.ComboBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelRace = new System.Windows.Forms.Label();
            this.labelSubrace = new System.Windows.Forms.Label();
            this.labelClass = new System.Windows.Forms.Label();
            this.comboBoxSubrace = new System.Windows.Forms.ComboBox();
            this.comboBoxClass = new System.Windows.Forms.ComboBox();
            this.labelBackground = new System.Windows.Forms.Label();
            this.comboBoxAlignment = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GeneralSaveButton
            // 
            this.GeneralSaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GeneralSaveButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.GeneralSaveButton.Location = new System.Drawing.Point(3, 431);
            this.GeneralSaveButton.Name = "GeneralSaveButton";
            this.GeneralSaveButton.Size = new System.Drawing.Size(751, 45);
            this.GeneralSaveButton.TabIndex = 5;
            this.GeneralSaveButton.Text = "Save && Continue";
            this.GeneralSaveButton.UseVisualStyleBackColor = true;
            this.GeneralSaveButton.Click += new System.EventHandler(this.GeneralSaveButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.AlignmentLabel, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxBackground, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.labelName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxRace, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelRace, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelSubrace, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelClass, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxSubrace, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxClass, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelBackground, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxAlignment, 1, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(408, 356);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // AlignmentLabel
            // 
            this.AlignmentLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.AlignmentLabel.AutoSize = true;
            this.AlignmentLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.AlignmentLabel.Location = new System.Drawing.Point(16, 134);
            this.AlignmentLabel.Name = "AlignmentLabel";
            this.AlignmentLabel.Size = new System.Drawing.Size(53, 13);
            this.AlignmentLabel.TabIndex = 12;
            this.AlignmentLabel.Text = "Alignment";
            // 
            // comboBoxBackground
            // 
            this.comboBoxBackground.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBackground.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxBackground.ForeColor = System.Drawing.Color.Black;
            this.comboBoxBackground.Items.AddRange(new object[] {
            "Acolyte",
            "Criminal",
            "Folk Hero",
            "Noble",
            "Sage",
            "Soldier"});
            this.comboBoxBackground.Location = new System.Drawing.Point(89, 110);
            this.comboBoxBackground.Name = "comboBoxBackground";
            this.comboBoxBackground.Size = new System.Drawing.Size(205, 21);
            this.comboBoxBackground.TabIndex = 10;
            this.comboBoxBackground.SelectedIndexChanged += new System.EventHandler(this.ComboBoxBackground_SelectedIndexChanged);
            // 
            // labelName
            // 
            this.labelName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelName.AutoSize = true;
            this.labelName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.labelName.Location = new System.Drawing.Point(25, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 4;
            this.labelName.Text = "Name";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxRace
            // 
            this.comboBoxRace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRace.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxRace.ForeColor = System.Drawing.Color.Black;
            this.comboBoxRace.FormattingEnabled = true;
            this.comboBoxRace.Items.AddRange(new object[] {
            "Human",
            "Dwarf",
            "Elf",
            "Halfling"});
            this.comboBoxRace.Location = new System.Drawing.Point(89, 29);
            this.comboBoxRace.Name = "comboBoxRace";
            this.comboBoxRace.Size = new System.Drawing.Size(205, 21);
            this.comboBoxRace.TabIndex = 2;
            this.comboBoxRace.DropDown += new System.EventHandler(this.comboBoxRace_DropDown);
            this.comboBoxRace.SelectedIndexChanged += new System.EventHandler(this.comboBoxRace_SelectedIndexChanged);
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.textBoxName.Location = new System.Drawing.Point(89, 3);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(205, 20);
            this.textBoxName.TabIndex = 1;
            this.textBoxName.Text = "Enter a name for your character";
            this.textBoxName.Enter += new System.EventHandler(this.textBoxName_Enter);
            this.textBoxName.Leave += new System.EventHandler(this.textBoxName_Leave);
            // 
            // labelRace
            // 
            this.labelRace.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelRace.AutoSize = true;
            this.labelRace.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.labelRace.Location = new System.Drawing.Point(10, 26);
            this.labelRace.Name = "labelRace";
            this.labelRace.Size = new System.Drawing.Size(66, 13);
            this.labelRace.TabIndex = 3;
            this.labelRace.Text = "Select Race";
            // 
            // labelSubrace
            // 
            this.labelSubrace.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelSubrace.AutoSize = true;
            this.labelSubrace.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.labelSubrace.Location = new System.Drawing.Point(3, 53);
            this.labelSubrace.Name = "labelSubrace";
            this.labelSubrace.Size = new System.Drawing.Size(80, 13);
            this.labelSubrace.TabIndex = 7;
            this.labelSubrace.Text = "Select Subrace";
            // 
            // labelClass
            // 
            this.labelClass.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelClass.AutoSize = true;
            this.labelClass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.labelClass.Location = new System.Drawing.Point(10, 80);
            this.labelClass.Name = "labelClass";
            this.labelClass.Size = new System.Drawing.Size(65, 13);
            this.labelClass.TabIndex = 6;
            this.labelClass.Text = "Select Class";
            // 
            // comboBoxSubrace
            // 
            this.comboBoxSubrace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSubrace.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSubrace.ForeColor = System.Drawing.Color.Black;
            this.comboBoxSubrace.FormattingEnabled = true;
            this.comboBoxSubrace.Location = new System.Drawing.Point(89, 56);
            this.comboBoxSubrace.Name = "comboBoxSubrace";
            this.comboBoxSubrace.Size = new System.Drawing.Size(205, 21);
            this.comboBoxSubrace.TabIndex = 8;
            this.comboBoxSubrace.SelectedIndexChanged += new System.EventHandler(this.ComboBoxSubrace_SelectedIndexChanged);
            // 
            // comboBoxClass
            // 
            this.comboBoxClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxClass.ForeColor = System.Drawing.Color.Black;
            this.comboBoxClass.Items.AddRange(new object[] {
            "Cleric",
            "Fighter",
            "Rogue",
            "Wizard"});
            this.comboBoxClass.Location = new System.Drawing.Point(89, 83);
            this.comboBoxClass.Name = "comboBoxClass";
            this.comboBoxClass.Size = new System.Drawing.Size(205, 21);
            this.comboBoxClass.TabIndex = 5;
            this.comboBoxClass.SelectionChangeCommitted += new System.EventHandler(this.ComboBoxClass_SelectionChangeCommitted);
            // 
            // labelBackground
            // 
            this.labelBackground.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelBackground.AutoSize = true;
            this.labelBackground.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.labelBackground.Location = new System.Drawing.Point(10, 107);
            this.labelBackground.Name = "labelBackground";
            this.labelBackground.Size = new System.Drawing.Size(65, 13);
            this.labelBackground.TabIndex = 9;
            this.labelBackground.Text = "Background";
            // 
            // comboBoxAlignment
            // 
            this.comboBoxAlignment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAlignment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAlignment.ForeColor = System.Drawing.Color.Black;
            this.comboBoxAlignment.Items.AddRange(new object[] {
            "Lawful Good",
            "Lawful Neutral",
            "Lawful Evil",
            "Neutral Good",
            "True Neutral",
            "Neutral Evil",
            "Chaotic Good",
            "Chaotic Neutral",
            "Chaotic Evil"});
            this.comboBoxAlignment.Location = new System.Drawing.Point(89, 137);
            this.comboBoxAlignment.Name = "comboBoxAlignment";
            this.comboBoxAlignment.Size = new System.Drawing.Size(205, 21);
            this.comboBoxAlignment.TabIndex = 11;
            this.comboBoxAlignment.SelectedIndexChanged += new System.EventHandler(this.ComboBoxAlignment_SelectedIndexChanged);
            // 
            // GeneralControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.GeneralSaveButton);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "GeneralControl";
            this.Size = new System.Drawing.Size(757, 479);
            this.Load += new System.EventHandler(this.GeneralControl_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button GeneralSaveButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label AlignmentLabel;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelRace;
        private System.Windows.Forms.Label labelSubrace;
        private System.Windows.Forms.Label labelClass;
        private System.Windows.Forms.Label labelBackground;
        public System.Windows.Forms.ComboBox comboBoxBackground;
        public System.Windows.Forms.ComboBox comboBoxRace;
        public System.Windows.Forms.TextBox textBoxName;
        public System.Windows.Forms.ComboBox comboBoxSubrace;
        public System.Windows.Forms.ComboBox comboBoxClass;
        public System.Windows.Forms.ComboBox comboBoxAlignment;
    }
}
