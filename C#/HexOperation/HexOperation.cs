using System;
using System.IO;
using System.Text;

namespace HexOperation
{

    public class HexOperation
    {
        public static object HexPatch(string File, string Value, string Replace)
        {
            do
            {
                byte[] SearchIn;
                var FS = new FileStream(File, FileMode.Open);
                var BR = new BinaryReader(FS);
                SearchIn = BR.ReadBytes((int)FS.Length);
                BR.Close();
                FS.Close();
                byte[] SearchFor;
                SearchFor = Encoding.ASCII.GetBytes(Value);
                int StartIndex = ByteArraySearch(SearchIn, SearchFor);
                if (StartIndex == -1)
                {
                    Console.WriteLine("File Patched!");
                    return true;
                    break;
                }
                else
                {
                    var FSf = new FileStream(File, FileMode.Open);
                    var BW = new BinaryWriter(FSf, Encoding.ASCII);
                    BW.Seek(StartIndex - 1, SeekOrigin.Begin);
                    BW.Write(Replace);
                    BW.Close();
                    FSf.Close();
                }
            }
            while (true);
        }
        public static int ByteArraySearch(byte[] SearchIn, byte[] SearchFor)
        {
            int SearchInIndex = 0;
            int SearchForIndex = 0;
            int FoundIndex = -1;
            if (SearchFor is null)
                return FoundIndex;
            if (SearchFor.Length == 0)
                return FoundIndex;
            if (SearchIn is null)
                return FoundIndex;
            if (SearchIn.Length == 0)
                return FoundIndex;
            var loopTo = SearchIn.Length - 1;
            for (SearchInIndex = 0; SearchInIndex <= loopTo; SearchInIndex++)
            {
                if (SearchIn[SearchInIndex].Equals(SearchFor[SearchForIndex]))
                {
                    if (SearchForIndex == 0)
                    {
                        FoundIndex = SearchInIndex;
                    }
                    SearchForIndex += 1;
                    if (SearchForIndex == SearchFor.Length)
                    {
                        return FoundIndex;
                    }
                }
                else
                {
                    FoundIndex = -1;
                    SearchForIndex = 0;
                }
            }
            return FoundIndex;
        }
    }
}