using System;

namespace _06_关系运算符
{
    class Program
    {
        static void Main(string[] args)
        {
            /* bool name = xx > / < / == / >= / <= yy 关系运算符与布尔（bool）
             * 逻辑运算符：&&-逻辑与：2边为true输出true否则false ||-逻辑或：只要有一边为true即为true 或 !-逻辑非：只连一边，如果一边为ture则输出false，false则输出true
             *    注意：优先级如下：逻辑与>逻辑或
             * name = xx >/.../<= yy 输出为true/false使用bool来赋值
             * 复合赋值运算符：一元运算符的进阶
             * += number+=20 = number=number+20;
             * -= 同理得出如下
             * *=
             * /=
             * %=
             * Q:用户输入2科成绩，输出俩个结果：1、俩者＞90 = true 2、俩者有一个 > 90 = true
             */
            Console.WriteLine("输入第一科成绩");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("输入第二科成绩");
            int second = Convert.ToInt32(Console.ReadLine());

            //bool input_1 = first > 90;
            //bool input_2 = second > 90;
            //bool allow_All = input_1 && input_2;
            //bool only = input_1 || input_2;

            bool allow_All = first > 90 && second > 90;
            Console.WriteLine("90：{0}", allow_All);

            bool allow_only = first > 90 || second > 90;
            Console.WriteLine("90 only：{0}", allow_only);

            Console.ReadKey();
        }
    }
}
