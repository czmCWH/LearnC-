using System;
namespace term01
{
    public class RoundClass
    {
        public RoundClass()
        {
        }

        /*
         1、for 循环重复执行一个语句或语句块，直到指定的表达式计算为false值。
         */
        public void testFor()
        {
            for (int i=0; i<3; i++)
            {
                Console.Write("for 循环1 i={0}，", i);
            }

            //int i = 0;     // ⚠️：此时再定义i，会和上面的for循环条件表达式里面的i重复定义，很奇怪。
            int j = 0, k = 0;
            for (j=0; j<3 && k<2; j++, k++)
            {
                Console.Write("for 循环2 (j={0},k={0})，", j, k);
            }
        }

        /*
          2、while语句中要注意continue，因为循环变量是在循环体中改变的，如果使用continue时，没有改变循环变量，就会造成死循环。
         */
        public void testWhile()
        {
            // while 语句先执行条件语句，然后再循环。至少循环0次
            int i = 0;
            while (i<5)
            {
                if (i == 3)
                {
                    Console.Write(i);
                    //continue;   // ⚠️：此处死循环，因为在满足条件时，没有进行改变循环变量，而执行了continue结束本轮循环，因此造成死循环。
                }
                i++;
            }

            // do while语句先执行循环体，然后执行验证条件。循环至少被执行1次。


        }

        /*
         3、foreach in 语句为数组或对象集合中的每个元素重复一个嵌入语句组。
         */
        public void testForeach()
        {
            int[] arr = new int[] { 0, 1, 2, 3, 4, 5 };
            foreach (int i in arr)
            {
                Console.WriteLine("foreach语句，i={0}", i);
            }
        }
    }
}
