using System;

namespace Day_01
{
    class Program
    {
        static void Main(string[] args)
        {
            /**step1-基础训练region、各类变量类型、cw和cr
            #region 定义函数
            int age = 114514;
            double xp = 1919.810;
            char you = '你'; 字符
            string name = "傻逼"; 字符串
            decimal money = 100m; 指定金钱类
            #endregion
            Console.WriteLine(you+"是"+name+"你今年"+age+"岁，现在有"+xp+"经验以及"+money+"元");
            Console.ReadKey();
            **/

            //step2-转义符与@
            Console.WriteLine("你\b好啊 \n \"傻\\逼\""); //\n为换行，windows如要识别需使用\r\n（在输出到win文件内时）  \\为\
                                                      //\"为"（双引号） 
                                                      //\b为退格（backspace键效果）但是当在字符串俩端时无效果

            string name1 = "莉莉子";
            string name2 = "奈奈子";
            string name3 = "拱坝老哥";
            string name4 = "抗压吧蛆宝宝";
            Console.WriteLine("{0}\t\t{1},", name1, name2);  //\t为tab键等距空格
            Console.WriteLine("{0}\t{1}", name3, name4);
            /* @用作让字符串内转义符的转义作用失效让\就是\ 或者 按照内容直接输出 */
            char t = '\\'; //转义符为单字符
            Console.WriteLine(@"i'm a new guys\n,
                let me say say u"); //注意输出的空格
            Console.ReadKey();

        }
    }
}
