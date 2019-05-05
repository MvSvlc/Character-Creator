using System;
namespace CharacterCreator
{
    [Serializable()]
    public class Races : Stats
    {
        private string race;

        public string Race
        {
            get { return race; }
            set
            {
                race = value;

                switch (race)
                {
                    case "Elf":
                        Speed = 30;
                        Dexterity = 2;
                        break;

                    case "Human":
                        Speed = 30;
                        Strength = 1;
                        Dexterity = 1;
                        Constitution = 1;
                        Intelligence = 1;
                        Wisdom = 1;
                        Charisma = 1;
                        break;

                    case "Halfling":
                        Speed = 25;
                        Dexterity = 2;
                        break;

                    case "Dwarf":
                        Speed = 25;
                        Constitution = 2;
                        break;
                }
            }
        }

    }
}
