using System;
using System.Windows.Forms;

namespace CharacterCreator
{
    class Character
    {
        private string name;
        private string race;
        private string charClass;
        private string background;
        private string allignment;
        private string personalityTraits;
        private string ideals;
        private string bonds;
        private string flaws;
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
            strength = 20;
            strengthMod = 0;
            dexterity = 0;
            dexterityMod = 0;
            constitution = 0;
            constitutionMod = 0;
            intelligence = 0;
            intelligenceMod = 0;
            wisdom = 0;
            wisdomMod = 0;
            charisma = 0;
            charismaMod = 0;
            armorClass = 0;
            initiative = 0;
            level = 1;
        }
        
        public Character(string charName, string charRace, string clas)
        {
            name = charName;
            race = charRace;
            charClass = clas;
            strength = 0;
            strengthMod = 0;
            dexterity = 0;
            dexterityMod = 0;
            constitution = 0;
            constitutionMod = 0;
            intelligence = 0;
            intelligenceMod = 0;
            wisdom = 0;
            wisdomMod = 0;
            charisma = 0;
            charismaMod = 0;
            armorClass = 0;
            initiative = 0;
            level = 1;
        }

        public void SetAbilities(ref int ability, int value, ref int mod)
        {
            if (value > 0)
                ability = value;
            mod = (ability / 2) - 5;
        }

        public int Strength
        {
            get { return strength; }
            set { SetAbilities(ref strength, value, ref strengthMod); }
        }

        public int StrengthMod
        {
            get { return strengthMod; }
            set
            {
                strengthMod = value;
            }
        }

        public Boolean ValidateLength(string value)
        {
            if (value.Length != 0)
                return true;
            return false;
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (ValidateLength(value))
                    name = value;
            }
        }

        public string Race
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
