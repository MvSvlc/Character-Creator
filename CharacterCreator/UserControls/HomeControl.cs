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
            Builder.InitCharFiles();
            RefreshCharList();
        }

        public void RefreshCharList()
        {
            Character char1 = Utils.BinaryDeserialize(Builder.CharFile1);
            Character char2 = Utils.BinaryDeserialize(Builder.CharFile2);
            Character char3 = Utils.BinaryDeserialize(Builder.CharFile3);
            Character char4 = Utils.BinaryDeserialize(Builder.CharFile4);

            listView1.Items.Clear();
            listView1.ForeColor = Color.FromArgb(26, 188, 156);
            listView1.Items.Add(char1.Name).SubItems.AddRange(new string[] { char1.Race, char1.Subrace, char1.Class, char1.Background }, Color.FromArgb(26, 188, 156), Color.FromArgb(34, 52, 70), DefaultFont);

            listView2.Items.Clear();
            listView2.ForeColor = Color.FromArgb(26, 188, 156);
            listView2.Items.Add(char2.Name).SubItems.AddRange(new string[] { char2.Race, char2.Subrace, char2.Class, char2.Background }, Color.FromArgb(26, 188, 156), Color.FromArgb(34, 52, 70), DefaultFont);

            listView3.Items.Clear();
            listView3.ForeColor = Color.FromArgb(26, 188, 156);
            listView3.Items.Add(char3.Name).SubItems.AddRange(new string[] { char3.Race, char3.Subrace, char3.Class, char3.Background }, Color.FromArgb(26, 188, 156), Color.FromArgb(34, 52, 70), DefaultFont);

            listView4.Items.Clear();
            listView4.ForeColor = Color.FromArgb(26, 188, 156);
            listView4.Items.Add(char4.Name).SubItems.AddRange(new string[] { char4.Race, char4.Subrace, char4.Class, char4.Background }, Color.FromArgb(26, 188, 156), Color.FromArgb(34, 52, 70), DefaultFont);
        }
    }
}
