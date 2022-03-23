using System;
using System.Security.Cryptography;
using System.Text;

namespace _13_MD5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = GetMD5("123粉啊啊啊");
            Console.WriteLine(str);
        }

        public static string GetMD5(string str)
        {
            //创建MD5对象
            MD5 md5 = MD5.Create();
            //加密
            
            //先将string转为字节数组
            byte[] buffer = Encoding.Default.GetBytes(str);
            //返回已加密的字节数组
            byte[] result = md5.ComputeHash(buffer);
            //再将字节数组转为字符串
            string reback = "";
            for (int i = 0; i < result.Length; i++)
            {
                reback += result[i].ToString("x");
            }
            return reback;
        }
    }
}
