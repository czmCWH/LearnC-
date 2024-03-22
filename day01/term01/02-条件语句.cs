using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace term01
{
    public class ConditionClass
    {
        public ConditionClass()
        {


        }

        /*
         1、if 语句
         */

        public void testIf()
        {
            int a = 10;
            if (a == 10)
            {
                //Console.Write(a);
                Console.WriteLine("a={0}", a);
            } else if (a == 1)
            { 
                Console.WriteLine("a不等于12");
            }
            else
            {
                Console.WriteLine("a不等于10或12");
            }

        }


        /*
         2、switch 语句
           > case个数 >= 0
           > 任何两个case语句的常量表达式都不能具有相同的值，注意是值不能相同。
           > case 和 default 的 break 必不可少，这不同于C++。
           > default可以省略
           > condition 允许的数据类型为：sbyte、byte、short、ushort、uint、long、ulong、char、string或者枚举类型。

         */

        public void testSwitch()
        {

            int a = 10;
            switch (a)
            {
                case 1:
                    Console.WriteLine("a={0}", a);
                    break;
                case 10:
                    Console.WriteLine("switch a等于10");
                    break;
                default:
                    Console.WriteLine("switch default");
                    break;
            }
        }


    }
}
