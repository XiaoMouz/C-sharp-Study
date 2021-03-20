using System;

namespace _04_获取用户的输入值
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name");
            string username = Console.ReadLine();  //精髓在于Console.ReadLine来读取用户输入，并且该语法仅支持string存储
            Console.WriteLine("How old are you?only math");
            string age = Console.ReadLine();

            Console.WriteLine("您好，{0},您也{1}岁啊", username, age);
            Console.ReadKey();
        }
    }
}
