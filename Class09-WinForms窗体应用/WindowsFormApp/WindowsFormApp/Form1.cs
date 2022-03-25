using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        /// <summary>
        /// 在加载窗体时将窗体转移到指定静态类的静态字段中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            FormManager._form1 = this;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            MessageBox.Show("123");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //在内存中创建窗体对象
            Form2 form = new Form2();
            //显示窗体
            form.Show();
        }
    }
}
