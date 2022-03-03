using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 超市收银系统
{
    internal class Banana:ProductFather
    {
        public Banana(string id, double price, int count) : base(id, price, count)
        {

        }
    }
}
