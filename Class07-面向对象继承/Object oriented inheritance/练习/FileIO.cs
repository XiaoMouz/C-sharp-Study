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
        static void ReadFile(string path)
        {
            if(path== null || path == "")
            {
                path = @"D:\64\BT\1.txt";
            }
            
            string[] contact;
            contact = File.ReadAllLines(path, System.Text.Encoding.Default);
        }
    }
}
