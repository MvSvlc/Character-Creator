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
            return String.Format("{0} | {1} | {2} | {3} | {4} | {5} | STR:{6} | WIS:{7} | DEX:{8} | CONST:{9} | INT:{10} | CHAR:{11}", 
                Name, Race, Subrace,Class,Background, Alignment, Strength,Wisdom,Dexterity,Constitution, Intelligence, Charisma);
        }
        
    } // END CLASS
} // END NAMESPACE
