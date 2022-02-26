using System;

namespace _06_工厂设计模式
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose a type");
            String brand = Console.ReadLine();
            Laptop laptop = GetInfo(brand);
            laptop.LaptopInfomation();
        }

        /// <summary>
        /// 获得需要的子类
        /// </summary>
        /// <param name="brand">子类名称</param>
        /// <returns></returns>
        public static Laptop GetInfo(string brand)
        {
            Laptop lp = null;
            switch (brand)
            {
                case "Lenovo":lp = new Lenovo();break;
                case "Dell":lp = new DELL();break;
                case "ASUS":lp = new ASUS();break;
                default:lp = new Lenovo();break;
            }
            return lp;
        }
    }
}
