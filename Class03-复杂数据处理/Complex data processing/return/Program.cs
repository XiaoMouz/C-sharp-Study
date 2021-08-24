using System;

namespace Return
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Hello World");
                //break;
                //continue;
                return;
            }
            Console.WriteLine("Hello .Net");
            Console.ReadKey();
        }
    }
}
