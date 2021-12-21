using System;
using System.IO;

namespace 练习
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 将字符串翻转
            //string ez = "abcdefg";
            //char[] vs= ez.ToCharArray();
            //char temp;
            //for (int i = 0; i < vs.Length/2; i++)
            //{
            //    temp = vs[vs.Length - i - 1];
            //    vs[vs.Length-i -1 ] = vs[i];
            //    vs[i] = temp;
            //}
            //ez = new string(vs);
            //Console.WriteLine(ez);
            #endregion

            #region "hello c sharp" > "sharp c hello"
            //string str = "hello c sharp";
            //string[] newStr = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            //for(int i = 0; i < newStr.Length / 2; i++)
            //{
            //    string temp = newStr[i];
            //    newStr[i] = newStr[newStr.Length-i-1];
            //    newStr[newStr.Length - i - 1] = temp;
            //}
            //str = String.Join(" ",newStr);
            //Console.WriteLine(str);
            #endregion

            #region 从Email中提取出用户名与域名
            string email = "gxiaomouz@gmail.com";
            string username = email.Substring(0, email.IndexOf('@'));
            string domain = email.Substring((email.IndexOf('@')) + 1);
            Console.WriteLine("username={0},domain={1}", username, domain);
            #endregion

            #region 

            #endregion
        }
    }
}
