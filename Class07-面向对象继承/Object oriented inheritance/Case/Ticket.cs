using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case
{
    public class Ticket
    {
        public Ticket(double distance)
        {
            if (distance < 0)
            {
                _distance = 0;
            }
            else
            {
                _distance = distance;
            }

        }

        #region 字段、属性
        //字段
        private double _distance;
        //属性
        public double Distance
        {
            get { return _distance; }
        }

        //字段
        private double _price;
        //属性
        public double Price
        {
            get
            {
                if (_distance > 0 && _distance <= 100)
                {
                    return _distance * 1.0;
                }
                else if (_distance >= 101 && _distance <= 200)
                {
                    return _distance * 0.95;
                }
                else if (_distance >= 301 && _distance <= 300)
                {
                    return _distance * 0.9;
                }
                else
                {
                    return _distance * 0.8;
                }
            }
        }
        #endregion

        public void ShowTicket()
        {
            Console.WriteLine("the {0}km,used {1}$", Distance, Price);
        }
    }
}
