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

        public FrmMain()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            Character character = new Character
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                CharacterClass = txtClass.Text
            };
            if (txtFirstName.Text == "" || txtLastName.Text == "" || txtClass.Text == "")
            {
                MessageBox.Show("You can not leave any field empty!");
                return;
            }
            lstCharacter.Items.Add(character.ToString());
            txtFirstName.Clear();
            txtLastName.Clear();
            txtClass.Clear();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void titleLabel_MouseDown(object sender, MouseEventArgs e)
        {
            toggleMove = true;
            mouseXVal = e.X;
            mouseYVal = e.Y;
        }

        private void titleLabel_MouseUp(object sender, MouseEventArgs e)
        {
            toggleMove = false;
        }

        private void titleLabel_MouseMove(object sender, MouseEventArgs e)
        {
            if (toggleMove)
                this.SetDesktopLocation(MousePosition.X - mouseXVal, MousePosition.Y - mouseYVal);
        }
    }
}
