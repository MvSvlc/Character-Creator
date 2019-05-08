using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CharacterCreator
{
    public partial class GeneralControl : UserControl
    {
        public OverviewControl OverviewControl { get; set; }
        public MainForm MainForm { get; set; }

        public GeneralControl()
        {
            InitializeComponent();
        }

        public StatsControl StatsControl { get; set; }

        private void AddSubraces(params String[] items)
        {
            comboBoxSubrace.Items.Clear();
            comboBoxSubrace.Show();
            labelSubrace.Show();
            foreach (String item in items)
                comboBoxSubrace.Items.Add(item);
        }

        // ------------------------------------------ Name Text Box control ---------------------------------------
        private void textBoxName_Enter(object sender, EventArgs e)
        {
            if (textBoxName.Text == "Enter a name for your character")
            {
                textBoxName.Text = "";
                textBoxName.Font = new Font(textBoxName.Font, FontStyle.Regular);
                textBoxName.ForeColor = Color.Black;
            }
        }

        private void textBoxName_Leave(object sender, EventArgs e)
        {
            if (textBoxName.Text == "" || textBoxName.Text == null)
            {
                textBoxName.Text = "Enter a name for your character";
                textBoxName.Font = new Font(textBoxName.Font, FontStyle.Italic);
                textBoxName.ForeColor = Color.FromArgb(100, 26, 188, 156);
            }
        }

        private void comboBoxRace_DropDown(object sender, EventArgs e)
        {
            comboBoxRace.Text = "Race";
        }

        private void GeneralControl_Load(object sender, EventArgs e)
        {
            comboBoxRace.Text = "Select your Race";
        }

        private void comboBoxRace_SelectedIndexChanged(object sender, EventArgs e)
        {
            String value = comboBoxRace.Text;

            if (value == "Human")
            {
                labelSubrace.Hide();
                comboBoxSubrace.Hide();
            }
            else if (value == "Elf")
                AddSubraces("High Elf", "Wood Elf");
            else if (value == "Dwarf")
                AddSubraces("Mountain Dwarf", "Hill Dwarf");
            else if (value == "Halfling")
                AddSubraces("Stout", "Lightfoot");

            UpdateGeneral();
        }
        

        private void GeneralSaveButton_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text == "Enter a name for your character" || textBoxName.Text == "")
                MessageBox.Show("Can not leave name field empty!", "No Character Name Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                Character tempChar = GetTempChar();
                Builder.NewChar = tempChar;
                MainForm.TitleLabel.Text = "Stats";
                UpdateGeneral();
                StatsControl?.BringToFront();
            }
        }

        public Character GetTempChar()
        {
             return new Character(Builder.NewChar.Name, Builder.NewChar.Race, Builder.NewChar.Subrace, Builder.NewChar.Class, Builder.NewChar.Background, Builder.NewChar.Alignment);

        }


        public void UpdateGeneral()
        {
            if (textBoxName.Text == "Enter a name for your character")
                MessageBox.Show("Can not leave name field empty!", "No Character Name Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                Builder.NewChar.Name = textBoxName.Text;
                Builder.NewChar.Race = comboBoxRace.Text;
                Builder.NewChar.Subrace = comboBoxSubrace.Text;
                Builder.NewChar.Class = comboBoxClass.Text;
                Builder.NewChar.Background = comboBoxBackground.Text;
                Builder.NewChar.Alignment = comboBoxAlignment.Text;
                OverviewControl.charNameLabel.Text = Builder.NewChar.Name;
                OverviewControl.charRaceLabel.Text = Builder.NewChar.Race;
                if (Builder.NewChar.Race == "Human")
                    OverviewControl.charSubraceLabel.Text = "---";
                else
                    OverviewControl.charSubraceLabel.Text = Builder.NewChar.Subrace;
                OverviewControl.charBGLabel.Text = Builder.NewChar.Background;
                OverviewControl.charAlignLabel.Text = Builder.NewChar.Alignment;
                OverviewControl.charClassLabel.Text = Builder.NewChar.Class;
            }
            
        }

        private void ComboBoxSubrace_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateGeneral();
        }

        private void ComboBoxBackground_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateGeneral();
        }

        private void ComboBoxAlignment_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateGeneral();
        }

        private void ComboBoxClass_SelectionChangeCommitted(object sender, EventArgs e)
        {
            UpdateGeneral();
        }
    }
}
