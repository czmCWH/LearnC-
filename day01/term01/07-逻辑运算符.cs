using System;
namespace term01
{
    public class LogicOperationClass
    {
        public LogicOperationClass()
        {
        }

        /* 用逻辑运算符把运算对象连接起来 符合 C# 语法的式子称为逻辑表达式。
         * 1、一元运算符，只作用于其后的操作数。如：!、^
         * 2、二元运算符，用于表达式产生一个true或false的逻辑值。如：&&、||、&、|
         */

        public void testLogic()
        {
            // && 如果 x 为 false，则不计算y，表达式返回false。这种被称为短路计算。

            // | 或，当且仅当两个操作数均为false，结果才为false。

            // & 与，当且仅当两个操作数均为true，结果才为true。

            // ^ 异或，当且仅当只有一个操作数为true，结果才为true。


            // ~ 对操作数执行按位求补运算，其效果相当于反转每一位。



        }

    }
}
