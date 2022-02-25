using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_多态.抽象类
{
    internal class Dog:Animal
    {
        public override string Name { 
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); 
        }

        public override void Brak()
        {
            Console.WriteLine("Wan!");
        }
    }
}
