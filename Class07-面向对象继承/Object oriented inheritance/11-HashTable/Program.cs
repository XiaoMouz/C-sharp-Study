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

            foreach (var item in collection)
            {

            }

            //for (int i = 0; i < a.Count; i++)
            //{
            //    Console.WriteLine(a[i]);
            //}
            Console.WriteLine(a[1]);

            //关于var
            //var能通过值来赋予类型，不需要对变量有一个明确的定义

           
        }
    }
}
