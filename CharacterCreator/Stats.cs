using System;
namespace CharacterCreator
{
    [Serializable()]
    public class Stats : Utils
    {
        private int hitPoints = 0;
        private int level = 1;
        private int speed;
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
        private int initiative;
        private int proficiencyBonus = 2;
        private int acrobatics;
        private int animalHandling;
        private int arcana;
        private int athletics;
        private int deception;
        private int history;
        private int insight;
        private int intimidation;
        private int investigation;
        private int medicine;
        private int nature;
        private int perception;
        private int performance;
        private int persuasion;
        private int religion;
        private int sleightHand;
        private int stealth;
        private int survival;

        public int HitPoints
        {
            get { return hitPoints; }
            set { hitPoints = value; }
        }

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
                        athletics = 0;
                    else
                        athletics = value;
                }
        }

        public int Dexterity
        {
            get { return dexterity; }
            set {
                    dexterity = value;
                    DexterityMod = ( value / 2 ) - 5;
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
                        initiative = 0;
                        acrobatics = 0;
                        sleightHand = 0;
                        stealth = 0;
                    }
                    else
                    {
                        initiative = value;
                        acrobatics = value;
                        sleightHand = value;
                        stealth = value;
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
                        arcana = 0;
                        history = 0;
                        investigation = 0;
                        nature = 0;
                        religion = 0;
                    }
                    else 
                    {
                        arcana = value;
                        history = value;
                        investigation = value;
                        nature = value;
                        religion = value;
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
                        animalHandling = 0;
                        insight = 0;
                        medicine = 0;
                        perception = 0;
                        survival = 0;
                    }
                    else
                    {

                        animalHandling = value;
                        insight = value;
                        medicine = value;
                        perception = value;
                        survival = value;
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
                        intimidation = 0;
                        performance = 0;
                        persuasion = 0;
                    }
                    else
                    {
                        deception = value;
                        intimidation = value;
                        performance = value;
                        persuasion = value;
                    }
                }
        }

        public int ArmorClass
        {
            get { return armorClass; }
            set { armorClass = value; }
        }

        public int Initiative
        {
            get { return initiative; }
            set { initiative = value; }
        }

        public int Level
        {
            get { return level; }
            set { level = value; }
        }

        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }


        public int Acrobatics
        {
            get { return acrobatics; }
        }

        public int AnimalHandling
        {
            get { return animalHandling; }
        }

        public int Arcana
        {
            get { return arcana; }
        }

        public int Athletics
        {
            get { return athletics; }
        }

        public int Deception
        {
            get { return athletics; }
        }

        public int History
        {
            get { return history; }
        }

        public int Insight
        {
            get { return insight; }

        }

        public int Intimidation
        {
            get { return intimidation; }
        }

        public int Investigation
        {
            get { return investigation; }
        }

        public int Medicine
        {
            get { return medicine; }
        }

        public int Nature
        {
            get { return nature; }
        }

        public int Perception
        {
            get { return perception; }
        }

        public int Performance
        {
            get { return performance; }
        }

        public int Persuasion
        {
            get { return persuasion; }
        }

        public int Religion
        {
            get { return religion; }
        }

        public int SleightHand
        {
            get { return sleightHand; }
        }

        public int Stealth
        {
            get { return stealth; }
        }

        public int Survival
        {
            get { return survival; }
        }
    }
}
