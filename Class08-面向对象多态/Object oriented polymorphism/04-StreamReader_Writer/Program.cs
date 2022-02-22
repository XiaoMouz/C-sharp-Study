using System;
using System.Text;
using System.IO;


namespace _04_StreamReader_Writer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            //创建并持续化StreamReader
            using (StreamReader readAfile = new StreamReader(@"D:\64\S1.txt",Encoding.Default))
            {
                //从头读到结尾
                while (!readAfile.EndOfStream)
                {
                    Console.WriteLine(readAfile.ReadLine());
                }

            }
            */

            //使用StreamReader写入文件
            using (StreamWriter writeAfile = new StreamWriter(@"D:\64\new.txt",En))
            {
                writeAfile.Write("hiowjdioawjdaw");
            }
        }
    }
}
