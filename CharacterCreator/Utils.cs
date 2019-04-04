/*
 * Utility methods to help with production
 */

using System;
using System.IO;

namespace CharacterCreator
{
    public class Utils
    {
        public void setAbilities(ref int ability, int value, ref int mod)
        {
            if (value > 0)
                ability = value;
            mod = (ability / 2) - 5;
        }

        public void createCharacterFile(String name)
        {
            string directory = Directory.GetCurrentDirectory();
            string path = Path.Combine(directory, name);

            if (File.Exists(path))
            {
                File.WriteAllText(path, "THE FILE ALREADY EXISTS");
            }
            else
            {
                File.WriteAllText(path, "THE FILE DOES NOT EXIST AND HAS BEEN CREATED");
            }
        }
    }
}
