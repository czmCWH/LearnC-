using System;
namespace term01
{
    public class JumpClass
    {
        public JumpClass()
        {

        }

        /*
         1、goto 语句将程序控制直接传递给标记语句。
         */
        public void testGoto()
        {
            //goto Label1;
            //Console.WriteLine("1");
            //Label1;
            //Console.WriteLine("goto label1");
        }

        /*
         2、break 直接跳出循环控制
         */
        public void testBreak()
        {
            for (int i=1; i<=5; i++)
            {
                if (i==3)
                {
                    break;
                }
                Console.WriteLine("跳转语句 break, i={0}", i);
            }
        }

        /*
         3、continue 忽略本次循环体内剩下的语句，进行下一次循环
         */
        public void testContinue()
        {
            for (int i=1; i<= 5; i++)
            {
                if (i==3)
                {
                    continue;
                }
                Console.WriteLine("continue结束本轮循环, i={0}", i);
            }
        }
    }
}
