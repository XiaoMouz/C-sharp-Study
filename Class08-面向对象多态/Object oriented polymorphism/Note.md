# 装箱和拆箱

## 概念&描述

- 装箱:将值类型转换为引用类型
- 拆箱:将引用类型转换为值类型

不论是装箱还是拆箱，效率都较为低下，因此在实际项目中应当尽量避免大规模的出现装箱&拆箱代码

### 案例

为了更好理解装箱和拆箱使用以下一个案例来理解:

```c#
using System;

namespace _BoxExample
{
    internal class Example
    {
        static void Main(string[] args)
        {
            //装箱
            int x1 = 1;
            object y1 = x1;

            //拆箱
            int x2 = (int)y1;
        }
    }
}
```

### 触发条件

只有当两种类型存在继承关系时，才有可能发生装箱&拆箱操作

例如:

```c#
string s = "1221";
int n = Convert.ToInt32(s);
```

将string转为int并没有发生装箱与拆箱操作，因为他们不存在继承关系

当发生[案例](##案例)情况时，int类型(子)与object(父)是继承关系，因此触发了装箱与拆箱操作

# 字典(键值对集合)

使用字典集合必须调用`System.Collections.Generic`才能运作

以下是创建一个字典集合的案例:

```c#
using System;
using System.Collections.Generic;

namespace _DictionaryExample
{
    internal class Example
    {
        static void Main(string[] args)
        {
            Dictionary<int,string> adic = new Dictionary<int,string>();//创建一个字典集合对象
        }
    }
}
```

这样我们创建了一个名字为`adic`的字典集合

## 作用

使用字典集合有一个很好的好处，能够控制键和值的类型，比如举例创建的对象便是要求`adic`集合的键一定是`int`类型，而值一定要是`string`类型

这样能够方便的管理对象的键，让其内容控制在合理范围内

## 调用方法

各类方法(函数)与HashTable一致，包括`Add()`与通过键赋值等

但是其遍历方式可以有些不同

### 遍历访问

同样使用`foreach()`循环，但是参数不一样

通过`KeyValuePair<>`来获得`adic`字典的键与值

```c#
using System;
using System.Collections.Generic;

namespace _DictionaryExample
{
    internal class Example
    {
        static void Main(string[] args)
        {
            Dictionary<int,string> adic = new Dictionary<int,string>();//创建一个字典

            adic.Add(1, "121");
            adic.Add(2, "889");
            adic.Add(3, "198");

            adic[1] = "233";

            //普通在Hashtable中使用的foreach遍历方式
            foreach (var item in adic.Keys)
            {
                Console.WriteLine("{0}>{1}", item, adic[item]);
            }

            //同样使用foreach但是不同参数的遍历方式
            foreach (KeyValuePair<int,string> kvp in adic)
            {
                Console.WriteLine("{0}-->{1}", kvp.Key, kvp.Value);
            }
        }
    }
}
```



# FileStream文件流

前面使用File类对文件进行操作都是一次性的，对内存会造成较大负荷，因此需要使用FileStream来进行这些操作



## 概念/区别

FileStream需要搭配StreamReader&StreamWriter使用

- FileStream用于操作字节
- StreamReader&StreamWriter用于操作字符

### File与FileStream的区别

以两个水缸举例，一个水缸的水要倒到另一个水缸，有两种方法(固定思维):

- 一勺一勺的挖，不费力但是需要长时间——FileStream
- 直接扛起来倒入另一个水缸——File

 

## 上手

创建FileStream需要调用`System.IO`

### 创建对象(FileStream)

通过以下代码来创建一个实例对象

```c#
using System;
using System.IO;//调用需要的命名空间
using System.Text;

namespace _FileStreamExample
{
    internal class Example
    {
        static void Main(string[] args)
        {
            FileStream FSRead = 
            new FileStream(@"D:\64\FileStreamExample_01.txt",FileMode.OpenOrCreate,FileAccess.ReadWrite);
            //设置访问路径，选择打开方式，需要进行的数据操作
        }
    }
}
```

其中

```c#
FileStream FSRead = new FileStream(@"D:\64\FileStreamExample_01.txt",FileMode.OpenOrCreate,FileAccess.ReadWrite);
```

的构造函数

`FileStream(string path,FileMode,FileAccess)`分别设置了文件所在路径、打开的方法与文件数据处理方法(权限)

### 设置读取缓存区(FileStream)

通过`Read()`方法来设置读取缓存用的字节数组等参数，并且**会返回**在本次读取中实际占用的有效字节数

```c#
//设定读取缓存区域
byte[] FSRead_Cache = new byte[1024*1024*5];//设定缓存字节数组空间为5M
/设置了缓存用的字节数组、在字节数组中写入的起始偏移(通常为0)与最大缓存区域
FSRead.Read(FSRead_Cache,0,FSRead_Cache.Length);
```

而后这个方法会返回一个int类型数据

### 将字节数组中的内容解码(Encoding)

通过`Encoding`将字节数组的内容解码并存入字符串中

```c#
string s = Encoding.Default.GetString(FSRead_Cache,0,r);
```

### 关闭文件流和释放资源(FileStream)

通过`Close()`方法关闭文件流，`Dispose()`方法释放资源

```c#
FSRead.Close();//关闭文件流
FSRead.Dispose();//释放资源
```



### 写入文件与自动关闭&释放资源(FileStream&using)

做到自动关闭与自动释放资源需要让整个FileStream在`using(){}`框架内

以下是一个例子:

```c#
			//通过FileStream写入文件，并且通过using自动关闭
            using(FileStream FSWrite = new FileStream(
                    @"D:\64\FileStreamExample_01.txt", FileMode.OpenOrCreate,FileAccess.ReadWrite)
                 )
            {
                //准备写入的内容
                string need_write = "12138";
                //设定缓存字节数组空间为5M
                byte[] FSWrite_Cache = Encoding.UTF8.GetBytes(need_write);
                FSWrite.Write(FSWrite_Cache,0,FSWrite_Cache.Length);
            }
            Console.WriteLine("Write Success");
```



# StreamReader & StreamWriter

## StreamReader

通过以下代码新建对象

```c#
StreamReader readAfile = new StreamReader(@"D:\64\S1.txt",Encoding.Default)
```

使用`Encoding.Default`来确保编码正确



## StreamWriter

通过以下代码新建对象

```c#
StreamWriter writeAfile = new StreamWriter(@"D:\64\new.txt")
```

可以在创建对象时确认是否要在写入时覆盖源文件还是叠加源文件

```c#
StreamWriter writeAfile = new StreamWriter(@"D:\64\new.txt",true)//覆盖
```

