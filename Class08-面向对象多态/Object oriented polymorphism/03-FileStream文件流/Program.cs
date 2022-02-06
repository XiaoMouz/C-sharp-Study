using System;
using System.IO;
using System.Text;

namespace _03_FileStream文件流
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //设置访问路径，选择打开方式，需要进行的数据操作
            FileStream FSRead = new FileStream(@"D:\64\FileStreamExample_01.txt",FileMode.OpenOrCreate,FileAccess.ReadWrite);

            //设定读取缓存区域
            //设定缓存字节数组空间为5M
            byte[] FSRead_Cache = new byte[1024*1024*5];
            //设置了缓存用的字节数组、字节读取的起始偏移(通常为0)与最大缓存区域，并且会返回在本次读取中实际占用的有效字节数
            int r = FSRead.Read(FSRead_Cache,0,FSRead_Cache.Length);
            //将字节数组中的内容解码为字符串
            string s = Encoding.UTF8.GetString(FSRead_Cache,0,r);
            
            //关闭并释放文件流
            FSRead.Close();//关闭文件流
            FSRead.Dispose();//释放资源
            
            //打印
            Console.WriteLine(s);

            //通过FileStream写入文件，并且通过using自动关闭
            using(FileStream FSWrite = new FileStream(@"D:\64\FileStreamExample_01.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                //准备写入的内容
                string need_write = "12138";
                //设定缓存字节数组空间为5M
                byte[] FSWrite_Cache = Encoding.UTF8.GetBytes(need_write);
                FSWrite.Write(FSWrite_Cache,0,FSWrite_Cache.Length);
            }
            Console.WriteLine("Write Success");
        }
    }
}
