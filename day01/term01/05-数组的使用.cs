using System;
namespace term01
{
    public class ArrayClass
    {
        public ArrayClass()
        {
        }


        /* 1、一维数组的声明
         * 数组是引用类型，使用new来初始化数组变量，它们存储在堆内存中。数组变量存放的是指向堆内存的地址。
         */
        public void testArray1()
        {
            // 1、声明数组
            int[] intArray;
            string[] strArray;
            double[] doubleArray;


            intArray = new int[] { 1, 2, 3, 4 };
            Console.WriteLine(intArray);

            // 2、初始化数组

            // 指定元素个数初始化数组
            int[] array1 = new int[4];

            // 指定元素和个数初始化数组
            int[] array2 = new int[4] { 1, 2, 3, 4 };

            // 指定元素初始化
            int[] array3 = new int[] { 1, 2, 3 };

            int[] array4 = { 1, 2, 3 };

            Console.WriteLine(array1);
            Console.WriteLine(array2);
            Console.WriteLine(array3);
            Console.WriteLine(array4);

        }

        /* 2、多维数组的声明
         多维数组要注意维数的变化
         */
        public void testArray2()
        {
           
            // 1、定义多维数组
            int[,] intsArr = new int[2, 3];     // 定义2行3列的二维数组
            int[,] intsArr2 =
            {
                { 1, 2,3},
                { 4,5,6}
            };      // 定义2行3列的二维数组


        }

        /* 3、访问数组
         * C# 使用索引器访问数组，索引器从0开始。
         *  
         
         */
        public void testArray3()
        {
            int[] array = new int[] { 2, 8, 10, 14 };

            int[,] arrays = { { 1, 3 }, { 2, 6 }, { 3, 9 } };

            // 索引访问数组

            Console.WriteLine(array[0]);
            Console.WriteLine(array[3]);

            Console.WriteLine(arrays[1, 1]);
            Console.WriteLine(arrays[2, 0]);

            // for循环访问

            for (int i=0; i<array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            // foreach访问数组
            foreach(int val in array)
            {
                Console.WriteLine("foreach访问, val={0}", val);
            }

            // 访问多维数组
            for (int i=0; i<3; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(arrays[i, j]);
                }
            }
            Console.WriteLine("");
        }

        /* 4、数组复制
                
         */
        public void testArray4()
        {
            Console.WriteLine("---------testArray4");
            /* 1、引用复制
             * 如下 pins 和 pins2 都是引用类型，pins存储指向堆内存的地址，因此当修改 pins 或 pins2 会相互影响。
             */
            int[] pins = { 11, 22, 33 };
            int[] pins2 = pins;

            /* 2、复制数组
             */

            // 方式一，for循环复制
            int[] pins3 = new int[pins.Length];
            for (int i=0; i<pins.Length; i++)
            {
                pins3[i] = pins[i];
            }
            Console.WriteLine("pins3[0]={0}", pins3[0]);

            // 方式二，CopyTo 方法复制
            int[] pins4 = new int[pins.Length];
            pins.CopyTo(pins4, 0);
            Console.WriteLine("pins4[1]={0}", pins4[1]);

            // 方法三，使用 Array.Copy() 方法
            int[] pins5 = new int[pins.Length];
            Array.Copy(pins, pins5, pins5.Length);
            Console.WriteLine("pins5[2]={0}", pins5[2]);

            // 方法四，使用 Array 实例方法 Clone()
            // 可以一次调用完成，最方便，但是 clone() 方法返回的是一个对象，所以需要强制转换成恰当的类型
            int[] pins6 = (int[])pins.Clone();
            Console.WriteLine("pins6[2]={0}", pins6[2]);

        }

        /* 5、数组排序
                
         */
        public void testArray5()
        {
            Console.WriteLine("------testArray5数组排序");
            int[] arr = { -11, 23, 0, 3, 89, 11 };
            Array.Sort(arr);
            foreach(int val in arr)
            {
                Console.Write("{0}，", val);
            }
        }
    }
}
