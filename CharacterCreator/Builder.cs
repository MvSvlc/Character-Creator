using System;
using System.IO;

namespace CharacterCreator
{
    public static class Builder
    {
        public static Character NewChar { get; set; }

        public static void InitCharFiles()
        {
            CharFile1 = new FileInfo("charData1.dat");
            CharFile2 = new FileInfo("charData2.dat");
            CharFile3 = new FileInfo("charData3.dat");
            CharFile4 = new FileInfo("charData4.dat");
            ActiveCharFile = CharFile1;

            NewChar = new Character();
            /*if(!charFile1.Exists)
            {
                FileStream fs = charFile1.Open(FileMode.Create,FileAccess.ReadWrite);
                fs.Close();
            }
            if (!charFile2.Exists)
            {
                FileStream fs = charFile2.Open(FileMode.Create, FileAccess.ReadWrite);
                fs.Close();
            }
            if (!charFile3.Exists)
            {
                FileStream fs = charFile3.Open(FileMode.Create, FileAccess.ReadWrite);
                fs.Close();
            }
            if (!charFile4.Exists)
            {
                FileStream fs = charFile4.Open(FileMode.Create, FileAccess.ReadWrite);
                fs.Close();
            }*/
        }

        public static FileInfo CharFile1 { get; set; }

        public static FileInfo CharFile2 { get; set; }
        public static FileInfo CharFile3 { get; set; }
        public static FileInfo CharFile4 { get; set; }

        public static FileInfo ActiveCharFile { get; set; }

        public static void SetSaveSlot(string s)
        {
            if (s.Equals("Character Slot 1"))
            {
                ActiveCharFile = CharFile1;
            }

            else if (s.Equals("Character Slot 2"))
            {
                ActiveCharFile = CharFile2;
            }

            else if (s.Equals("Character Slot 3"))
            {
                ActiveCharFile = CharFile3;
            }

            else if (s.Equals("Character Slot 4"))
            {
                ActiveCharFile = CharFile4;
            }

        }
    }
}
