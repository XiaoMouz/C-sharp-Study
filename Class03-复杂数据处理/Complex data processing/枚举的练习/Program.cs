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
        Online,
        Offline,
        Wrong
    }
    class Program
    {
        static void Main(string[] args)
        {
            Sesons s = Sesons.夏;
            Internet now = Internet.Online;
        }
    }
}
