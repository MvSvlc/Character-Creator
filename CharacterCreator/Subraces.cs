using System;
namespace CharacterCreator
{
    public class Subraces : Races
    {
        private string subrace;

        public string Subrace
        {

            get { return subrace; }
            set
            {
                subrace = value;
                switch (subrace)
                {
                    case "Hill Dwarf":
                        Wisdom += 1;
                        HitPoints += 1;
                        break;

                    case "Mountain Dwarf":
                        Strength += 2;
                        break;

                    case "High Elf":
                        Intelligence += 1;
                        break;

                    case "Wood Elf":
                        Wisdom += 1;
                        Speed = 35;
                        break;

                    case "Lightfoot":
                        Charisma += 1;
                        break;

                    case "Stout":
                        Constitution += 1;
                        break;
                }
            }
        }
    }
}
