using System;

namespace _05_多态
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //01 - 虚方法
            SubExample s1 = new SubExample("hi");
            SubExample s2 = new SubExample("hi2");
            TrdExample t1 = new TrdExample("hello");
            TrdExample t2 = new TrdExample("hello2");
            //将其放入父类数组
            Example[] es = {s1,s2, t1, t2};

            for (int i = 0; i < es.Length; i++)
            {
                ////由于放入的是父类数组，因此调用的也是父类方法
                ////所以需要将父类数组的成员转换为子类成员
                //if(es[i] is SubExample)
                //{
                //    ((SubExample)es[i]).WhoAmI();
                //}else if(es[i] is TrdExample)
                //{
                //    ((TrdExample)es[i]).WhoAmI();
                //}
                ////使用if来判断其类型并且转换，这样过于繁琐

                // 虚方法
                es[i].WhoAmI();
            }

            //02 - 抽象类
        }
    }
}
