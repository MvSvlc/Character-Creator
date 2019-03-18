using System;
using System.Windows.Forms;

namespace CharacterCreator
{
    class Character : Classes
    {
        private string name;
        private string background;
        private string allignment;
        private string personalityTraits;
        private string ideals;
        private string bonds;
        private string flaws;
    
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

    } // END CLASS
} // END NAMESPACE
