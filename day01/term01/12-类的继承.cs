using System;
namespace term01
{

    /*
     * C# 中一个类只能从一个类继承，可以从多个接口继承。构造函数和析构函数不能被继承。
     * 可以从派生类构造函数中添加初始化基类的代码。
     */

    /* 
     * 1、方法重载
     * 在同一作用域中，定义的方法名称相同，但参数个数或类型必须不同，就是重载
     * 
     * 方法重载并不是类继承中的内容，只是它容易和重写等混淆。
     * 方法重载 是指在同一个作用域、同一个方法名称、具有不同的参数类型或参数个数，在调用方法时，根据参数自动决定使用哪一个方法。
     * 在 C# 中，放啊参数没有默认值，可通过重载来实现默认值功能。
     * 
     * 2、方法重写
     * 在派生类中可以重写基类的方法，其方法名称、参数个数和类型都必须相同，基类中用 virtual 声明被重写的方法，派生类中使用 override 声明重写方法。
     * 
     * 3、方法隐藏
     * 在派生类中使用 new 关键字，定义和基类中方法名称、参数个数和类型完全相同。
     * 
     */

    public class InheritSubClass
    {
        private int i = 0;

        public InheritSubClass(int index)
        {
            i = index;
        }

        public virtual string readString(string str)
        {
            return str + "用来方法重写";
        }

        public string GetString()
        {
            return "这是一个基类的方法";
        }
    }

    public class InheritClass: InheritSubClass
    {
        private int j = 0;

        // 定义构造函数，并初始化基类。
        public InheritClass(int index): base(index)
        {
            j = index;
        }

        // 重写基类的方法
        public override string readString(string str)
        {
            return base.readString(str) + "我重写了方法";
        }

        // 隐藏基类的方法
        public new string GetString()
        {
            return "这是隐藏了基类 GetString()的方法";
        }
    }


}
