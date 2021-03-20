using System;

namespace _05_加减乘除
{
    class Program
    {
        static void Main(string[] args)
        {
            //语文90 数学80 英语76 求总成绩，三科平均成绩
            int chinese = 90;
            int math = 80;
            int english = 76;
            Console.WriteLine("总成绩{0},三科平均{1}", chinese + math + english, (chinese + math + english) / 3); //小括号可以无限使用但是要成对，运算顺序和正常顺序一致
            
            //求圆的面积与周长 已知r=4 π取3.14
            int r = 4;
            double area = 3.14 * r * r; //注意，等号俩边的数据类型(int/double....)必须一样
            double perimeter = 2 * 3.14 * r;
            Console.WriteLine("the area {0},perimeter {1}", area, perimeter);

            //T-shirt=35 trousers=120 小明buy tr*3 ts*2,how much，打8.8折后？
            int tShirt = 35;
            int trousers = 120;
            int payment = tShirt * 3 + trousers * 2;
            double much = payment * 0.88;//int>double
            Console.WriteLine("小明应付{0}元，打8.8折还是得付{1}元", payment, much);
            //折后取整-也是double>int
            int num = (int)much;//double>int
            Console.WriteLine(num);
            Console.ReadKey();



            //int double计算互换以及取小数点后n位（完美诠释1个操作数升级，整表达式升天）
            int a = 10;
            int b = 3;
            double c = a / b;
            Console.WriteLine("输出{0}，只有整数", c);
            double d = a * 1.0 / b;
            Console.WriteLine("成了{0}，并且可以取{0:0.00}，也就是小数点后2位", d, d);
            Console.ReadKey();

            //++和--的含义以及用法
            int mm = 1;
            int rev = 10 + mm++;   /*等于
                                    * rev + mm
                                    * mm++
                                    * 此时rev=11，mm=2
                                    */
            int rev_2 = 10 + ++mm; /*等于
                                    * mm++
                                    * rev + mm
                                    * 此时rev=12，mm=2
                                    */
            Console.WriteLine("a={0},b={1},c={2}", mm, rev, rev_2);
        }
    }
}
