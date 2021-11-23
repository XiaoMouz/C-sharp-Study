using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_静态函数和函数
{
    internal static class Profile
    {
        //静态类中只允许出现静态成员，不允许存在实例成员

        //public int age;无法使用，必须带上static
        public static int age;
        //string name; 也无法使用
        static string name;
    }
}
