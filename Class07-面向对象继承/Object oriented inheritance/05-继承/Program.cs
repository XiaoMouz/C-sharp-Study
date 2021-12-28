using System;

namespace _05_继承
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student("1",12,'男',01);
            //s.Name = "1";
            //s.Age = 12;
            //s.Gender = '男';
            //s.Id = 1;
            s.CH();
            s.Get();

            Teacher t = new Teacher("2", 23, '男', 4100);
            t.Sent();
        }
    }
}
