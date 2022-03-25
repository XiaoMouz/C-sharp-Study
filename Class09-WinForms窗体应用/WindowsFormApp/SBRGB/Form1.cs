using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SBRGB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = label1.Text.Substring(1) + label1.Text.Substring(0, 1);
        }
        
        private void timer2_Tick(object sender, EventArgs e)
        {
            //每隔一秒将当前时间赋值给label
            lblTime.Text = DateTime.Now.ToString();

            //在指定时间播放音乐
            if (DateTime.Now.Hour == 20 && DateTime.Now.Minute == 33)
            {
                MessageBox.Show("SHit");
                SoundPlayer sp = new SoundPlayer();
                sp.SoundLocation = @"D:\64\My Soul, Your Beats!.mp3";
                sp.Play();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString();
        }
    }
}
