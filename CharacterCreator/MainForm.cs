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
        private Point lastLocation;
        
        public FrmMain()
        {
            InitializeComponent();
            homeControl1.BringToFront();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TitleLabel_MouseDown(object sender, MouseEventArgs e)
        {
            toggle_move = true;
            lastLocation = e.Location;
        }

        private void TitleLabel_MouseUp(object sender, MouseEventArgs e)
        {
            toggle_move = false;
        }

        private void TitleLabel_MouseMove(object sender, MouseEventArgs e)
        {
            if (toggle_move)
            {
                this.Location = new Point((this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
                this.Update();
            }
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            TitleLabel.Text = "Home";
            homeControl1.BringToFront();
            generalControl1.UpdateGeneral();
            statsControl1.UpdateStats();
        }

        private void buttonGeneralPage_Click(object sender, EventArgs e)
        {
            TitleLabel.Text = "General Character Information";
            generalControl1.BringToFront();
        }

        private void buttonStatsPage_Click(object sender, EventArgs e)
        {
            TitleLabel.Text = "Stats";
            statsControl1.BringToFront();
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

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
