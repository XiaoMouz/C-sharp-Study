using System;
using System.IO;//Path所需

namespace _12_Path_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String filePath = @"D:\64\S1.txt";
            Console.WriteLine(Path.GetFileName(filePath));
            Console.WriteLine(Path.GetExtension(filePath));
            Console.WriteLine(Path.GetDirectoryName(filePath));
            Console.WriteLine(Path.GetFullPath(filePath));
        }
    }
}
