using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 超市收银系统
{
    internal class Laptop:ProductFather
    {
        public Laptop(string id, double price, int count) : base(id, price, count)
        {

        }
    }
}
