# WinForm应用程序

一个基本的WinForm应用程序具有`Form.cs`，`Program.cs`组成，`Program.cs`提供逻辑，`Form.cs`提供UI和后台

通过在`Program.cs`执行

```c#
Application.Run(new Form1());
```

来调用`Form1.cs`内的构造函数初始化UI

```c#
public Form1()
{
	InitializeComponent();
}
```

> 默认模板的`Form1.cs`是由两个部分类组成，而 `InitializeComponent();`是在`Form1`的另一个部分类内自动更新的方法

而通过`InitializeComponent()`方法来调用`Form1.cs`的另一个部分类内的方法初始化UI对象

```c#
       private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(123, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }
```

# UI对象

