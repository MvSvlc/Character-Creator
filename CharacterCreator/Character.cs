using System;
using System.Windows.Forms;

namespace CharacterCreator
{
    [Serializable()]
    public class Character : Classes
    {
        public String Name { get; set; }
        public String Background { get; set; }
        public String Alignment { get; set; }

        public Character()
        {
            Name = "";
            Race = "";
            Subrace = "";
            Class = "";
            Background = "";
            Alignment = "";
        }

        public Character(string name, string race , string subrace , string charClass, string BG, string alignment)
        {
            Name = name;
            Race = race;
            Subrace = subrace;
            Class = charClass;
            Background = BG;
            Alignment = alignment;
        }

        public int FinalHP
        {
            get { return HitPoints + ConstitutionMod; }
        }

        public string toString()
        {
            return Name + " | " + Race + " | " + Subrace + " | " + Class + " | " + Background;
        }
        
    } // END CLASS
} // END NAMESPACE
