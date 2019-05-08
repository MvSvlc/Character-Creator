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

        public HomeControl HomeControl { get; set; }
        public GeneralControl GeneralControl { get; set; }
        public StatsControl StatsControl { get; set; }

        private void GeneralSaveButton_Click(object sender, EventArgs e)
        {
            Utils.BinarySerialize(Builder.NewChar);
            ClearItems(GeneralControl?.Controls);
            ClearItems(StatsControl?.Controls);
            HomeControl?.BringToFront();
        }

        private void ClearItems(ControlCollection controls)
        {
            foreach(var tlp in controls.OfType<TableLayoutPanel>().ToList())
            {
                foreach (Control c in tlp.Controls)
                {
                    if (c is TextBox tb)
                        tb.Clear();
                    else if (c is ComboBox cb)
                        cb.SelectedIndex = -1;
                }
            }
                
            foreach (Control c in controls)
                ClearItems(c.Controls);
        }

        private void CharSlotComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Builder.SetSaveSlot(charSlotComboBox.Text);
        }
    }
}
