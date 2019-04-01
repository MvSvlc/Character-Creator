using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        private void button1_Click(object sender, EventArgs e)
        {
            TitleLabel.Text = "Home";
            homeControl1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TitleLabel.Text = "Page 2";
            page2Control1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TitleLabel.Text = "Page 3";
            page3Control1.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TitleLabel.Text = "Page 4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TitleLabel.Text = "Page 5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            TitleLabel.Text = "Overview";
        }

        private void page2Control1_Load(object sender, EventArgs e)
        {

        }
    }
}
