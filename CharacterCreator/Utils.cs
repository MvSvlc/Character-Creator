/*
 * Utility methods to help with production
 */

using System;
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
    }
}
