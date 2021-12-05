using System;
using System.Text;

namespace _04_字符串的方法
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //nums.Length
            string value = "djiwai";
            Console.WriteLine("{0}",value.Length);
            //nums.ToUpper
            value = value.ToUpper();
            Console.WriteLine(value);
            //
            value = value.ToLower();
            Console.WriteLine(value);

        }
    }
}
