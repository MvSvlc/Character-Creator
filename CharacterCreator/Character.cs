using System;
using System.Windows.Forms;

namespace CharacterCreator
{
    [Serializable()]
    public class Character : Classes
    {
        private string name;
        private string background;
        private string alignment;
        private string personalityTraits;
        private string ideals;
        private string bonds;
        private string flaws;

        public Character()
        {
            Name = "";
            Race = "";
            Subrace = "";
            Class = "";
            Background = "";
        }

        public Character(string name, string race , string subrace , string charClass, string BG)
        {
            Name = name;
            Race = race;
            Subrace = subrace;
            Class = charClass;
            Background = BG;
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

        public string toString()
        {
            return Name + " | " + Race + " | " + Subrace + " | " + Class + " | " + Background;
        }
        
    } // END CLASS
} // END NAMESPACE
