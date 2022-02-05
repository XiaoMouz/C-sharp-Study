using System;
using System.Collections.Generic;

namespace _02_Dictionary字典
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int,string> adic = new Dictionary<int,string>();//创建一个字典

            adic.Add(1, "121");
            adic.Add(2, "889");
            adic.Add(3, "198");

            adic[1] = "233";

            //普通在Hashtable中使用的foreach遍历方式
            foreach (var item in adic.Keys)
            {
                Console.WriteLine("{0}>{1}", item, adic[item]);
            }

            //同样使用foreach但是不同参数的遍历方式
            foreach (KeyValuePair<int,string> kvp in adic)
            {
                Console.WriteLine("{0}-->{1}", kvp.Key, kvp.Value);
            }
        }
    }
}
