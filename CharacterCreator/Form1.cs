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
        Boolean toggleMove;
        int mouseXVal;
        int mouseYVal;
        int charTotal = 0;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TitleLabel_MouseDown(object sender, MouseEventArgs e)
        {
            toggleMove = true;
            mouseXVal = e.X;
            mouseYVal = e.Y;
        }

        private void TitleLabel_MouseUp(object sender, MouseEventArgs e)
        {
            toggleMove = false;
        }

        private void TitleLabel_MouseMove(object sender, MouseEventArgs e)
        {
            if (toggleMove)
                this.SetDesktopLocation(MousePosition.X - mouseXVal, MousePosition.Y - mouseYVal);
        }
    }
}
