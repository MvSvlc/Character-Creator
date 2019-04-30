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
    public partial class HomeControl : UserControl
    {
        public HomeControl()
        {
            InitializeComponent();
        }

        private void HomeControl_Load(object sender, EventArgs e)
        {
            Builder.initCharFiles();
            Character char1 = Utils.BinaryDeserialize(Builder.CharFile1);
            listView1.ForeColor = Color.FromArgb(26, 188, 156);
            listView1.Items.Add(char1.Name).SubItems.AddRange(new string[] { char1.Race, char1.Subrace, char1.Class, char1.Background }, Color.FromArgb(26, 188, 156), Color.FromArgb(34, 52, 70), DefaultFont);
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            Character char1 = Utils.BinaryDeserialize(Builder.CharFile1);
            listView1.Items.Clear();
            listView1.ForeColor = Color.FromArgb(26, 188, 156);
            listView1.Items.Add(char1.Name).SubItems.AddRange(new string[]{ char1.Race, char1.Subrace, char1.Class, char1.Background }, Color.FromArgb(26, 188, 156), Color.FromArgb(34, 52, 70), new Font(DefaultFont, FontStyle.Regular));
        }
    }
}
