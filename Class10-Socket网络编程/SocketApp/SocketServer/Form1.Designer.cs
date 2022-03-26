namespace SocketServer
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
            this.ipInput = new System.Windows.Forms.TextBox();
            this.portInput = new System.Windows.Forms.TextBox();
            this.startListenBtn = new System.Windows.Forms.Button();
            this.listenList = new System.Windows.Forms.ComboBox();
            this.textLog = new System.Windows.Forms.TextBox();
            this.msgText = new System.Windows.Forms.TextBox();
            this.textInput = new System.Windows.Forms.TextBox();
            this.chooseFileBtn = new System.Windows.Forms.Button();
            this.sendFileBtn = new System.Windows.Forms.Button();
            this.sendMsgBtn = new System.Windows.Forms.Button();
            this.shockBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ipInput
            // 
            this.ipInput.Location = new System.Drawing.Point(62, 65);
            this.ipInput.Name = "ipInput";
            this.ipInput.Size = new System.Drawing.Size(100, 21);
            this.ipInput.TabIndex = 0;
            // 
            // portInput
            // 
            this.portInput.Location = new System.Drawing.Point(168, 65);
            this.portInput.Name = "portInput";
            this.portInput.Size = new System.Drawing.Size(54, 21);
            this.portInput.TabIndex = 1;
            // 
            // startListenBtn
            // 
            this.startListenBtn.Location = new System.Drawing.Point(246, 63);
            this.startListenBtn.Name = "startListenBtn";
            this.startListenBtn.Size = new System.Drawing.Size(75, 23);
            this.startListenBtn.TabIndex = 2;
            this.startListenBtn.Text = "开始监听";
            this.startListenBtn.UseVisualStyleBackColor = true;
            this.startListenBtn.Click += new System.EventHandler(this.startListenBtn_Click);
            // 
            // listenList
            // 
            this.listenList.FormattingEnabled = true;
            this.listenList.Location = new System.Drawing.Point(327, 65);
            this.listenList.Name = "listenList";
            this.listenList.Size = new System.Drawing.Size(121, 20);
            this.listenList.TabIndex = 3;
            // 
            // textLog
            // 
            this.textLog.Location = new System.Drawing.Point(62, 107);
            this.textLog.Multiline = true;
            this.textLog.Name = "textLog";
            this.textLog.Size = new System.Drawing.Size(386, 96);
            this.textLog.TabIndex = 4;
            // 
            // msgText
            // 
            this.msgText.Location = new System.Drawing.Point(62, 218);
            this.msgText.Multiline = true;
            this.msgText.Name = "msgText";
            this.msgText.Size = new System.Drawing.Size(386, 96);
            this.msgText.TabIndex = 5;
            // 
            // textInput
            // 
            this.textInput.Location = new System.Drawing.Point(62, 341);
            this.textInput.Name = "textInput";
            this.textInput.Size = new System.Drawing.Size(202, 21);
            this.textInput.TabIndex = 6;
            // 
            // chooseFileBtn
            // 
            this.chooseFileBtn.Location = new System.Drawing.Point(292, 339);
            this.chooseFileBtn.Name = "chooseFileBtn";
            this.chooseFileBtn.Size = new System.Drawing.Size(75, 23);
            this.chooseFileBtn.TabIndex = 7;
            this.chooseFileBtn.Text = "选择";
            this.chooseFileBtn.UseVisualStyleBackColor = true;
            // 
            // sendFileBtn
            // 
            this.sendFileBtn.Location = new System.Drawing.Point(373, 339);
            this.sendFileBtn.Name = "sendFileBtn";
            this.sendFileBtn.Size = new System.Drawing.Size(75, 23);
            this.sendFileBtn.TabIndex = 8;
            this.sendFileBtn.Text = "发送文件";
            this.sendFileBtn.UseVisualStyleBackColor = true;
            // 
            // sendMsgBtn
            // 
            this.sendMsgBtn.Location = new System.Drawing.Point(292, 379);
            this.sendMsgBtn.Name = "sendMsgBtn";
            this.sendMsgBtn.Size = new System.Drawing.Size(75, 23);
            this.sendMsgBtn.TabIndex = 9;
            this.sendMsgBtn.Text = "发送消息";
            this.sendMsgBtn.UseVisualStyleBackColor = true;
            // 
            // shockBtn
            // 
            this.shockBtn.Location = new System.Drawing.Point(374, 379);
            this.shockBtn.Name = "shockBtn";
            this.shockBtn.Size = new System.Drawing.Size(75, 23);
            this.shockBtn.TabIndex = 10;
            this.shockBtn.Text = "震动";
            this.shockBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.shockBtn);
            this.Controls.Add(this.sendMsgBtn);
            this.Controls.Add(this.sendFileBtn);
            this.Controls.Add(this.chooseFileBtn);
            this.Controls.Add(this.textInput);
            this.Controls.Add(this.msgText);
            this.Controls.Add(this.textLog);
            this.Controls.Add(this.listenList);
            this.Controls.Add(this.startListenBtn);
            this.Controls.Add(this.portInput);
            this.Controls.Add(this.ipInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ipInput;
        private System.Windows.Forms.TextBox portInput;
        private System.Windows.Forms.Button startListenBtn;
        private System.Windows.Forms.ComboBox listenList;
        private System.Windows.Forms.TextBox textLog;
        private System.Windows.Forms.TextBox msgText;
        private System.Windows.Forms.TextBox textInput;
        private System.Windows.Forms.Button sendFileBtn;
        private System.Windows.Forms.Button sendMsgBtn;
        private System.Windows.Forms.Button shockBtn;
        private System.Windows.Forms.Button chooseFileBtn;
    }
}

