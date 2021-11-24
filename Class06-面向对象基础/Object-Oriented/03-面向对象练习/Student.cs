using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_面向对象练习
{
    internal class Student
    {
        //构造函数


        #region 属性与字段
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private int _age;
        public int Age
        {
            get { return _age; }
            set { 
                if(value < 0|| value>100)
                {
                    value = 0;
                }
                _age = value; }
        }

        private char _gender;
        public char Gender
        {
            get { 
                if(_gender !='男'&&_gender != '女')
                {
                    return _gender = '男';
                }
                return _gender; }
            set { _gender = value; }
        }

        private int _math;
        public int Math
        {
            get { return _math; }
            set { _math = value; }
        }

        private int _chinese;
        public int Chinese
        {
            get { return _chinese; }
            set { _chinese = value; }
        }

        private int _english;
        public int English
        {
            get { return _english; }
            set { _english = value; }
        }
        #endregion
        
        public void SayHello()
        {
            Console.WriteLine("{0},you are {1},your {2} old",this.Name,this.Gender, this.Age);

        }

        public void Score()
        {
            Console.WriteLine("your math score is {0},chinese score = {1},english score = {2}", this.Math, this.Chinese, this.English);
        }
    }
}
