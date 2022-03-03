using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace _07_序列化与反序列化
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //序列化案例
            Person aPerson = new Person();
            aPerson.name = "zs";
            aPerson.age = 18;
            aPerson.gender = "男";

            //准备将该对象序列化并传输
            //由于没有可供接收的另一端，因此使用FileStream来直接储存到文件中
            using (FileStream fsW = new FileStream(@"D:\64\32.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                //开始序列化对象
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fsW, aPerson);
            }

            //反序列化对象
            Person p;
            using (FileStream fsR = new FileStream(@"D:\64\32.txt", FileMode.OpenOrCreate, FileAccess.Read))
            {
                BinaryFormatter b = new BinaryFormatter();
                p = (Person)b.Deserialize(fsR);
            }
            Console.WriteLine(p.name);
            Console.WriteLine(p.age);
            Console.WriteLine(p.gender);
        }
    }
}
