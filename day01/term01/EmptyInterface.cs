using System;
namespace term01
{
    /* 接口
     * 
     * 接口描述的是可属于任何类或结构的一组相关功能，所以实现接口的类或结构必须实现接口定义中指定的接口成员。
     * 
     * 接口使用 interface 定义，可以由方法、属性、事件、索引器或这四种成员类型的任意组合构成。
     * 
     * 接口的特性：
     * a、接口类似于抽象基类，不能直接实例化；接口中的方法都是抽象方法，实现接口的任何非抽象类型都必须实现接口的所有成员。
     * 
     * b、接口不能包含常量、字段、运算符、实例构造函数、析构函数或类型、不能包含静态成员。
     * 
     * c、接口成员是自动公开的，且不能包含任何访问修饰符。
     * d、接口自身可以从多个接口继承，类和结构体可以继承多个接口，但接口不能继承类。
     * 
     * 接口中的放啊用来定义对象之间通信的契约，指定接口中的方法为私有或保护没有意义，它们默认为公有方法。
     * 
     */




    public interface Nurse
    {
        void Fun();
    }

    public interface Surgeon
    {
        void Fun();
    }

    // 1、显式实现接口中的方法
    class WorkerOne: Nurse, Surgeon
    {
        void Nurse.Fun()
        {
            Console.WriteLine("显式实现 Nurse 接口中定义的方法");
        }

        void Surgeon.Fun()
        {
            Console.WriteLine("显式实现 Surgeon 接口中定义的方法");
        }
    }

    class WorkerTow : Nurse, Surgeon
    {
        void Fun()
        {
            Console.WriteLine("隐式实现 Nurse 和 Surgeon 接口中定义的方法");
        }
    }

}
