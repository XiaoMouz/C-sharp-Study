using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginApp
{
    public partial class Form1 : Form
    {
        string username = "admin";
        string password = "admin";

        public Form1()
        {
            InitializeComponent();
            AutoSwitchLineBtn.Visible = false;
            SaveFileButton.Visible = false;
            TextInput.Visible = false;
            label1.Visible = false;
        }

        private void Login_Click(object sender, EventArgs e)
        {
            if(UsernameInput.Text == username && PasswordInput.Text == password)
            {
                MessageBox.Show("登录成功，欢迎您，" + UsernameInput);
                usernameLabel.Visible = false;
                passwordLabel.Visible = false;
                UsernameInput.Visible = false;
                PasswordInput.Visible = false;
                Login.Visible = false;
                Reset.Visible = false;
                AutoSwitchLineBtn.Visible = true;
                SaveFileButton.Visible = true;
                TextInput.Visible = true;
                label1.Visible = true;
                label1.Text = "欢迎，" + UsernameInput.Text;
            }
            else
            {
                MessageBox.Show("登录失败");
                PasswordInput.Clear();
                PasswordInput.Focus();
            }
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            UsernameInput.Clear();
            PasswordInput.Clear();
            UsernameInput.Focus();
        }

        private void AutoSwitchLineBtn_Click(object sender, EventArgs e)
        {
            if (TextInput.WordWrap == true)
            {
                TextInput.WordWrap = false;
                AutoSwitchLineBtn.Text = "自动换行";
            }else if(TextInput.WordWrap == false)
            {
                TextInput.WordWrap = true;
                AutoSwitchLineBtn.Text = "取消自动换行";
            }
        }

        private void SaveFileButton_Click(object sender, EventArgs e)
        {
            using(FileStream fsWrite = new FileStream(@"%appdata%/newFile.txt", FileMode.OpenOrCreate, FileAccess.Write))
            {
                string str = TextInput.Text.Trim();
                byte[] buffer = System.Text.Encoding.Default.GetBytes(str);
                fsWrite.Write(buffer, 0, buffer.Length);
            }
            MessageBox.Show("保存了");
        }
    }
}
