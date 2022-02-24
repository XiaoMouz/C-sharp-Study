using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_多态
{
    internal class Example
    {
        private string _name;
        public string name
        {
            get { return _name; }
            set { _name = value; }
        }

        public Example(string name)
        {
            this.name = name;
        }

        public virtual void WhoAmI()
        {
            Console.WriteLine("A Example ",this.name);
        }
    }
}
