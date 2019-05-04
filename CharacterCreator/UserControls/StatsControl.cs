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
            Builder.Char1.Strength = Int32.Parse(comboBoxStrength.Text);
            Builder.Char1.Dexterity = Int32.Parse(comboBoxDex.Text);
            Builder.Char1.Constitution = Int32.Parse(comboBoxConst.Text);
            Builder.Char1.Intelligence = Int32.Parse(comboBoxIntelli.Text);
            Builder.Char1.Wisdom = Int32.Parse(comboBoxWisdom.Text);
            Builder.Char1.Charisma = Int32.Parse(comboBoxCharisma.Text);
        }

    }
}
