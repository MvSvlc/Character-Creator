using System;
using System.Windows.Forms;

namespace CharacterCreator
{
    class Character
    {
        private string name;
        private string race;
        private string charClass;
        private int strength;
        private int strengthMod;
        private int dexterity;
        private int dexterityMod;
        private int constitution;
        private int constitutionMod;
        private int intelligence;
        private int intelligenceMod;
        private int wisdom;
        private int wisdomMod;
        private int charisma;
        private int charismaMod;
        private int armorClass;
        private int initiative;
        private int level;


        public Character()
        {
            name = null;
            race = null;
            charClass = null;
        }
        
        public Character(string charName, string charRace, string charClass)
        {
            charName = this.name;
            charRace = this.race;
            charClass = this.charClass;
        }

        public override string ToString()
        {
            string output = null;
            output += "NAME: " + name + " RACE: " + race;
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
            get { return name; }
            set
            {
                if (ValidateLength(value))
                    name = value;
            }
        }

        public string CharacterRace
        {
            get { return race; }
            set
            {
                if (ValidateLength(value))
                    race = value;
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
