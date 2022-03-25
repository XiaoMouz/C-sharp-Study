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

# UI控件

以Button对象为例，在Winform中有`Name`和`Text`两个属性(其它属性暂时不计)

- `Name`:可以用于在后台代码中指定对象
- `Text`:是前台的字体显示

- `Visible`:控件是否可见
- `Enabled`:控件是否可用



#  事件

WinForm窗体程序是事件行为控制，有注册事件和触发事件

以之前Form案例为例

```c#
private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("123");
        }
```

其中`object sender`表示触发这个事件的对象，`EventArgs e `是表示执行这个事件需要的资源

- `object sender` 是object类型，因此这些控件依旧是继承于object类



# 窗体间跳转

在`Main`函数中创建的窗体对象，我们称之为窗口应用程序的主窗体

当主窗体关闭后，整个应用程序进程将被关闭

在`Form1`中新建一个Button，设置其绑定方法，在方法中写上

```C#
	private void button2_Click(object sender, EventArgs e)
        {
            //在内存中创建窗体对象
            Form2 form = new Form2();
            //显示窗体
            form.Show();
        }
```

即可

## 关闭所有窗体

由于其窗体之间不可访问性，因此如果要关闭所有窗体可以通过静态类共享访问来关闭

首先建立一个`Form1`静态字段的对象(同时建立静态类)

```C#
	public static class FormManager
    {
        public static Form1 _form1; 
    }
```

而后在创建Form1窗体并装载的同时将新建的对象载入到静态类中去

```C#
	private void Form1_Load(object sender, EventArgs e)
        {
            FormManager._form1 = this;
        }
```

然后就能在Form2中关闭Form1窗体了

```C#
    private void button1_Click(object sender, EventArgs e)
        {
            FormManager._form1.Close();
        }
```

