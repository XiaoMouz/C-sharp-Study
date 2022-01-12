using System;
using System.Collections;

namespace _11_HashTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable a = new Hashtable();
            a.Add("a", 1);
            a.Remove("a");
            a.Clear();
        }
    }
}
