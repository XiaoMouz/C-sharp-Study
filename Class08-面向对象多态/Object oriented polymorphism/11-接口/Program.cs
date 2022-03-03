using System;

namespace _11_接口
{
    //本次创建的类依旧会挤在一个文件内，这并不是常规的写法，只是为了方便
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }

    public class Person
    {
        public void SayHello()
        {
            Console.WriteLine("Hi");
        }
    }

    public class NBAPlayer
    {
        public void PlayBasketball(string height)
        {
            Console.WriteLine("Bong");
        }
    }

    public class Student:Person,IPlayBasketballable
    {
        public void Study()
        {
            Console.WriteLine("Study");
        }

        public void PlayBasketball(string height)
        {
            Console.WriteLine("too");
        }
    }

    public class Teacher : Person, IPlayBasketballable 
    { 
        public void PlayBasketball(string height)
        {
            Console.WriteLine(height);
        }

        public void IPlayBasketballable.PlayBasketball(string height)
        {
            Console.WriteLine("too");
        }
    }

    public interface IPlayBasketballable
    {
        void PlayBasketball(string height);
    }
}
