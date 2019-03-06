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

            lstCharacter.Items.Add(character.ToString());
            txtFirstName.Clear();
            txtLastName.Clear();
            txtClass.Clear();
        }
    }
}
