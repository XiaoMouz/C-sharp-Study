using System;
using System.Collections;

namespace _09_ArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList first = new ArrayList();//创建一个集合对象
            //向ArrayList数组添加
            first.Add("jwdioaiaw");
            first.Add(3131);
            first.Add(true);
            first.Add(new int[] { 1,2,3,4,5});
            Person p = new Person();
            first.Add(p);
            first.Add(first);

            #region 处理数组与集合的第一种方法
            for (int i = 0; i < first.Count; i++)
            {
                if(first[i] is Person)
                {
                    ((Person)first[i]).Say();
                }
                else if(first[i] is int[])
                {
                    for (int j = 0; j < ((int[])first[i]).Length; j++)
                    {
                        Console.WriteLine(((int[])first[i])[j]);
                    }
                }
                else
                {
                    Console.WriteLine(first[i]);
                }
                //Console.WriteLine(first[i]);
            }
            #endregion

            //可以通过这个方法来添加数组与集合
            first.AddRange(new int[] { 12312, 1212, 342342, 121 });
            for (int i = 0; i < first.Count; i++)
            {
                Console.WriteLine(first[i]);
            }

            //删除单一元素
            first.Remove(true);
            //删除某一下标元素
            first.RemoveAt(0);
            //删除一定范围的元素
            first.RemoveRange(0, 2);
            //清空所有元素
            first.Clear();
        }
    }

    internal class Person
    {
        public void Say()
        {
            Console.WriteLine("1");
        }
    }
}
