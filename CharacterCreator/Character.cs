using System;
using System.Windows.Forms;

namespace CharacterCreator
{
    public class Character : Classes
    {
        private string name;
        private string background;
        private string allignment;
        private string personalityTraits;
        private string ideals;
        private string bonds;
        private string flaws;

        public Character(string name, string race , string subrace , string charClass)
        {
            Name = name;
            Race = race;
            Subrace = subrace;
            Class = charClass;
        }

        public string Background
        {
            get { return background; }
            set { background = value; }
        }

        public int FinalHP
        {
            get { return HitPoints + ConstitutionMod; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        
    } // END CLASS
} // END NAMESPACE
