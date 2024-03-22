using System;
namespace term01
{
    public class ConvertTypeClass
    {
        public ConvertTypeClass()
        {
        }

        /* 由于 C# 是在编译时静态类型化的，因此变量在声明后就无法再次声明，或者无法用于存储其他类型的值，除非该类型可以转换为变量的类型。
         * 将值复制到其它类型的变量或方法参数中，这些类型的操作称为”类型转换“。
         * 
         * 1、隐式转换，由于该转换是一种安全类型的转换，不会导致数据丢失，因此不需要任何特殊的语法。
         *      例如：int 转为 double。派生类转为基类。
         * 
         * 2、显示转换(强制转换)，需要强制转换运算符。在转换中可能丢失信息时、或在出于其他原因转换可能不成功时，必须进行强制转换。
         *       例如：数值转精度较低；基类转为派生类。
         *       
         * 3、用户定义的转换，可以定义一些特殊的方法来执行用户定义的转换，从而使不具有基类-派生类关系的自定义类型之间可以显式和隐式转换。
         */

        public void testConvert()
        {
            // 1、隐式转换
            int num = 2342323;
            long bigNum = num;
            Console.WriteLine(bigNum);

            // 2、显示转换
            double X = 3.15;
            int a;
            a = (int)X;
            Console.WriteLine("a = {0}", a);


            // 不能毫无目的的进行显式转换，如下转换失败，会导致运行时异常。
            //int i = 10;
            //string name = "a";
            //i = Convert.ToInt32(name);

        }
    }
}
