/*
 * Utility methods to help with production
 */

using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using System.Text;

namespace CharacterCreator
{
    [Serializable()]
    public class Utils
    {
        public void setAbilities(ref int ability, int value, ref int mod)
        {
            if (value > 0)
                ability = value;
            mod = (ability / 2) - 5;
        }

        public static string BinarySerialize(Character character)
        {
            Stream s = Builder.ActiveCharFile.Open(FileMode.Create);
            BinaryFormatter b = new BinaryFormatter();
            b.Serialize(s, character);
            s.Close();
            return character.Name;
        }

        public static Character BinaryDeserialize(FileInfo f)
        {
            Character temp = new Character();
            try
            {
                Stream s = f.Open(FileMode.Open);
                BinaryFormatter b = new BinaryFormatter();
                temp = (Character)b.Deserialize(s);
                s.Close();
            }
            catch(FileNotFoundException e)
            {
                Console.WriteLine(e);
            }
            
            return temp;
        }
        
    }

}
