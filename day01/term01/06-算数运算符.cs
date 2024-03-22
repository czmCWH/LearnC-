using System;
namespace term01
{
    public class OperationClass
    {
        public OperationClass()
        {
        }

        
        public void testOperation()
        {
            /*
             * C# 中 “+” 运算符适用于 字符串和数值类型。对于数值类型之间，“+”表示计算和；对于含有字符串类型之间，“+”表示字符串拼接；
            */
            Console.WriteLine(15 + 15);
            Console.WriteLine(15 + 0.5);
            Console.WriteLine(5.0 + "你好");

            /*
             * C#中 “-” 作为一元运算符时，数值类型的结果是操作数的反数。
             * “-” 作为二元运算符，其功能是做减法。
             */
            int a = 5;
            Console.WriteLine(-a);
            Console.WriteLine(a - 1);
            Console.WriteLine(a - 0.5);

            /*
             * C# 中 “*” 用于计算操作数的积。
             */
            Console.WriteLine(5*2);
            Console.WriteLine(-0.5*0.22);

            /*
             * C# 中 “/” 所有数值类型都具有预定义除法运算符
             */
            Console.WriteLine(-5 / 2);          // 结果：2，int类型计算结果为 int 类型
            Console.WriteLine(-5.0 / 2);        // 结果：-2.5

            /*
             * “%” 求余数
             */
            Console.WriteLine(5 % 2);       // 结果为 int
            Console.WriteLine(-5 % 2);      // 结果为 int
            Console.WriteLine(5.0 % 2.2);   // 结果为 double
            Console.WriteLine(5.0m % 2.2m); // 结果为 decimal
            Console.WriteLine(-5.2 % 2.0);  // 结果为 double

        }

       
    }
}
