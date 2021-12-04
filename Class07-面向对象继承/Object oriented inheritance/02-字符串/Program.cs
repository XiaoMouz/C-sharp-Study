using System;

namespace _02_字符串
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1、字符串的不可变性在Note.md中
            //2、string可以看做char类型的只读数组
            string pp2 = "abcdefg";
            //通过下标访问字符串某一元素
            Console.WriteLine(pp2[0]);
            //运行即可
            //pp2[0]='b'; 并不能给字符串下标为0的字符重新编辑 （此处体现了字符串的不可变性）
            //若要编辑可以通过以下方式来进行
            char[] ch = pp2.ToCharArray();//将string转为字符数组
            ch[0] = 'b';
            //而后通过创建对象方法来赋值
            pp2 = new string(ch);
            Console.WriteLine(pp2[0]);
            Console.WriteLine(pp2);
            //以上
        }
    }
}
