using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using System.Text;

namespace CharacterCreator
{
    public static class Builder
    {
        private static int charCount = 0;

        private static FileInfo charFile1;
        private static FileInfo charFile2;
        private static FileInfo charFile3;
        private static FileInfo charFile4;

        private static FileInfo activeCharFile;

        private static Character newChar;

        public static Character NewChar
        {
            get { return newChar;  }
            set { newChar = value; }
        }

        public static void InitCharFiles()
        {
            charFile1 = new FileInfo("charData1.dat");
            charFile2 = new FileInfo("charData2.dat");
            charFile3 = new FileInfo("charData3.dat");
            charFile4 = new FileInfo("charData4.dat");
            activeCharFile = charFile1;

            newChar = new Character();

            try
            {
                if(!charFile1.Exists)
                {
                    var fs = charFile1.Create();
                    

                }
                if (!charFile2.Exists)
                {
                    var fs = charFile2.Create();
                 
                }
                if (!charFile3.Exists)
                {
                    var fs = charFile3.Create();
                   
                }
                if (!charFile4.Exists)
                {
                    var fs = charFile4.Create();
                    
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }

        }

        public static int CharCount
        {
            get { return charCount; }
            set { charCount = value; }
        }

        public static FileInfo CharFile1
        {
            get { return charFile1; }
            set { charFile1 = value; }
        }

        public static FileInfo CharFile2
        {
            get { return charFile2; }
            set { charFile2 = value; }
        }
        public static FileInfo CharFile3
        {
            get { return charFile3; }
            set { charFile3 = value; }
        }
        public static FileInfo CharFile4
        {
            get { return charFile4; }
            set { charFile4 = value; }
        }

        public static FileInfo ActiveCharFile
        {
            get { return activeCharFile; }
            set { activeCharFile = value; }
        }

        public static void IncCharCount()
        {
            if (charCount < 5)
                charCount++;
            else
                throw new InvalidOperationException();
        }

        public static void DecCharCount()
        {
            if (charCount > 0)
                charCount--;
            else
                throw new InvalidOperationException();
        }

        public static void SetSaveSlot(string s)
        {
            if (s.Equals("Character Slot 1"))
            {
                activeCharFile = charFile1;
            }

            else if (s.Equals("Character Slot 2"))
            {
                activeCharFile = charFile2;
            }

            else if (s.Equals("Character Slot 3"))
            {
                activeCharFile = charFile3;
            }

            else if (s.Equals("Character Slot 4"))
            {
                activeCharFile = charFile4;
            }

        }
    }
}
