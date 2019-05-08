using System;
namespace CharacterCreator
{
    [Serializable()]
    public class Stats : Utils
    {
        private int level = 1;
        private int strength = 0;
        private int strengthMod;
        private int dexterity = 0;
        private int dexterityMod;
        private int constitution = 0;
        private int constitutionMod;
        private int intelligence = 0;
        private int intelligenceMod;
        private int wisdom = 0;
        private int wisdomMod;
        private int charisma = 0;
        private int charismaMod;
        private int armorClass = 10;
        private int proficiencyBonus = 2;
        private int deception;

        public int HitPoints { get; set; }

        public int Strength
        {
            get { return strength; }
            set {
                    strength = value;
                    StrengthMod = ( value / 2 ) - 5;
                }
        }

        public int StrengthMod
        {
            get { return strengthMod; }
            set {
                    strengthMod = value;
                    if (value < 0)
                        Athletics = 0;
                    else
                        Athletics = value;
                }
        }

        public int Dexterity
        {
            get { return dexterity; }
            set {
                    dexterity = value;
                    DexterityMod = (value / 2) - 5;
                }
        }

        public int DexterityMod
        {
            get { return dexterityMod; }
            set
                {
                    dexterityMod = value;
                    if (value < 0)
                    {
                        Initiative = 0;
                        Acrobatics = 0;
                        SleightHand = 0;
                        Stealth = 0;
                    }
                    else
                    {
                        Initiative = value;
                        Acrobatics = value;
                        SleightHand = value;
                        Stealth = value;
                    }
                }
        }

        public int Constitution
        {
            get { return constitution; }
            set { 
                    constitution = value;
                    ConstitutionMod = (value / 2) - 5;
                }
        }

        public int ConstitutionMod
        {
            get { return constitutionMod; }
            set { constitutionMod = value; }
        }

        public int Intelligence
        {
            get { return intelligence; }
            set {
                    intelligence = value;
                    IntelligenceMod = (value / 2) - 5;
                }
        }

        public int IntelligenceMod
        {
            get { return intelligenceMod; }
            set {
                    intelligenceMod = value;
                    if (value < 0)
                    {
                        Arcana = 0;
                        History = 0;
                        Investigation = 0;
                        Nature = 0;
                        Religion = 0;
                    }
                    else 
                    {
                        Arcana = value;
                        History = value;
                        Investigation = value;
                        Nature = value;
                        Religion = value;
                    }
                }
        }

        public int Wisdom
        {
            get { return wisdom; }
            set {
                    wisdom = value;
                    WisdomMod = (value / 2) - 5;
                }
        }

        public int WisdomMod
        {
            get { return wisdomMod; }
            set {
                    wisdomMod = value;
                    if (value < 0)
                    {
                        AnimalHandling = 0;
                        Insight = 0;
                        Medicine = 0;
                        Perception = 0;
                        Survival = 0;
                    }
                    else
                    {

                        AnimalHandling = value;
                        Insight = value;
                        Medicine = value;
                        Perception = value;
                        Survival = value;
                    }
                }
        }

        public int Charisma
        {
            get { return charisma; }
            set {
                    charisma = value;
                    CharismaMod = (value / 2) - 5;
                }
        }

        public int CharismaMod
        {
            get { return charismaMod; }
            set {
                    charismaMod = value;
                    if ( value < 0)
                    {
                        deception = 0;
                        Intimidation = 0;
                        Performance = 0;
                        Persuasion = 0;
                    }
                    else
                    {
                        deception = value;
                        Intimidation = value;
                        Performance = value;
                        Persuasion = value;
                    }
                }
        }

        public int ArmorClass
        {
            get { return armorClass; }
            set { armorClass = value; }
        }

        public int Initiative { get; set; }

        public int Level
        {
            get { return level; }
            set { level = value; }
        }

        public int Speed { get; set; }


        public int Acrobatics { get; private set; }

        public int AnimalHandling { get; private set; }

        public int Arcana { get; private set; }

        public int Athletics { get; private set; }

        public int Deception
        {
            get { return Athletics; }
        }

        public int History { get; private set; }

        public int Insight { get; private set; }

        public int Intimidation { get; private set; }

        public int Investigation { get; private set; }

        public int Medicine { get; private set; }

        public int Nature { get; private set; }

        public int Perception { get; private set; }

        public int Performance { get; private set; }

        public int Persuasion { get; private set; }

        public int Religion { get; private set; }

        public int SleightHand { get; private set; }

        public int Stealth { get; private set; }

        public int Survival { get; private set; }
    }
}
