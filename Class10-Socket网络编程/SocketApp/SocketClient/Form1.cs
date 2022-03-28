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

namespace SocketServer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void startLinkBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Socket socketSend = new Socket(AddressFamily.InterNetwork,SocketType.Stream, ProtocolType.Tcp);
                IPAddress ip = IPAddress.Parse(ipInput.Text);
                IPEndPoint point = new IPEndPoint(ip, Convert.ToInt32(portInput.Text));
                //获得需要连接的远程应用服务器IP地址与端口号
                socketSend.Connect(point);
                ShowMsg("连接成功");
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
            //接收客户端消息
            while (true)
            {
                try
                {
                    byte[] buffer = new byte[1024 * 1024 * 2];
                    int getByte = socketConnect.Receive(buffer);//将接收数据存入buffer，getByte是实际收到的字节数
                    string bufferCoding = Encoding.UTF8.GetString(buffer, 0, getByte);//收到的字符串
                    if (getByte == 0)
                    {
                        break;
                    }
                    ShowMsg(socketConnect.RemoteEndPoint + ":" + bufferCoding);
                }
                catch
                {

                }
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
    }
}
