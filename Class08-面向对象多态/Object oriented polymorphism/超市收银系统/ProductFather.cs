using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 超市收银系统
{
    internal class ProductFather
    {
        public double Price
        {
            get;
            set;
        }

        public int Count
        {
            get;
            set;
        }

        public string ID
        {
            get;
            set;
        }

        public ProductFather(string id,double price,int count)
        {
            this.ID = ID;
            this.Price = price;
            this.Count = count;
        }

    }
}
