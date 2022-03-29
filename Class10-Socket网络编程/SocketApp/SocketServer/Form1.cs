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

namespace SocketServer
{
    public partial class Form1 : Form
    {
        Socket socketWatch;
        public Form1()
        {
            InitializeComponent();
            sendFileBtn.Visible = false;
        }

        private void startListenBtn_Click(object sender, EventArgs e)
        {
            try
            {
                socketWatch = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
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
                    socketList.Add(socketConnect.RemoteEndPoint.ToString(),socketConnect);//远程连接的Socket存入socketList中
                    listenList.Items.Add(socketConnect.RemoteEndPoint.ToString());//将Socket的ip地址加入下拉框
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

        //用于存储连接的客户端socket连接
        Dictionary<string,Socket> socketList = new Dictionary<string,Socket>();

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
                    ShowTextMsg(socketConnect.RemoteEndPoint + ":" + bufferCoding);
                }
                catch
                {

                }
            }
        }

        void ShowTextMsg(string str)
        {
            msgText.AppendText(str + "\r\n");
        }

        void ShowMsg(string str)
        {
            textLog.AppendText(str+ "\r\n");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void sendMsgBtn_Click(object sender, EventArgs e)
        {
            string msg = textInput.Text;
            byte[] buffer = System.Text.Encoding.UTF8.GetBytes(msg);
            //为字节头添加类型标记
            List<byte> list = new List<byte>();
            list.Add(0);
            list.AddRange(buffer);
            byte[] newBuffer = list.ToArray();
            //发送消息
            string ip = listenList.SelectedItem.ToString();
            socketList[ip].Send(newBuffer);
            //socketWatch.Send(buffer);
        }

        private void chooseFileBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = @"C:\";
            ofd.Title = "选择文件";
            ofd.Filter = "所有文件|*.*";
            ofd.ShowDialog();

            selectFilePath.Text = ofd.FileName;
            sendFileBtn.Visible = true;
        }

        private void sendFileBtn_Click(object sender, EventArgs e)
        {
            string path = selectFilePath.Text;
            using (FileStream fsReader = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                byte[] buffer = new byte[1024*1024*10];
                int r = fsReader.Read(buffer, 0, buffer.Length);

                //为字节头添加类型标记
                List<byte> list = new List<byte>();
                list.Add(1);
                list.AddRange(buffer);
                byte[] newBuffer = list.ToArray();

                socketList[listenList.SelectedItem.ToString()].Send(newBuffer,0,r+1,SocketFlags.None);

                sendFileBtn.Visible = false;
            }
        }

        private void shockBtn_Click(object sender, EventArgs e)
        {
            byte[] buffer = new byte[1];
            buffer[0] = 2;
            socketList[listenList.SelectedItem.ToString()].Send(buffer);
        }
    }
}
