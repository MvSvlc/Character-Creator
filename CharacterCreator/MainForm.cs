using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharacterCreator
{
    public partial class FrmMain : Form
    {
        bool toggle_move;
        int mouseXVal;
        int mouseYVal;
        Utils Utils = new Utils();


        public FrmMain()
        {
            InitializeComponent();
            homeControl1.BringToFront();
            Utils.createCharacterFile("Characters.txt");
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TitleLabel_MouseDown(object sender, MouseEventArgs e)
        {
            toggle_move = true;
            mouseXVal = e.X;
            mouseYVal = e.Y;
        }

        private void TitleLabel_MouseUp(object sender, MouseEventArgs e)
        {
            toggle_move = false;
        }

        private void TitleLabel_MouseMove(object sender, MouseEventArgs e)
        {
            if(toggle_move)
                this.SetDesktopLocation(MousePosition.X - mouseXVal, MousePosition.Y - mouseYVal);
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            TitleLabel.Text = "Home";
            homeControl1.BringToFront();
        }

        private void buttonGeneralPage_Click(object sender, EventArgs e)
        {
            TitleLabel.Text = "General Character Information";
            page2Control1.BringToFront();
        }

        private void buttonStatsPage_Click(object sender, EventArgs e)
        {
            TitleLabel.Text = "Stats";
            page3Control1.BringToFront();
        }

        private void page4btn_Click(object sender, EventArgs e)
        {
            TitleLabel.Text = "Page 4";
            page4Control1.BringToFront();
        }

        private void page5btn_Click(object sender, EventArgs e)
        {
            TitleLabel.Text = "Page 5";
            page5Control1.BringToFront();
        }

        private void overviewbtn_Click(object sender, EventArgs e)
        {
            TitleLabel.Text = "Overview";
            overviewControl1.BringToFront();
        }
    }
}
