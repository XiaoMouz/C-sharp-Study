using System;
using System.IO;
using System.Text;

namespace _13_File_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //创建文件
            //File.Create(@"D:\64\C1.txt");

            //删除文件
            //File.Delete(@"D:\64\C1.txt");

            //复制文件
            //File.Copy(@"D:\64\S1.txt", @"D:\64\C1.txt");

            //写入文件
            string a3 = "How make a good\nboooooo shit";
            byte[] a3_byte = Encoding.Default.GetBytes(a3);
            File.WriteAllBytes(@"D:\64\C1.txt", a3_byte);

            //读取文件
            byte[] r1_byte = File.ReadAllBytes(@"D:\64\C1.txt");
            string r1 = Encoding.Default.GetString(r1_byte);
            Console.WriteLine(r1);

            Console.WriteLine("===========");

            string[] s1_g = File.ReadAllLines(@"D:\64\C1.txt", Encoding.Default);
            for (int i = 0; i < s1_g.Length; i++)
            {
                Console.WriteLine(s1_g[i]);
            }

            Console.WriteLine("===========");

            string s1 = File.ReadAllText(@"D:\64\C1.txt", Encoding.Default);
            Console.WriteLine(s1);
        }
    }
}
