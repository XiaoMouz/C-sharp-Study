using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace SocketClient
{
    public partial class Form1 : Form
    {
        Socket socketSend;

        public Form1()
        {
            InitializeComponent();
        }

        private void startLinkBtn_Click(object sender, EventArgs e)
        {
            try
            {
                socketSend = new Socket(AddressFamily.InterNetwork,SocketType.Stream, ProtocolType.Tcp);
                IPAddress ip = IPAddress.Parse(ipInput.Text);
                IPEndPoint point = new IPEndPoint(ip, Convert.ToInt32(portInput.Text));
                //获得需要连接的远程应用服务器IP地址与端口号
                socketSend.Connect(point);
                ShowMsg("连接成功");

                Thread th = new Thread(Recive);
                th.IsBackground = true;
                th.Start(socketSend);
            }
            catch
            {}
        }

        void ListenConnect(object o)
        {
            Socket socketWatch = o as Socket;
            //等待客户端连接 创建一个负责通信的Socket
            while (true)
            {
                try
                {
                    Socket socketConnect = socketWatch.Accept();
                    ShowMsg(socketConnect.RemoteEndPoint.ToString() + ":连接成功");

                    //创建线程用于接收客户端消息
                    Thread th = new Thread(Recive);
                    th.IsBackground = true;
                    th.Start(socketConnect);
                }
                catch
                {
                }
            }
        }

        
        void Recive(object o)
        {

            Socket socketConnect = o as Socket;
            //接收消息
            while (true)
            {
                try
                {
                    byte[] buffer = new byte[1024 * 1024 * 10];
                    int getByte = socketConnect.Receive(buffer);//将接收数据存入buffer，getByte是实际收到的字节数
                    if (getByte == 0)
                    {
                        break;
                    }

                    if (buffer[0] == 0)
                    {
                        string bufferCoding = Encoding.UTF8.GetString(buffer, 1, getByte - 1);//收到的字符串
                        ShowMsg(socketConnect.RemoteEndPoint + ":" + bufferCoding);
                    }else if(buffer[0] == 1)
                    {
                        SaveFileDialog saveFileDialog = new SaveFileDialog();
                        saveFileDialog.InitialDirectory = @"C:\";
                        saveFileDialog.Title = "选择文件保存位置";
                        saveFileDialog.Filter = "所有文件|*.*";
                        saveFileDialog.ShowDialog(this);
                        string path = saveFileDialog.FileName;
                        using (FileStream fsWrite = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write))
                        {
                            fsWrite.Write(buffer, 1, getByte-1);
                        }
                        MessageBox.Show("已保存");
                    }else if(buffer[0] == 2)
                    {
                        shake();
                    }
                }
                catch
                {

                }
            }
        }

        void shake()
        {
            for (int i = 0; i < 200; i++)
            {
                Point point = this.Location;

                this.Location = new Point(point.X + 3, point.Y + 3);
                this.Location = new Point(point.X - 3, point.Y - 3);
            }
        }

        void ShowMsg(string str)
        {
            textLog.AppendText(str+ "\r\n");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        /// <summary>
        /// 客户端发送消息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sendMsgBtn_Click(object sender, EventArgs e)
        {
            string str = textInput.Text;
            byte[] buffer = System.Text.Encoding.UTF8.GetBytes(str);
            socketSend.Send(buffer);
            textInput.Clear();
        }

        private void sendFileBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("..不是给你用的");
        }

        private void shockBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("..不是给你用的");
        }

        private void chooseFileBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("..不是给你用的");
        }
    }
}
