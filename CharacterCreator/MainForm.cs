using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CharacterCreator
{
    public partial class MainForm : Form
    {
        bool toggle_move;
        private Point lastLocation;

        public MainForm()
        {
            InitializeComponent();
            homeControl1.BringToFront();

            InitUserControls();
        }

        private void InitUserControls()
        {
            homeControl1.MainForm = this;
            homeControl1.GeneralControl = generalControl1;
            homeControl1.StatsControl = statsControl1;

            generalControl1.StatsControl = statsControl1;
            generalControl1.OverviewControl = overviewControl1;
            generalControl1.MainForm = this;

            statsControl1.OverviewControl = overviewControl1;
            statsControl1.MainForm = this;

            overviewControl1.HomeControl = homeControl1;
            overviewControl1.GeneralControl = generalControl1;
            overviewControl1.StatsControl = statsControl1;
            overviewControl1.MainForm = this;
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
            homeControl1.RefreshCharList();
        }

        private void buttonGeneralPage_Click(object sender, EventArgs e)
        {
            TitleLabel.Text = "General Character Information";
            generalControl1.BringToFront();
        }

        private void buttonStatsPage_Click(object sender, EventArgs e)
        {
            TitleLabel.Text = "Stats";
            Character tempChar = generalControl1.GetTempChar();
            Builder.NewChar = tempChar;
            statsControl1.BringToFront();
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
