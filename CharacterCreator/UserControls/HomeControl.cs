﻿using System;
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
    public partial class HomeControl : UserControl
    {
        public HomeControl()
        {
            InitializeComponent();
        }

        private void HomeControl_Load(object sender, EventArgs e)
        {
        
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            Character character = Utils.BinaryDeserialize("David");
            Console.WriteLine(character.Name + " | " + character.Race + " | " + character.Subrace + " | " + character.Class + " | " + character.Background);
            charListBox.Items.Add(character.toString());
        }
    }
}
