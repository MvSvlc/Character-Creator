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

        public void createCharacterFile(String name)
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
            createCharacterFile(name);

            try
            {
                File.WriteAllText(path, XmlSerialize<Character>(o));
            }
            catch(System.IO.IOException e)
            {
                Console.WriteLine(e);
            }
        }

        public object DeSerializeObject()
        {
            SerializeTestClass deserializeTest = new SerializeTestClass();
            createCharacterFile(name);
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
        }
        public string XmlSerialize<T>(T obj)
        {
            XmlSerializer serializer = new XmlSerializer(obj.GetType());

            using (StringWriter sWriter = new StringWriter())
            {
                serializer.Serialize(sWriter, obj);
                return sWriter.ToString();
            }
        }

        public T XmlDeserialize<T>(string input) where T : class
        {
            System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(typeof(T));

            using (StringReader sReader = new StringReader(input))
            {
                return (T)serializer.Deserialize(sReader);
            }
        }

        
    }


    public class SerializeTestClass
    {
        public int data1;
        public string data2;

        public SerializeTestClass(int d1, string d2)
        {
            data1 = d1;
            data2 = d2;
        }

        public SerializeTestClass()
        {
            data1 = 98;
            data2 = "fkjdslaflfj";
        }
    }
}
