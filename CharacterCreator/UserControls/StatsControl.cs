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
    public partial class StatsControl : UserControl
    {
        public OverviewControl OverviewControl { get; set; }
        public StatsControl()
        {
            InitializeComponent();
        }

        public StatsControl sControl
        {
            get { return this.sControl; }
            set { }
        }

        private String setModLabel(String label, String num)
        {
            return String.Format("{0}: {1}", label, (Int32.Parse(num) / 2) - 5);
        }

        private void ComboBoxStrength_SelectedIndexChanged(object sender, EventArgs e)
        {
            StrengthModLabel.Text = setModLabel("Strength Modifier", comboBoxStrength.Text);
            
        }

        private void ComboBoxDex_SelectedIndexChanged(object sender, EventArgs e)
        {
            DexModLabel.Text = setModLabel("Dexterity Modifier", comboBoxDex.Text);
            
        }

        private void ComboBoxConst_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConstModLabel.Text = setModLabel("Constitution Modifier", comboBoxConst.Text);
            
        }

        private void ComboBoxIntelli_SelectedIndexChanged(object sender, EventArgs e)
        {
            IntelliModLabel.Text = setModLabel("Intelligence Modifier", comboBoxIntelli.Text);
            
        }

        private void ComboBoxWisdom_SelectedIndexChanged(object sender, EventArgs e)
        {
            WisdomModLabel.Text = setModLabel("Wisdom Modifier", comboBoxWisdom.Text);
            
        }

        private void ComboBoxCharisma_SelectedIndexChanged(object sender, EventArgs e)
        {
            CharismaModLabel.Text = setModLabel("Charisma Modifier", comboBoxCharisma.Text);
        }

        public void UpdateStats()
        {
            try
            {
                if (comboBoxStrength.Text == "" || comboBoxDex.Text == "" || comboBoxIntelli.Text == "" || comboBoxWisdom.Text == "" || comboBoxCharisma.Text == "")
                {
                    MessageBox.Show("Can not leave any field empty!");
                }
                else
                {
                    Builder.NewChar.Strength += Int32.Parse(comboBoxStrength.Text);
                    Builder.NewChar.Dexterity += Int32.Parse(comboBoxDex.Text);
                    Builder.NewChar.Constitution += Int32.Parse(comboBoxConst.Text);
                    Builder.NewChar.Intelligence += Int32.Parse(comboBoxIntelli.Text);
                    Builder.NewChar.Wisdom += Int32.Parse(comboBoxWisdom.Text);
                    Builder.NewChar.Charisma += Int32.Parse(comboBoxCharisma.Text);
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
            Console.WriteLine(Builder.NewChar.toString());
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
            OverviewControl.BringToFront();
        }


    }
}
