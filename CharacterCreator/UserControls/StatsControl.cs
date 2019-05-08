using System;
using System.Windows.Forms;


namespace CharacterCreator
{
    public partial class StatsControl : UserControl
    {
        public OverviewControl OverviewControl { get; set; }
        public MainForm MainForm { get; set; }

        public StatsControl()
        {
            InitializeComponent();
        }

        private String setModLabel(String label, String num)
        {
            return String.Format("{0}: {1}", label, (Int32.Parse(num) / 2) - 5);
        }

        private void ComboBoxStrength_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxStrength.SelectedIndex != -1)
                StrengthModLabel.Text = setModLabel("Strength Modifier", comboBoxStrength.Text);
            else return;
        }

        private void ComboBoxDex_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxDex.SelectedIndex != -1)
                DexModLabel.Text = setModLabel("Dexterity Modifier", comboBoxDex.Text);
            else return;
        }

        private void ComboBoxConst_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxConst.SelectedIndex != -1)
                ConstModLabel.Text = setModLabel("Constitution Modifier", comboBoxConst.Text);
            else return;
        }

        private void ComboBoxIntelli_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxIntelli.SelectedIndex != -1)
                IntelliModLabel.Text = setModLabel("Intelligence Modifier", comboBoxIntelli.Text);
            else return;
        }

        private void ComboBoxWisdom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxWisdom.SelectedIndex != -1)
                WisdomModLabel.Text = setModLabel("Wisdom Modifier", comboBoxWisdom.Text);
            else return;
        }

        private void ComboBoxCharisma_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxCharisma.SelectedIndex != -1)
                CharismaModLabel.Text = setModLabel("Charisma Modifier", comboBoxCharisma.Text);
            else return;
        }

        public Character GetStatsCharacter()
        {
            Character temp = new Character();

            temp.Strength = Int32.Parse(comboBoxStrength.Text);
            temp.Dexterity = Int32.Parse(comboBoxDex.Text);
            temp.Constitution = Int32.Parse(comboBoxConst.Text);
            temp.Intelligence = Int32.Parse(comboBoxIntelli.Text);
            temp.Wisdom = Int32.Parse(comboBoxWisdom.Text);
            temp.Charisma = Int32.Parse(comboBoxCharisma.Text);
            return temp;
        }

        public void UpdateStats()
        {
            try
            {
                if (comboBoxStrength.Text == "" || comboBoxDex.Text == "" || comboBoxConst.Text == "" ||comboBoxIntelli.Text == "" || comboBoxWisdom.Text == "" || comboBoxCharisma.Text == "")
                {
                    MessageBox.Show("Can not leave any field empty!", "Error Updating Stats", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Builder.NewChar.Strength += Int32.Parse(comboBoxStrength.Text);
                    Builder.NewChar.Dexterity += Int32.Parse(comboBoxDex.Text);
                    Builder.NewChar.Constitution += Int32.Parse(comboBoxConst.Text);
                    Builder.NewChar.Intelligence += Int32.Parse(comboBoxIntelli.Text);
                    Builder.NewChar.Wisdom += Int32.Parse(comboBoxWisdom.Text);
                    Builder.NewChar.Charisma += Int32.Parse(comboBoxCharisma.Text);
                    Builder.NewChar.StatsChar = GetStatsCharacter();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        private void StatsSaveButton_Click(object sender, EventArgs e)
        {
            UpdateStats();
            Character statsChar = GetStatsCharacter();
            Console.WriteLine("Stats Char: " + statsChar.toString());

            Console.WriteLine("Final Char: "+Builder.NewChar.toString());
            OverviewControl.charCharLabel.Text = Builder.NewChar.Charisma.ToString();
            OverviewControl.charWisLabel.Text = Builder.NewChar.Wisdom.ToString();
            OverviewControl.charIntLabel.Text = Builder.NewChar.Intelligence.ToString();
            OverviewControl.charConsLabel.Text = Builder.NewChar.Constitution.ToString();
            OverviewControl.charDexLabel.Text = Builder.NewChar.Dexterity.ToString();
            OverviewControl.charStrLabel.Text = Builder.NewChar.Strength.ToString();
            OverviewControl.StrMod.Text = Builder.NewChar.StrengthMod.ToString();
            OverviewControl.ConsMod.Text = Builder.NewChar.ConstitutionMod.ToString();
            OverviewControl.DexMod.Text = Builder.NewChar.DexterityMod.ToString();
            OverviewControl.WisMod.Text = Builder.NewChar.WisdomMod.ToString();
            OverviewControl.IntMod.Text = Builder.NewChar.IntelligenceMod.ToString();
            OverviewControl.CharMod.Text = Builder.NewChar.CharismaMod.ToString();
            OverviewControl?.BringToFront();
            MainForm.TitleLabel.Text = "Overview";
        }
    }
}
