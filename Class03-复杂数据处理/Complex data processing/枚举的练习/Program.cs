using System;

namespace 枚举的练习
{
    public enum Sesons
    {
        春,
        夏,
        秋,
        冬
    }
    public enum Internet
    {
        Online=1,
        Offline,
        Busy
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Sesons s = Sesons.夏;
            //Internet now = Internet.Online;


            //状态显示
            Console.WriteLine("请选择您的状态\n1-在线、2-离线、3-忙碌\n回复数字即可");
            string choose = Console.ReadLine();
            switch (choose)
            {
                case "1": Internet state_1 = (Internet)Enum.Parse(typeof(Internet), choose);
                    Console.WriteLine("您选择的状态是{0}", state_1);
                    break;
                case "2": Internet state_2=(Internet)Enum.Parse(typeof(Internet),choose);
                    Console.WriteLine("您选择的状态是{0}", state_2);
                    break;
                case "3":Internet state_3 = (Internet)Enum.Parse(typeof(Internet), choose);
                    Console.WriteLine("您选择的状态是{0}", state_3);
                    break;

            }
        }
    }
}
