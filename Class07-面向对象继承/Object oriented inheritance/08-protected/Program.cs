using System;

namespace _08_protected
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    internal class New
    {
        protected string _name;
        private string _description;
        
        public void Printf()
        {
            _name = "hi";//当前类可访问
        }
    }
}
