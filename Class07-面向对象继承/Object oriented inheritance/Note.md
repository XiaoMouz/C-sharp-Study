# 命名空间

命名空间可以理解为类的文件夹，当跨项目调用类、方法、数据时，可以通过命名空间来指定使用哪个项目的类

在当前项目中没有所需命名空间可以通过以下方法来导入类所在命名空间

1. 鼠标点报错代码左下角刷子
2. 按下Alt+Shift+F10打开补全对话列表
3. 记住命名空间，手动输入应用

## 引用方法

1. 添加引用(右键项目，添加项目引用)
2. 在项目中调用

有以下几种情况:

一、只有两个项目

```c#
using Classname;
```

二、有多个项目

```c#
using Namespace.Classname; //添加项目
```



# 值类型和引用类型

**区别：**

- 值类型和引用类型在内存上存储位置不一样
- 在传递值类型和传递引用类型的时传递方式不一样
- 值类型传递称之为值传递，引用类型称之为引用传递



**目前学过的值类型：**int、double、bool、char、decimal、struct(结构)、enum(枚举)

**目前学过的引用类型：**string、自定义类、数组



## 值类型与引用类型的存储

- 值类型的值是存储在内存的栈中
- 引用类型的值是存储在内存的堆中



### 粗解堆栈存储

以`int`为例，使用`int`声明一个`num`变量为12时，会在栈的内存中开辟空间存储为12并且命名为`num`

而string，使用`string`声明一个s变量为"123"时，会在堆的内存中开辟空间存储“123”，并且在**栈**中开辟空间，存储"123"的在**堆中的内存地址**，并将该栈命名为s

在自定义类中 <WIP>





# 字符串的不可变性

*并非指不可修改字符串变量*

在`string s="zs"`中，在堆中会存储`"zs"`在栈中开辟空间存储堆部分的地址并且命名为s

当执行`s="ln"`后，会在堆中开辟一个空间用于存储`"ln"`，然后将栈中的地址修改为新开辟的空间存储地址，之前的空间不会做任何处理

> 在程序结束后GC会回收堆中未被指向的空间



当字符串内容相同时，如下代码

```c#
string s1="zs";
string s2="zs"
```

在栈中的地址虽然不一样，但是其引用的堆地址是一样的

当某一字符串修改值时，会在堆中开辟新空间存储并将栈中地址指向新空间



# 字符串

*字符串可以看做是char类型的只读数组*

```C#
string s="abcdefg";
//通过下标访问字符串某一元素
Console.WriteLine(s[0]);
//运行即可
```

## 修改字符串

如果需要修改string中某一下标元素，只能通过如下方式进行

```c#
string pp2 = "abcdefg";
char[] ch = pp2.ToCharArray();//将string转为字符数组
ch[0] = 'b';
pp2 = new string(ch);//重新赋值
```

来重新设定指向栈

其中`<string>.ToCharArray()`是将string转换为字符数组的方法

`new string(char[])`能够将char数组转换为字符串

> string字符串本质就是静动态类 (may?)



如果需要整体重新修改通过`<string> = "<contact>";`即可



## String Builder (SB)

**String Builder：可变字符串对象**

String Builder效率更高，并且没有去堆中新建空间，因此也更节省内存

String Builder并不能代替String，一般使用String Builder来处理需要多次重复赋值的字符串

- `using System.Text;`调用命名空间

- `StringBuilder <name> = new StringBuilder();`新建对象

- `<name>.ToString();`转换为String字符串





# 字符串的方法

- `<StringName>.Length` 获得字符串长度
- `<StringName>.ToUpper()`  将字符串小写转大写
- `<StringName>.ToLower()`  将字符串大写转小写
- `<StringName>.Equals(string.value,type)` 对比字符串（Type控制需要对比的类型）
- `<StringName>.Spilt(char[],option)` 分割字符串（Option可以控制一些处理方法）
- `<StringName>.Contains(value/string)` 配对字符串，若在变量中遇到与`value/string`相同的内容便会返回bool类型`true`
- `<StringName.Replace(value/string,value/string)` 替换字符串， 若在变量中发现传入参数1(`value/string`)与传入参数2(`value/string`)相同，则将变量中的参数1替换为参数2，并且将替换后的内容做返回值返回(因此需要使用字符串接收)
- `<StringName>.Substring(int1(,int2))` 将字符串截取，将变量中从`int1`中开始截到最后一段，如果有`int2`传入，则截取到字符串在`int2`下标的位置
- `<StringName>.Startwith/Endwith(value/string)` 如果字符串是以`value/string`开头/结尾则返回`true`
- `<StringName>.IndexOf()` 字符串能够配对上字符的下标查询，返回`int`类型，`int`类型为-1时代表没有找到
- - 此方法可以有多个传入参数，代表含义不同(上面几个方法也有不同传参含义不同，但是并不复杂) 
- - `IndexOf(char/string)` 搜索`char/string`中的内容(第一个搜索到的字符)
  - `IndexOf(char/string,int)` 搜索至字符串中下标为`int`开始之后的字符串与`char/string`配对的位置(包括`int`下标的内容)
- `<StringName>.LastIndexOf(char/string)` 搜索字符串中内容最后一次出现`char/string`参数内内容的位置，返回`int`类型

**`LastIndexOf`和`IndexOf` 若使用字符串配对，则会返回字符串所配对的第一个字母的下标**

- `<StringName>.IsNullOrEmpty(char/string) ` 判断是否是空字符
- `<StringName.Join()` 在字符串数组之间添加特定字符

# 继承

在类与类之间出现代码冗余时，可以使用继承将冗余代码进行单独封装

在将重复的成员封装后，利用以下方法来设定继承关系

例:Person类包含了Teacher,Student,Driver三个类都重复的成员，可以透过以下代码来让这三个类继承Person中的成员

```c#
public class Teacher:Person
//[public] class ClassName:FatherClassName <使用方法
//此时，Teacher/Student/Driver 均是 Person的子类(派生类)，Person是他们的父类(基类)
```

子类会继承属性和方法，但是并不会继承父类的私有字段(或继承了但不可访问)

## 继承的单根性与传递性

单根性：一个子类只能有一个父类

传递性：举例，以下代码为例解释

```c#
public class Teacher:Person{ 
//此时Teacher完全继承了Person的Public级成员
...
}

public class Driver:Teacher{ 
//此时Driver不但完全继承了Teacher的Public级成员，还继承了Person的Public级成员
...
}
```

因此这个就是继承的传递性

## 查看类图

*额...不知道，2022没找到*

## 父类的构造函数

子类**不会继承**父类的构造函数

但是当父类没有无参的构造函数时会导致错误，因为子类会默认调用父类的构造函数来创建一个父类对象让子类能够使用父类的成员

在子类创建新对象时，会通过父类的构造函数新建一个父类的对象

> 为何要创建父类对象？
>
> 在创建子类对象时，会在子类内部创建一个父类对象，由于继承的原因，子类会继承父类的方法，但是在创建对象时也要创建父类对象才能让子类能够使用父类的属性与方法

因此在为父类单独新建构造函数时，需要记得添加一个无参的构造函数 **或者** 通过关键字`base()`在子类中显示调用父类的构造函数

- 例子已存放在`05-继承 > Driver.cs` 中

## Object - 基类

在C#中，所有类都继承了Object基类，如果没有继承任何父类也默认继承Object类

## 隐藏父类成员

当父类和子类拥有一个重名方法时，子类方法会隐藏掉父类方法，因此在主函数中便无法调用父类的那一个方法，如果是有意隐藏，需要在方法前添加关键字new

```c#
public new void yum(){
...
}
```



# 里氏转换

1. 子类可以赋值给父类
2. 如果父类装有子类对象，那么这个父类可以强转为子类对象



父类的对象只能调用自己父类所拥有的的对象



## 子类赋值给父类

参考代码 ↓

```c#
Student s = new Student("name",12,'m',1);
Person p = s; //若父类装的是子类对象，那么可以说这个父类强转为子类对象，如右侧代码赋值

//甚至可以使用以下方法来代替
Person p = new Student(...);
```

> 若有某个地方需要父类作为参数，此时可以使用子类来代替，因为子类包含了父类的成员





## 将父类强转为子类对象

当父类装有子类对象时，可以通过强转的形式来将父类转为子类

参考代码 ↓

```C#
Person p = new Student("name",12,'m',1);//新建父类对象
Student s = (Student)p;//将父类强转
```



## 里式转换的判断

- **is**:若能转换成功则返回`true`,失败则返回`false`
- **as**:如果能够转换，则返回对应的对象，否则返回`none`



- is的使用

```C#
//代码接上段
if(p is Teacher){ //Teacher在类视图中与Student同等级，因此转换应失败
	Teacher t = (Teacher)p;
}
else{
	Console.WriteLine("失败")
}
```

- as的使用

```c#
//代码接上段
Teacher t = p as Teacher;
//t的内容必定为none，因为无法转换
```



# protected关键字

- protect - 受保护的

`protected`关键字权限的成员，可以让本类和子类访问此成员



## 权限关键字

- `public`:在调用得当的情况下，整个解决方案都可以访问赋值
- `internal`:可以让同一命名空间的类访问赋值
- `protected`:可以让该类与该类的子类访问与赋值
- `private`:只能通过`get`与`set`来访问与赋值



# ArrayList

创建一个arraylist对象（集合对象）:

```C#
using System;
using System.Collections;//使用他们所在的命名空间

namespace _ArraylistExample
{
    internal class CreateArraylist
    {
        static void Main(string[] args)
        {
            ArrayList first = new ArrayList();
        }
    }
}
```



## 什么是ArrayList

- Array List类似一个数组，但是在很多方面上比数组更为优越

### ArrayList的好处

1. ArrayList是很多数据的集合 - 也就是集合
2. 相比起数组能够随意更变长度
3. 能够存储多种类型的数组（类型不固定）



## 对ArrayList的数据操作

假设已创建对象并且对象中有初值

### ArrayList 数据添加

如下代码，随意添加数据:

```C#
first.Add("jwdioaiaw");
first.Add(3131);
first.Add(true);
```

### ArrayList 数据读取

通过如下代码可以调用`first`集合中的数据:

```c#
for (int i = 0; i < first.Count; i++)
{
	Console.WriteLine(first[i]);
}
```



### ArrayList 添加数组与对象

通过如下代码加入数组（与普通加入方式无差别）:

```c#
first.Add(new int[] { 1,2,3,4,5});
Person p = new Person();
first.Add(p);
first.Add(first);
```

但是读取时，结果变成了如下内容:

```cmd
System.Int32[]
_09_ArrayList.Person
System.Collections.ArrayList
```



因此需要使用`AddRange`方法来添加为妙:

```c#
first.AddRange(new int[] { 12312, 1212, 342342, 121 });
for (int i = 0; i < first.Count; i++)
{
		Console.WriteLine(first[i]);
}
```



### ArrayList 数据删除与清空

通过以下代码删除单一元素

```c#
first.Remove(true);
```

此时true元素即被删除，填写谁就会删除谁



若要指定下标删除则使用以下代码

```c#
first.RemoveAT(0);
```

此时下标的元素被删除



若要删除某一范围的元素则使用以下代码

```c#
first.RemoveRange(0,3);
```

此时下标0-3之间的所有的元素被删除



若要清空元素则使用

```c#
first.Clear();
```

即可

### ArrayList 数据插入

若要插入一个数据，使用`Insert`方法，例子:

```c#
first.Insert(1,102);
```

若要插入的是集合或数组，则使用`InsertRange`方法，例子:

```c#
first.InsertRange(1, new string[] { "121", "dawjiod" });
```



### ArrayList  数据查询

使用`Contains`方法，查询是否包含指定元素，返回bool值(符合返回true不符合返回false)，例子:

```c#
first.Contains(1);
```



## 关于Console.WriteLine()

在通常情况下，将一个对象打印到控制台，通常情况下打印的会是这个对象所在类的命名空间

## 如何让Console.WriteLine()打出自己所需的内容

1. 首先判断ArrayList中的数据是否是对象
2. 若是则将其转换为所需对象，然后执行相关方法

```c#
for (int i = 0; i < first.Count; i++)
{
	if(first[i] is Person)
		{
			((Person)first[i]).Say();
        }
    else if(first[i] is int[])
        	{
            	for (int j = 0; j < ((int[])first[i]).Length; j++)
                    {
                        Console.WriteLine(((int[])first[j]));
                    }
                }
	else
        	{
            	Console.WriteLine(first[i]);
           	}
	//Console.WriteLine(first[i]);
}
```



## 前面对数组的处理太sb了

在添加数组与集合时，建议使用`<ArrayList>.AddRange`方法，使用这个方法便能更加方便的调用这种数据

演示代码:

```c#
first.AddRange(new int[] { 12312, 1212, 342342, 121 });
for (int i = 0; i < first.Count; i++)
{
		Console.WriteLine(first[i]);
}
```

控制台即可输出int数组内的数据



## ArrayList 长度

通过以下两个方法来获得一个ArrayList的长度信息

- `count`:表示集合中实际包含的元素个数
- `capacity`:表示集合中可以包含的元素个数

> 在ArrayList集合中，当集合内包含的个数(count)超过了可以包含的个数(capacity)时，集合会向内存申请开辟一倍的空间(相较于上次)，来保证集合的长度一直够用

eg:

| count | capacity |
| :---- | -------- |
| 1     | 4        |
| 5     | 8        |
| 9     | 16       |



# Hashtable( 键值对集合 / 字典 )

在键值对集合中，是通过键来找到值的

因此如果要遍历键值对集合，需要使用[`foreach`](#foreach)循环

```c#
using System;
using System.Collections;//使用他们所在的命名空间

namespace _HashtableExample
{
    internal class CreateHashtable
    {
        static void Main(string[] args)
        {
            Hashtable a = new Hashtable();
        }
    }
}
```

**键必须唯一，值可以随意**

## 对Hashtable的数据操作

### 关于添加、删除等操作

大部分操作和ArrayList的函数差不多，可以自行尝试

例如`Remove()`移除指定Key以及Value,`Clear()` 清空,`Add()` 添加

普通的赋值方法也能工作

```c#
a[1]="1212";
```

此时，如果该键已经有值则会被重新赋值，如果没有值则会新建一个键来存

### 获取Hashtable的键

通过`Kesy()`函数来获得Hashtable的键

```c#
a.Keys();
```

### 获取Hashtable的值

通过`Values()`函数来获得Hashtable的值

```c#
a.Values();
```

### Hashtable数据查询

查看表内是否包含某个键、值

- `Contains()` 查询是否包含某个键
- `ContainsKey()` 查询是否包含某个键(与`Contains()`一样)
- `ContainsValue()` 查询是否包含某个值



## foreach

示例:

```c#
foreach (var item in collection)
	{
		
	}
```

foreach循环中

- `var`指的是(Hashtable)集合的元素
- `item`是集合中的每一项
- `collection`指的是集合

### 关于foreach循环和for循环的效率

在实际工作中，如果遇到循环次数较大时，for的循环的效率远高于foreach循环，因此在能够使用for循环的情况下尽量使用for循环，在遇到较大数时尽量转成for循环可读的状态下运行

## var

`var`能通过值来推断并赋予类型，不需要对变量有一个明确的定义，但是**必须初始化变量(赋予初值)**



# Path类

使用Path类需要调用命名空间`System.IO`，他们是静态类

## Path类的各种方法

方法均返回string类型数据

### 获取已知路径的文件名

通过`Path.GetFileName()`来获得文件名(带后缀)，与`Path.GetFileNameWithoutExtension()`来获得不带后缀的文件名

eg:

```c#
using System;
using System.IO;//Path类所需

namespace _PathExample
{
    internal class Path
    {
        static void Main(string[] args)
        {
            String filePath = @"D:\64\S1.txt";//一个路径
            Console.WriteLine(Path.GetFileName(filePath));//获得文件名称并打印
            Console.WriteLine(Path.GetFileNameWithoutExtension(filePath));//获得文件名称(不包含后缀)并打印
        }
    }
}

```



### 获取已知路径文件的后缀

使用`Path.GetExtension()`方法来获得文件后缀以验证文件是否是所需类型文件

eg:

```c#
using System;
using System.IO;//Path类所需

namespace _PathExample
{
    internal class Path
    {
        static void Main(string[] args)
        {
            String filePath = @"D:\64\S1.txt";
            Console.WriteLine(Path.GetExtension(filePath));
        }
    }
}

```

### 获取已知路径文件的路径信息

使用`Path.GetDirectoryName()`方法来获取文件所在路径

eg:

```c#
using System;
using System.IO;//Path类所需

namespace _PathExample
{
    internal class Path
    {
        static void Main(string[] args)
        {
            String filePath = @"D:\64\S1.txt";
            Console.WriteLine(Path.GetDirectoryName(filePath));
        }
    }
}
```

### 获取已知路径文件的完整路径信息

使用`Path.GetFullPath()`方法来获取文件完整路径信息

eg:

```c#
using System;
using System.IO;//Path类所需

namespace _PathExample
{
    internal class Path
    {
        static void Main(string[] args)
        {
            String filePath = @"D:\64\S1.txt";
            Console.WriteLine(Path.GetFullPath(filePath));
        }
    }
}
```

### 将路径拼合

使用`Path.Combine(string,string)`将两个路径拼合为一个路径

# File 类

使用File类方法(函数)需要使用`using System.IO`，他们也是静态类

## File类的各种方法

### 创建文件

使用`File.Create(string)`来创建文件，其中需要指定文件名称，但是不需要指定文件路径

如果指定文件路径务必指定完整路径，若直接输入文件名将默认在程序当前目录下创建新文件，指定相对路径会抛异常

### 删除文件

使用`File.Delete(string)`来删除文件，其中需要指定文件完整路径，但是不需要指定文件，若不指定文件则删除文件夹

如果指定文件务必指定完整路径与文件名，若直接输入文件路径将会删除整个路径下文件，指定相对路径与文件名会抛异常

### 移动文件

使用`File.Move(string,string)`来移动文件，需要指定文件完整路径

### 读取文件

#### File.ReadAllBytes

通过`File.ReadAllBytes(string(file path),Encoding)`来将文件内容转换为特定的编码格式

通过string来设置路径，Encoding来选择读取文件所使用的编码格式

使用`byte[]`数组接收



#### File.ReadAllLines

通过`File.ReadAllLines(string(file path),Encoding)`来将文件转换为string格式

通过设置path来选择路径，Encoding来选择读取使用的编码格式

使用`string[]`数组接收，一行对应一个string元素，并且将其存入数组



#### File.ReadAllText

通过`File.ReadAllText(string(file path),Encoding)`来将文件转换为string内容

通过设置path来选择路径，Encoding来选择读取使用的编码格式

读取后会转换为字符串，需要使用`string`来接收



### 写入文件

这些写入方式都会覆盖原本的文件

#### File.WriteAllBytes

通过`File.WriteAllBytes(string(file path),byte[])`来将byte[]内的内容写入到文件中

通过path来选择文件路径，byte[]来选择写入文件的内容



#### File.WriteAllLines

通过`File.WriteAllLines(string(file path),Encoding)`来将string[]内的内容写入到文件中

通过path来选择文件路径，string[]来选择写入文件的内容

每一个元素会写入一行



#### File.WriteAllText

通过`File.WriteAllText(string(file path),Encoding)`来将string内的内容写入到文件中

通过path来选择文件路径，string来选择写入文件的内容



#### File.AppendAllLines/File.AppendAllText

用于追加内容



### 补充

- `File.Copy("source","targetFileName",[true]);`:文件拷贝，如果有true则代表文件存在时进行覆盖，如果不加true则遇到重名文件抛异常

- `File.Exist();`:用于判断文件是否存在

- `File.Move("source","target")`:用于移动、剪切文件，同时也可以用于重命名

  

# 编码

将字符串以特定的形式保存为二进制，所规范的格式



# List 泛型集合

在ArrayList中已经了解了一个好处，可以随意存储各种类型的数据

但是这些数据在拿出时都会统一变成Object类型，若要使用还需要转成对应类型的数据

因此我们还有另一个集合，List集合

List集合中，已经确定了其中包含了的元素类型，在确定泛型集合的类型后，里面的元素类型也确定了

## 调用与创建

List泛型集合在`System.Collections.Generic`中，需要使用

```c#
using System.Collections.Generic;
```

来调用



通过以下代码来创建一个对象

```c#
using System;
using System.Collections.Generic;

namespace _ListExample
{
    internal class Example
    {
        static void Main(string[] args)
        {
            //创建泛型集合对象
            List<int> aw = new List<int>();
        }
    }
}

```

其中

```c#
List<type> name = new List<type>();
```

- `type`是指定List类型
- `name`用于对象命名



## 对List的数据操作

### 添加、删除、长度

与ArrayList一致，可以直接使用，但是有几个特殊的

### 根据条件来删除元素

使用`RemoveAll();`方法，在其中填入委托条件即可删除对应的元素

### 数据转换

一个对应的数组可以转换成List对象，当然一个List对象也能转换为一个对应的数组

#### List转数组

使用`ToArray();`方法，将List数组转换为**对应**元素的数组

```c#
using System;
using System.Collections.Generic;

namespace _ListExample
{
    internal class Example
    {
        static void Main(string[] args)
        {
            List<int> aw = new List<int>();//创建泛型集合对象 规定类型为int
            aw.Add(1);//添加一个元素
            int[] nums = aw.ToArray();//将List转为int数组
        }
    }
}

```

#### 数组转List

此方法需要使用`System.Linq;`才能调用相关方法，加入以下代码

```c#
using System.Linq;
```

使用`ToList()`方法，可以在新建对象时使用`ToList();`方法来直接转换成List对象

也可以直接将数组添加到某一对象中

```c#
using System;
using System.Collections.Generic;
using System.Linq;

namespace _ListExample
{
    internal class Example
    {
        static void Main(string[] args)
        {
            //创建泛型集合对象
            List<int> aw = new List<int>();
            aw.Add(1);
            int[] nums = aw.ToArray();//转数组
            List<int> bw = nums.ToList();//新建对象来存储数组
            aw.AddRange(nums);//直接添加至List对象
        }
    }
}
```