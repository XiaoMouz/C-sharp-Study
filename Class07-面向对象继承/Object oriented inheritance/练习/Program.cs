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
            //string email = "gxiaomouz@gmail.com";
            //string username = email.Substring(0, email.IndexOf('@'));
            //string domain = email.Substring((email.IndexOf('@')) + 1);
            //Console.WriteLine("username={0},domain={1}", username, domain);
            #endregion

            #region ReadFile
            //FileIO.ReadFile("");
            #endregion

            #region 找到e的位置
            //string contact = "wiodjioaweiejejeiowajowa";
            //int index = 0;
            //int count = 0;
            //while (true)
            //{
            //    index = contact.IndexOf('e', index + 1);
            //    if(index == -1)
            //    {
            //        break;
            //    }
            //    else
            //    {
            //        count++;
            //        Console.WriteLine("第{0}次出现e的位置是在{1}", count, index);
            //    }
            //}
            #endregion

            #region 屏蔽关键字
            //string str = "hi,this thing really is fucking shit";
            //if (str.Contains("fucking")||str.Contains("shit"))
            //{
            //    str = str.Replace("fucking", "**");
            //    str = str.Replace("shit", "**");
            //}
            //Console.WriteLine(str);
            #endregion

            #region 将 a,b,c,d 变成 a|b|c|d
            //string[] names = { "a", "b", "c", "d" };
            //string str = string.Join('|', names);
            //string[] strNew = str.Split(new char[] {'|'},StringSplitOptions.RemoveEmptyEntries);

            //Console.WriteLine(str);
            #endregion


        }
    }
}
