using System;
namespace CharacterCreator
{
    public class Classes : Subraces
    {
        private string charClass;

        public string Class
        {
            get { return charClass; }
            set
            {
                charClass = value;
                switch (charClass)
                {
                    case "Cleric":
                        HitPoints += 8;
                        break;

                    case "Fighter":
                        HitPoints += 10;
                        break;

                    case "Rogue":
                        HitPoints += 8;
                        break;

                    case "Wizard":
                        HitPoints += 6;
                        break;
                }
            }
        }
    }
}
