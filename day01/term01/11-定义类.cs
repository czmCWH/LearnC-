using System;
namespace term01
{

    /* C# 是一种面向对象的编程语言。可以定义类以表示应用程序的类型，然后创建对象作为这些类的实例。
    * 在 C# 中，类可以包含字段、方法、属性 和 索引器。
    * 
    * 
    * 类的访问修饰符
    * 
    *  public：访问不受限制
    *  protected：访问仅限于包含类或从包含类派生的类型。
    *  internal：访问仅限于当前程序集
    *  protected internal：访问仅限于当前程序集或从包含类派生的类型。
    *  private：访问仅限于包含类型。
    */

    public class DeclareClass
    {

        /* 1、定义字段 和 属性
         * 字段表示类级别的变量、常量。如下定义类 _year、_month、_day 三个字段。
         * 大多数情况下字段的访问修饰符均为 private，如果修饰符为public，那么在类之外都可以访问该字段。但不建议这样做，应该通过属性或方法来访问类中的数据。
         * 
         * 属性用于将类中的数据暴露给类外。如下定义了 Year、Month、Day 三个属性。其中 Day为只读属性。
         * 定义 get/set 访问器
         */

        private int _year;
        private int _month;
        private int _day;

        public int Year
        {
            get { return _year; }
            set { _year = value; }
        }

        public int Month
        {
            get { return _month; }
            set { _month = value; }
        }

        public int Day
        {
            get { return _day; }
        }

        /* 2、定义索引，很少使用
         */
        public string this[int index]
        {
            get
            {
                return "X" + index.ToString();
            }
        }


        /* 3、构造函数和析构函数
         * 
         * 每个类，一般都包含两个固定的函数，即构造函数和析构函数。
         * 
         * 构造函数在实例化类时，由编译器自动调用。
         * > 构造函数名和类名相同。
         * > 构造函数通常用来初始化值，访问级别一般是 public。
         * > 构造函数无返回值，可以重载。
         * 
         * 析构函数是当对象即将从内存中移除时由运行库执行引擎调用的方法，通常用来释放一些资源。
         * > 一个类只能有一个析构函数。
         * > 无法继承或重载析构函数。
         * > 不能调用析构函数，它们是被自动调用的。
         * 
         */

        // 构造函数
        public DeclareClass()
        {
            // 进行相关的初始化
        }

        // 析构函数
        ~DeclareClass()
        {
            // 释放相关资源
        }
       
    }
}
