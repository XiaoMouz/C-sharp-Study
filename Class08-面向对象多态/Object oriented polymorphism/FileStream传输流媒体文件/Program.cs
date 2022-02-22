using System;
using System.IO;
using System.Text;

namespace FileStream传输流媒体文件
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string source = @"D:\64\My Soul, Your Beats!.mp3";
            string target = @"D:\64\Target\test.mp3";
            string successMsg = "Success";
            string failMsg = "Failed";
            Console.WriteLine("{0}",CopyMedia(source,target)==0?successMsg:failMsg);
        }

        public static int CopyMedia(string source, string target)
        {
            //创建读取流
            using(FileStream fileRead = new FileStream(source, FileMode.Open, FileAccess.Read))
            {
                //创建写入流
                using (FileStream fileWrite = new FileStream(target, FileMode.OpenOrCreate, FileAccess.Write))
                {
                    try
                    {
                        //缓存字节组
                        byte[] buffer = new byte[1024 * 1024 * 1];

                        //读取&写入
                        while (true)
                        {
                            int getLength = fileRead.Read(buffer, 0, buffer.Length);
                            if (getLength == 0)
                            {
                                return 0;
                                
                            }
                            fileWrite.Write(buffer, 0, getLength);
                        }
                    }
                    catch
                    {
                        return 1;
                    }
                    
                }
            }
        }
    }
}
