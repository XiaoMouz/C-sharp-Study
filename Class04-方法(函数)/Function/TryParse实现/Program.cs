using System;

namespace TryParse实现
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            bool b = int.TryParse("123", out num);
            if(b)
            {
                Console.WriteLine("success,num="+num);
            }
            else
            {
                Console.WriteLine("fail");
            }
        }
        public static bool MTP(string s,out int result)
        {
            result = 0;
            try
            {
                result = Convert.ToInt32(s);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
