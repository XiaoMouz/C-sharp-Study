namespace LoginApp
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.TextInput = new System.Windows.Forms.TextBox();
            this.AutoSwitchLineBtn = new System.Windows.Forms.Button();
            this.SaveFileButton = new System.Windows.Forms.Button();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.UsernameInput = new System.Windows.Forms.TextBox();
            this.PasswordInput = new System.Windows.Forms.TextBox();
            this.Login = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TextInput
            // 
            this.TextInput.Location = new System.Drawing.Point(12, 32);
            this.TextInput.Multiline = true;
            this.TextInput.Name = "TextInput";
            this.TextInput.Size = new System.Drawing.Size(776, 406);
            this.TextInput.TabIndex = 0;
            this.TextInput.WordWrap = false;
            // 
            // AutoSwitchLineBtn
            // 
            this.AutoSwitchLineBtn.Location = new System.Drawing.Point(13, 3);
            this.AutoSwitchLineBtn.Name = "AutoSwitchLineBtn";
            this.AutoSwitchLineBtn.Size = new System.Drawing.Size(75, 23);
            this.AutoSwitchLineBtn.TabIndex = 1;
            this.AutoSwitchLineBtn.Text = "自动换行";
            this.AutoSwitchLineBtn.UseVisualStyleBackColor = true;
            this.AutoSwitchLineBtn.Click += new System.EventHandler(this.AutoSwitchLineBtn_Click);
            // 
            // SaveFileButton
            // 
            this.SaveFileButton.Location = new System.Drawing.Point(95, 3);
            this.SaveFileButton.Name = "SaveFileButton";
            this.SaveFileButton.Size = new System.Drawing.Size(75, 23);
            this.SaveFileButton.TabIndex = 2;
            this.SaveFileButton.Text = "保存";
            this.SaveFileButton.UseVisualStyleBackColor = true;
            this.SaveFileButton.Click += new System.EventHandler(this.SaveFileButton_Click);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(128, 141);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(47, 12);
            this.usernameLabel.TabIndex = 3;
            this.usernameLabel.Text = "用户名:";
            this.usernameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(128, 171);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(47, 12);
            this.passwordLabel.TabIndex = 4;
            this.passwordLabel.Text = "密  码:";
            // 
            // UsernameInput
            // 
            this.UsernameInput.Location = new System.Drawing.Point(182, 138);
            this.UsernameInput.Name = "UsernameInput";
            this.UsernameInput.Size = new System.Drawing.Size(100, 21);
            this.UsernameInput.TabIndex = 5;
            // 
            // PasswordInput
            // 
            this.PasswordInput.Location = new System.Drawing.Point(182, 168);
            this.PasswordInput.Name = "PasswordInput";
            this.PasswordInput.PasswordChar = '*';
            this.PasswordInput.Size = new System.Drawing.Size(100, 21);
            this.PasswordInput.TabIndex = 6;
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(318, 138);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(75, 23);
            this.Login.TabIndex = 7;
            this.Login.Text = "登录";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(318, 165);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(75, 23);
            this.Reset.TabIndex = 8;
            this.Reset.Text = "重置";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(194, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "Hello";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.PasswordInput);
            this.Controls.Add(this.UsernameInput);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.SaveFileButton);
            this.Controls.Add(this.AutoSwitchLineBtn);
            this.Controls.Add(this.TextInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextInput;
        private System.Windows.Forms.Button AutoSwitchLineBtn;
        private System.Windows.Forms.Button SaveFileButton;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox UsernameInput;
        private System.Windows.Forms.TextBox PasswordInput;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Label label1;
    }
}

