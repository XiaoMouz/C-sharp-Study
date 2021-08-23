using System;

namespace _02_枚举
{
    //你可以在此处公布枚举，此时此命名空间下所有的类均可使用此枚举
    
    class Program
    {
        //你也可以在此处公布枚举，此时仅有此类内的方法才能使用此枚举
        /* [public] enum 枚举名
             * {
             *   值1，
             *   值2，
             *   值3
             *   ....
             * }
             * "public"为访问修饰符
             * "enum"声明枚举关键字
             * 枚举名需要符合Pascal命名规范
             */
        //此时我选择在这里公布枚举，因为我不需要其他类调用
        public enum Gender
        {
            男,
            女
        }
        public enum qqstate
        {
            Online,
            Offline,
            Busy,
            Leave,//=6,
            QMe
        }
        static void Main(string[] args)
        {
            //变量类型 变量名=值；
            Gender gender = Gender.男;

            //枚举、int、string之间的转换
            #region 枚举输出int
            //qqstate state = qqstate.Online;
            //int n = (int)state;
            //Console.WriteLine(n);
            //Console.WriteLine((int)qqstate.Offline);
            //Console.WriteLine((int)qqstate.Busy);
            //Console.WriteLine((int)qqstate.Leave);
            //Console.WriteLine((int)qqstate.QMe);
            #endregion

            #region int输出枚举
            //int n1 = 4;//=8时不抛异常，直接输出了8
            //qqstate state = (qqstate)n1;
            //Console.WriteLine(state);
            #endregion


        }
    }
}
