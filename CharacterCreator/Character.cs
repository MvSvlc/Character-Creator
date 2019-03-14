using System;
using System.Windows.Forms;

namespace CharacterCreator
{
    class Character
    {
        private string charName;
        private string charRace;
        private string charClass;

        public Character()
        {
            charName = null;
            charRace = null;
            charClass = null;
        }
        
        public Character(string charName, string charRace, string charClass)
        {
            charName = this.charName;
            charRace = this.charRace;
            charClass = this.charClass;
        }

        public override string ToString()
        {
            string output = null;
            output += "NAME: " + charName + " RACE: " + charRace;
            output += " CLASS: " + charClass;
            return output;
        }

        public Boolean ValidateLength(string value)
        {
            if (value.Length != 0)
                return true;
            else
                return false;
        }

        public string CharacterName
        {
            get { return charName; }
            set
            {
                if (ValidateLength(value))
                    charName = value;
            }
        }

        public string CharacterRace
        {
            get { return charRace; }
            set
            {
                if (ValidateLength(value))
                    charRace = value;
            }
        }

        public string CharacterClass
        {
            get { return charClass; }
            set
            {
                if (ValidateLength(value))
                    charClass = value;
            }
        }
        
    } // END CLASS
} // END NAMESPACE
