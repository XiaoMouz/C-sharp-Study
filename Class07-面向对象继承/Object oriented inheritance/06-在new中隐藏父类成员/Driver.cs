using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_继承
{
    internal class Driver:Person //继承Person
    {
        public Driver(string name,int age,char gender,int drivertime) : base(name, age, gender)
        {
            this.DriverTime = drivertime;
        }

        private int _driverTime;
        public int DriverTime
        {
            get { return _driverTime; }
            set { _driverTime = value; }
        }

        public void GetDT()
        {
            Console.WriteLine(DriverTime);
        }
    }
}
