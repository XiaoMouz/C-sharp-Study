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

但是当父类没有无参的构造函数时会导致错误
