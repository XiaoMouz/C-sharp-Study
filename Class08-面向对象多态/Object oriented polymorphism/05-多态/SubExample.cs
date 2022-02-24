using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_多态
{
    internal class SubExample:Example
    {
        public SubExample(string name) : base(name)
        {

        }

        public override void WhoAmI()
        {
            Console.WriteLine("This is a SubExample {0}",this.name);
        }
    }
}
