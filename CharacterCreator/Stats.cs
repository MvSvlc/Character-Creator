using System;
namespace CharacterCreator
{
    public class Stats : Utils
    {
        private int hitPoints = 0;
        private int level = 1;
        private int speed = 0;
        private int strength = 0;
        private int strengthMod = 0;
        private int dexterity = 0;
        private int dexterityMod = 0;
        private int constitution = 0;
        private int constitutionMod = 0;
        private int intelligence = 0;
        private int intelligenceMod = 0;
        private int wisdom = 0;
        private int wisdomMod = 0;
        private int charisma = 0;
        private int charismaMod = 0;
        private int armorClass = 0;
        private int initiative = 0;
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
            set { setAbilities(ref strength, value, ref strengthMod); }
        }

        public int StrengthMod
        {
            get { return strengthMod; }
            set 
                {
                    strengthMod = value;
                    athletics = strengthMod;
                }
        }

        public int Dexterity
        {
            get { return dexterity; }
            set { setAbilities(ref dexterity, value, ref dexterityMod); }
        }

        public int DexterityMod
        {
            get { return dexterityMod; }
            set
                {
                    dexterityMod = value;
                    initiative = dexterityMod;
                    acrobatics = dexterityMod;
                    sleightHand = dexterityMod;
                    stealth = dexterityMod;
                }
        }

        public int Constitution
        {
            get { return constitution; }
            set { setAbilities(ref constitution, value, ref constitutionMod); }
        }

        public int ConstitutionMod
        {
            get { return constitutionMod; }
            set { constitutionMod = value; }
        }

        public int Intelligence
        {
            get { return intelligence; }
            set { setAbilities(ref intelligence, value, ref intelligenceMod); }
        }

        public int IntelligenceMod
        {
            get { return intelligenceMod; }
            set 
                {
                    intelligenceMod = value;
                    arcana = intelligenceMod;
                    history = intelligenceMod;
                    investigation = intelligenceMod;
                    nature = intelligenceMod;
                    religion = intelligenceMod;
                }
        }

        public int Wisdom
        {
            get { return wisdom; }
            set { setAbilities(ref wisdom, value, ref wisdomMod); }
        }

        public int WisdomMod
        {
            get { return wisdomMod; }
            set
                {
                    wisdomMod = value;
                    animalHandling = wisdomMod;
                    insight = wisdomMod;
                    medicine = wisdomMod;
                    perception = wisdomMod;
                    survival = wisdomMod;
                }
        }

        public int Charisma
        {
            get { return charisma; }
            set { setAbilities(ref charisma, value, ref charismaMod); }
        }

        public int CharismaMod
        {
            get { return charismaMod; }
            set 
                { 
                    charismaMod = value;
                    deception = charismaMod;
                    intimidation = charismaMod;
                    performance = charismaMod;
                    perception = charismaMod;
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

    }
}
