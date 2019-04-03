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
            if (!File.Exists(name)) // Does not exist
            {
                StreamWriter file = new StreamWriter(name);
                file.Write("FILE DOES NOT EXIST AND HAS BEEN CREATED");
                file.Close();
            }
            else
            {
                // The File already exists
            }
        }
    }
}
