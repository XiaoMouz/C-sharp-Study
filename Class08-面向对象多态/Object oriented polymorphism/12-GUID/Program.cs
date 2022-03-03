using System;

namespace _12_GUID
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Guid aGuid = Guid.NewGuid();
            Console.WriteLine(aGuid.ToString());
        }
    }
}
