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
    public partial class Page2Control : UserControl
    {
        public Page2Control()
        {
            InitializeComponent();
        }

        // ------------------------------------------ Name Text Box control ---------------------------------------
        private void textBoxName_Enter(object sender, EventArgs e)
        {
            if (textBoxName.Text == "Enter a name for your character")
            {
                textBoxName.Text = "";
                textBoxName.Font = new Font(textBoxName.Font, FontStyle.Regular);
                textBoxName.ForeColor = Color.Black;
            }
        }

        private void textBoxName_Leave(object sender, EventArgs e)
        {
            if (textBoxName.Text == "" || textBoxName.Text == null)
            {
                textBoxName.Text = "Enter a name for your character";
                textBoxName.Font = new Font(textBoxName.Font, FontStyle.Italic);
                textBoxName.ForeColor = Color.FromArgb(100, 26, 188, 156);
            }
        }

        private void comboBoxRace_DropDown(object sender, EventArgs e)
        {
            comboBoxRace.Text = "Race";
        }

        private void Page2Control_Load(object sender, EventArgs e)
        {
            comboBoxRace.Text = "Select your Race";
        }
    }
}
