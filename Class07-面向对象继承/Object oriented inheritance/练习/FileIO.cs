using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 练习
{
    internal class FileIO
    {
        public static void ReadFile(string path)
        {
            if(path== null || path == "")
            {
                path = @"D:\64\BT\1.txt";
            }
            
            string[] contact;
            contact = File.ReadAllLines(path, System.Text.Encoding.Default);
            for (int i = 0; i < contact.Length; i++)
            {
                string[] strNew = contact[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                Console.WriteLine((strNew[0].Length > 10 ? strNew[0].Substring(0, 8) + "..." : strNew[0]) + '|' + strNew[1]) ;
            }
        }
    }
}
