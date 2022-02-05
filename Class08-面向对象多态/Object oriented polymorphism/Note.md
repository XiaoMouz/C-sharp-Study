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

