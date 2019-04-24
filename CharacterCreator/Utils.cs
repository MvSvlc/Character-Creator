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
        public string path;
        public string name;
        public void setAbilities(ref int ability, int value, ref int mod)
        {
            if (value > 0)
                ability = value;
            mod = (ability / 2) - 5;
        }

        private void createFile(String name)
        {
            string directory = Directory.GetCurrentDirectory();
            name = @"SerialTestInfo.txt";
            path = Path.Combine(directory, name);

            if (File.Exists(path))
            {
                Console.WriteLine(path, "THE FILE ALREADY EXISTS");
            }
            else
            {
                Console.WriteLine(path, "THE FILE DOES NOT EXIST AND HAS BEEN CREATED");
                File.Create(path);
            }
        }


        public void SerializeObject(Character o)
        {
            createFile(name);

            try
            {
                File.WriteAllText(path, XmlSerialize<Character>(o));
            }
            catch (System.IO.IOException e)
            {
                Console.WriteLine(e);
            }
        }

        /*public object DeSerializeObject()
        {
            createFile(name);
            string fileText;

            try
            {
                fileText = File.ReadAllText(path);

                try
                {
                    deserializeTest = XmlDeserialize<SerializeTestClass>(fileText);
                }
                catch (SerializationException e)
                {
                    Console.WriteLine(e);
                }

                return deserializeTest;
            }
            catch (System.IO.IOException e)
            {
                Console.WriteLine(e);
            }

            return deserializeTest;
        }*/
        private string XmlSerialize<T>(T obj)
        {
            string result = "";

            try
            {
                XmlSerializer serializer = new XmlSerializer(obj.GetType());

                using (StringWriter sWriter = new StringWriter())
                {
                    serializer.Serialize(sWriter, obj);
                    result = sWriter.ToString();
                }
            }
            catch (SerializationException e)
            {
                Console.WriteLine(e);
            }

            return result;
        }

        private T XmlDeserialize<T>(string input) where T : class
        {
            System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(typeof(T));

            using (StringReader sReader = new StringReader(input))
            {
                return (T)serializer.Deserialize(sReader);
            }
        }

        public static string BinarySerialize(Character character)
        {
            FileInfo f = new FileInfo(character.Name);
            Stream s = f.Open(FileMode.Create);
            BinaryFormatter b = new BinaryFormatter();
            b.Serialize(s, character);
            s.Close();
            return character.Name;
        }

        public static Character BinaryDeserialize()
        {
            FileInfo f = new FileInfo("charInfoData.dat");
            Stream s = f.Open(FileMode.Open);
            BinaryFormatter b = new BinaryFormatter();
            Character temp =  (Character)b.Deserialize(s);
            s.Close();
            return temp;
        }
        
    }

}
