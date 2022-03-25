using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhoCareProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// 当鼠标放置在上时进行时修改按钮坐标
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_MouseEnter(object sender, EventArgs e)
        {
            //按钮活动范围最大只能是窗体宽度(长度)-按钮宽度(长度)
            int x = this.ClientSize.Width - button2.Width;
            int y = this.ClientSize.Height - button2.Height;
            //给按钮一个随机的坐标
            Random random = new Random();
            button2.Location = new Point(random.Next(0,x+1),random.Next(0,y+1));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("2333");
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("真丢脸啊");
            this.Close();
        }
    }
}
     