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



# 多态

- 概念:让一个对象表现出多种状态(类型)

## 举例

- 先创建一个父类，里面要有一个方法、一个字段和一个带参数构建方法，而后创建2个以上基于该父类的之类，除了构建方法带上`:base()`以外，同时写一个具有标志性的方法与父类方法重名

```c#
//创建子对象
SubExample s1 = new SubExample("hi");
SubExample s2 = new SubExample("hi2");
TrdExample t1 = new TrdExample("hello");
TrdExample t2 = new TrdExample("hello2");
//将其放入父类数组
Example[] es = {s1,s2, t1, t2};
```



如果在一般的时候，将这些对象放入父类的数组中，其读取出来都是父类的对象，调用也是父类的资源，需要通过以下代码强转后调用

```c#
for (int i = 0; i < es.Length; i++)
            {
                if(es[i] is SubExample)
                {
                    ((SubExample)es[i]).WhoAmI();
                }else if(es[i] is TrdExample)
                {
                    ((TrdExample)es[i]).WhoAmI();
                }
            }
```



这样未免过于繁琐了，因此需要以下方法实现一个对象多种状态以供调用

## 实现多态

实现多态有三种方法

1. 虚方法
2. 抽象类
3. 接口

## 虚方法

- 解决方案:在调用状态为父类的子类对象(即意为改对象会调用父类的方法而不是子类的方法)方法，让其父类的方法自动调用子类的方法即为虚方法

### Do

1. 将父类方法标记为虚方法，使用关键字`virtual`，即意为允许子类将该方法重写
2. 在要覆写的子类方法写入关键字`override`，即表示子类会将该同名的并且标记了`virtual`的方法重写

## 抽象类

由于部分子类不适合做父类(比如猫和狗，都有叫的需求，但是两个都不适合做父类)时，可以使用抽象类来实现多态

当然也可以用于在父类中的方法不清楚要哪些时，可以将父类写成抽象类，将方法写成抽象方法

- 抽象方法存在的意义是为了在父类无法确认(不知道父类的意义时)如何实现方法时让子类重写方法

> 抽象类禁止创建对象(无意义因此禁止)

- 解决方案:在通过`Animal(一个抽象父类) aDog = new Dog();(Dog是一个子类)`创建对象时，Dog属于Animal类，并且调用的`Brak()`——在父类中的抽象类方法和子类的重名方法(并且已使用override标记覆写)时，依旧调用的是Animal的抽象方法，但是由于是抽象方法并且有override标记因此被覆写掉是Dog中的`Brak()`方法

### Do

1. 可以将一个类标记为抽象类，在创建类时通过`abstract`关键字标记为抽象类
2. 方法也是通过`abstract`关键字标记为抽象方法

> 注意，抽象方法不允许有方法体



### 抽象类与虚方法的对比

> 抽象类和虚方法的区别
>
> > - 虚方法的父类已经有了实现，而抽象类的父类中的重名方法没有实现
>
> 抽象类
>
> > - 抽象类可以创建非抽象类属性和方法与构造函数，不过由于其是抽象类因此无法创建对象，但是这些属性和方法可以提供给子类使用
> >- 抽象成员只能存在于抽象类中，并且不可`private`
> > - 抽象类不可实例化
> >- 当子类也是抽象类时子类不需要实现父类方法和成员
> > - 抽象类中的方法在正常子类中必须实现，并且如果有返回值&传入参数也必须拥有



### 抽象属性

在抽象类中新建属性时使用`abstract`标记即可生成抽象属性



## 抽象类与虚方法

抽象类能够与虚方法兼容，在抽象类中可以创建一个虚方法，并且虚方法可以写方法体，两者可共存与覆写

# 访问修饰符补充

通过访问修饰符来控制哪些位置可以读取这个属性

## Table

| **访问修饰符** | **可用于**  | **可被哪些位置访问**                       |
| -------------- | ----------- | ------------------------------------------ |
| public         | class,other | 解决方案中的任意位置                       |
| internal       | class,other | 可被当前程序集 *(in Java is Package)* 访问 |
| protected      | other       | 只能被当前类内部和该类子类访问             |
| private        | other       | 只能被当前类内部访问                       |

> 子类的访问权限不能高于父类的访问权限    *——因为会暴露父类成员*



# 设计模式

- 设计项目的方式，用于解决项目中的难题，共计有23种设计模式

## 简单工厂设计模式

以生成笔记本为例，笔记本分为各种牌子，而只有用户知道用户需要哪个牌子的笔记本，但是工厂不能停工，为了适应用户需求可以一直生产笔记本(各个牌子的父类)，用户选择后将子类笔记本其打包在父类对象中给用户

### Do

具体参考项目



# 值传递和引用传递

- 值:
- 引用: