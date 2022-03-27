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

        private void startListenBtn_Click(object sender, EventArgs e)
        {
            Socket socketWatch = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPAddress ip = IPAddress.Any;//IPAddress.Parse(ipInput.Text);

            IPEndPoint point = new IPEndPoint(ip,Convert.ToInt32(portInput.Text));

            //监听
            socketWatch.Bind(point);
            ShowMsg("正在监听");
            socketWatch.Listen(100);

            //新建线程用于Socket连接
            Thread th = new Thread(ListenConnect);
            th.IsBackground = true;
            th.Start(socketWatch);

        }

        void ListenConnect(object o)
        {
            Socket socketWatch = o as Socket;
            //等待客户端连接 创建一个负责通信的Socket
            while (true)
            {
            Socket socketConnect = socketWatch.Accept();
            ShowMsg(socketConnect.RemoteEndPoint.ToString() + ":连接成功");
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
