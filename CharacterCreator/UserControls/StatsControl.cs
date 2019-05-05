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
    public partial class Page3Control : UserControl
    {
        public Page3Control()
        {
            InitializeComponent();
        }

        private String setModLabel(String label, String num)
        {
            return String.Format("{0}: {1}", label, (Int32.Parse(num) / 2) - 5);
        }

        private void ComboBoxStrength_SelectedIndexChanged(object sender, EventArgs e)
        {
            StrengthModLabel.Text = setModLabel("Strength Modifier", comboBoxStrength.Text);
            UpdateStats();
        }

        private void ComboBoxDex_SelectedIndexChanged(object sender, EventArgs e)
        {
            DexModLabel.Text = setModLabel("Dexterity Modifier", comboBoxDex.Text);
            UpdateStats();
        }

        private void ComboBoxConst_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConstModLabel.Text = setModLabel("Constitution Modifier", comboBoxConst.Text);
            UpdateStats();
        }

        private void ComboBoxIntelli_SelectedIndexChanged(object sender, EventArgs e)
        {
            IntelliModLabel.Text = setModLabel("Intelligence Modifier", comboBoxIntelli.Text);
            UpdateStats();
        }

        private void ComboBoxWisdom_SelectedIndexChanged(object sender, EventArgs e)
        {
            WisdomModLabel.Text = setModLabel("Wisdom Modifier", comboBoxWisdom.Text);
            UpdateStats();
        }

        private void ComboBoxCharisma_SelectedIndexChanged(object sender, EventArgs e)
        {
            CharismaModLabel.Text = setModLabel("Charisma Modifier", comboBoxCharisma.Text);
            UpdateStats();
        }

        private void UpdateStats()
        {
            Builder.NewChar.Strength = Int32.Parse(comboBoxStrength.Text);
            Builder.NewChar.Dexterity = Int32.Parse(comboBoxDex.Text);
            Builder.NewChar.Constitution = Int32.Parse(comboBoxConst.Text);
            Builder.NewChar.Intelligence = Int32.Parse(comboBoxIntelli.Text);
            Builder.NewChar.Wisdom = Int32.Parse(comboBoxWisdom.Text);
            Builder.NewChar.Charisma = Int32.Parse(comboBoxCharisma.Text);
        }

    }
}
