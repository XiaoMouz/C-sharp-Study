using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 超市收银系统
{
    internal class Warehouse
    {
        //存储货物
        //使用ArrayList来存货物
        List<List<ProductFather>> list = new List<List<ProductFather>>();
        //List<ProductFather> productList = new List<ProductFather>();
        //List<Phone> listPhone = new List<Phone>();
        //List<Milk> listMike = new List<Milk>();
        //List<Laptop> listLaptop = new List<Laptop>();
        //List<Banana> listBanana = new List<Banana>();

        public Warehouse()
        {
            list.Add(new List<ProductFather>());//phone
            list.Add(new List<ProductFather>());//laptop
            list.Add(new List<ProductFather>());//milk
            list.Add(new List<ProductFather>());//banana
        }

        public static void AddProduct(ProductFather in,)
        {

        }
    }
}
