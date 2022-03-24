using System;
using System.Net;
using System.Net.Sockets;

namespace SocketApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Socket connectWatch = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPAddress ip = IPAddress.Any;
            
        }
    }
}
