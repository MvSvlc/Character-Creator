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
                CharacterName = txtCharName.Text,
                CharacterRace = txtChaName.Text,
                CharacterClass = classComboBox.Text
            };
            if (txtCharName.Text == "" || txtChaName.Text == "")
            {
                MessageBox.Show("You can not leave any field empty!");
                return;
            }
            lstCharacter.Items.Add(character.ToString());
            txtCharName.Clear();
            txtChaName.Clear();
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
