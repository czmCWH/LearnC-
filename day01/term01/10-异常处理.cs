using System;
namespace term01
{
    public class CatchClass
    {
        public CatchClass()
        {
        }


        /*
         * 异常处理
         * 并不是所有语句都需要加上错误处理。因为错误处理时，消耗的系统资源较大，过多的错误处理将拖累程序运行效率。
         * 只有在用户操作介入的部分，加入异常处理即可。
         */
        public void testCatch()
        {
            int top = 0, bottom = 0, result = 0;
            try
            {
                result = top / bottom;
            }
            catch (System.Exception ex)
            {
                System.Console.WriteLine("出现错误");
                System.Console.WriteLine(ex.Message);
            }
            finally
            {
                System.Console.WriteLine("完成");
            }
        }
    }
}
