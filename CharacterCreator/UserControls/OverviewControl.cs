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
    public partial class OverviewControl : UserControl
    {
        public OverviewControl()
        {
            InitializeComponent();
        }

        private void GeneralSaveButton_Click(object sender, EventArgs e)
        {
            Utils.BinarySerialize(Builder.NewChar);
        }

        private void CharSlotComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Builder.SetSaveSlot(charSlotComboBox.Text);
        }
    }
}
