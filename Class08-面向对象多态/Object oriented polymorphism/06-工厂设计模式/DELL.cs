using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_工厂设计模式
{
    internal class DELL:Laptop
    {
        public override void LaptopInfomation()
        {
            Console.WriteLine("This laptop build by DELL");
        }
    }
}
