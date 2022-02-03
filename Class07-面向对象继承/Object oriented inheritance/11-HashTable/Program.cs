using System;
using System.Collections;

namespace _11_HashTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable a = new Hashtable();
            //键值对集合
            a.Add("a", 1);
            a.Remove("a");
            a.Add(1, true);
            a.Add(2, false);
            a.Add(3, "jwajiod");
            a.Add(4, 'a');
            a.Add(5, 999);
            a.Add('b', "error");

            a[2] = true;//可以通过此方法来访问元素并重新赋值以及添加新的键

            //for (int i = 0; i < a.Count; i++)
            //{
            //    Console.WriteLine(a[i]);
            //}
            Console.WriteLine(a[1]);

            //通过foreach循环来遍历Hashtable的值
            foreach (var item in a.Keys)
            {
                Console.WriteLine(item);
            }


            //关于var
            //var能通过值来推断并赋予类型，不需要对变量有一个明确的定义，但是必须初始化变量(赋予初值)

           
        }
    }
}
