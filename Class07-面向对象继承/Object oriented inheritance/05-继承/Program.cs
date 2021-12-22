using System;

namespace _05_继承
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.Name = "1";
            s.Age = 12;
            s.Gender = 'm';
            s.Id = 1;
            s.CH();
            s.Get(1);
        }
    }
}
