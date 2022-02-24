using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_多态.抽象类
{
    internal class Cat:Animal
    {
        public override void Brak()
        {
            Console.WriteLine("miao~");
        }
    }
}
