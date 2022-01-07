using System;
using System.Collections;

namespace _10_ArrayList集合长度
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add(1);
            //count:表示集合中实际包含的元素个数
            //capacity:表示集合中可以包含的元素个数
            Console.WriteLine(list.Count);
            Console.WriteLine(list.Capacity);
        }
    }
}
