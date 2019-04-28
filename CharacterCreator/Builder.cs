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

        private static FileInfo charFile1 = new FileInfo("charData1.dat");
        private static FileInfo charFile2 = new FileInfo("charData2.dat");
        private static FileInfo charFile3 = new FileInfo("charData3.dat");
        private static FileInfo charFile4 = new FileInfo("charData4.dat");
        private static FileInfo charFile5 = new FileInfo("charData5.dat");

        private static FileInfo activeCharFile;

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
                //activeCharFile = ref charFile1;
            }
                
        }
    }
}
