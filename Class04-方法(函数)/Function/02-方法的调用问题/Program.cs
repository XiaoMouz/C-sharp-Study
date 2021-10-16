using System;

namespace _02_方法的调用问题
    //我们在Main()函数中调用Test函数，我们管Main函数称为调用者，Test为被调用者
    //被调用者想要得到调用者的值
    //有两个方法：1、传参   2、使用静态字段来模拟全局变量（C#没有全局变量）
    //若调用者想要得到被调用者的值
    //只能return
{
    class Program
    {
        public static int _number = 10;  //静态字段


        static void Main(string[] args)
        {
            int a = 3;
            Test(a);
            Console.WriteLine(a);
            TestTwo();
        }
        public static void Test(int a)
        {
            a = a + 5; //无法访问到Main内的变量
        }


        public static void TestTwo()
        {
            Console.WriteLine(_number);
            //但是可以访问到在类内设定的静态字段
        }
    }
}
