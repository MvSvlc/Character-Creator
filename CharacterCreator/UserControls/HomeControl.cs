  using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CharacterCreator
{
    public partial class HomeControl : UserControl
    {
        public GeneralControl GeneralControl { get; set; }
        public MainForm MainForm { get; set; }
        public StatsControl StatsControl { get; set; }

        public HomeControl()
        {
            InitializeComponent();
        }

        private void HomeControl_Load(object sender, EventArgs e)
        {
            RefreshCharList();
        }

        public void RefreshCharList()
        {
            try
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
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        private void CreateCharButton_Click(object sender, EventArgs e)
        {
            MainForm.TitleLabel.Text = "General Character Information";
            GeneralControl?.BringToFront();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String charSlot = charSlotComboBox.Text;

            if (charSlot == "Character Slot 1")
                try
                {
                    loadCharacterInfo(Utils.BinaryDeserialize(Builder.CharFile1));
                }
                catch (Exception)
                {
                    MessageBox.Show("Character 1 could not be loaded!\n" +
                        "Redirecting to Character Creation...","File Not Found",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            else if (charSlot == "Character Slot 2")
                try
                {
                    loadCharacterInfo(Utils.BinaryDeserialize(Builder.CharFile2));
                }
                catch (Exception)
                {
                    MessageBox.Show("Character 2 could not be loaded!\n" +
                        "Redirecting to Character Creation...", "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            else if (charSlot == "Character Slot 3")
                try
                {
                    loadCharacterInfo(Utils.BinaryDeserialize(Builder.CharFile3));
                }
                catch (Exception)
                {
                    MessageBox.Show("Character 3 could not be loaded!\n" +
                        "Redirecting to Character Creation...", "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            else if (charSlot == "Character Slot 4")
                try
                {
                    loadCharacterInfo(Utils.BinaryDeserialize(Builder.CharFile4));
                }
                catch (Exception)
                {
                    MessageBox.Show("Character 4 could not be loaded!\n" +
                        "Redirecting to Character Creation...", "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            GeneralControl?.BringToFront();
            MainForm.TitleLabel.Text = "General Character Information";
        }
        private void loadCharacterInfo(Character ch)
        {
            GeneralControl.textBoxName.Text = ch.Name;
            GeneralControl.comboBoxRace.Text = ch.Race;
            GeneralControl.comboBoxSubrace.Text = ch.Subrace;
            GeneralControl.comboBoxClass.Text = ch.Class;
            GeneralControl.comboBoxBackground.Text = ch.Background;
            GeneralControl.comboBoxAlignment.Text = ch.Alignment;

            StatsControl.comboBoxStrength.Text = ch.StatsChar.Strength.ToString();
            StatsControl.comboBoxDex.Text = ch.StatsChar.Dexterity.ToString();
            StatsControl.comboBoxConst.Text = ch.StatsChar.Constitution.ToString();
            StatsControl.comboBoxIntelli.Text = ch.StatsChar.Intelligence.ToString();
            StatsControl.comboBoxWisdom.Text = ch.StatsChar.Wisdom.ToString();
            StatsControl.comboBoxCharisma.Text = ch.StatsChar.Charisma.ToString();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("You are attempting to delete Character 1\nThis is permanent are you sure?", "File Deletion", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    if (Builder.CharFile1.Exists)
                    {
                        Builder.CharFile1.Delete();
                        RefreshCharList();
                    }
                    else
                        MessageBox.Show("You can not delete a character you have not made!", "Character Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception)
                {
                    MessageBox.Show("You can not delete a character you have not made!", "Character Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                return;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("You are attempting to delete Character 2\nThis is permanent are you sure?", "File Deletion", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    if (Builder.CharFile2.Exists)
                    {
                        Builder.CharFile2.Delete();
                        RefreshCharList();
                    }
                    else
                        MessageBox.Show("You can not delete a character you have not made!", "Character Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception)
                {
                    MessageBox.Show("You can not delete a character you have not made!", "Character Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                return;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("You are attempting to delete Character 3\nThis is permanent are you sure?", "File Deletion", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    if (Builder.CharFile3.Exists)
                    {
                        Builder.CharFile3.Delete();
                        RefreshCharList();
                    }
                    else
                        MessageBox.Show("You can not delete a character you have not made!", "Character Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception)
                {
                    MessageBox.Show("You can not delete a character you have not made!", "Character Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                return;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("You are attempting to delete Character 4\nThis is permanent are you sure?", "File Deletion", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    if (Builder.CharFile4.Exists)
                    {
                        Builder.CharFile4.Delete();
                        RefreshCharList();
                    }
                    else
                        MessageBox.Show("You can not delete a character you have not made!", "Character Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception)
                {
                    MessageBox.Show("You can not delete a character you have not made!", "Character Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                return;
        }
    }
}
