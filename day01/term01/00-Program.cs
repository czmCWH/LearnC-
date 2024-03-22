using System;

/*
 * 微软C#官方指南 https://learn.microsoft.com/zh-cn/dotnet/csharp/tour-of-csharp/
 * 
 * 
 */


namespace term01
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //int a, b, c;
            //Console.WriteLine("请输入 a:");      
            //a = int.Parse(Console.ReadLine());      // 等待获取终端输入，并强制转换为int
            //Console.WriteLine("请输入 b:");
            //b = int.Parse(Console.ReadLine());
            //c = a + b;
            //Console.WriteLine("a+b={0}", c);
            //Console.Read();

            // 1、预定义类型
            DataClass.useDataClass();

            Console.WriteLine("------------------------------------1");

            // 2、条件语句
            ConditionClass conditionObj = new ConditionClass();
            conditionObj.testIf();
            conditionObj.testSwitch();

            Console.WriteLine("------------------------------------2");

            // 3、循环语句
            RoundClass roundObj = new RoundClass();
            roundObj.testFor();
            roundObj.testWhile();
            roundObj.testForeach();


            Console.WriteLine("------------------------------------3");

            // 4、跳转语句
            JumpClass jumpObj = new JumpClass();
            jumpObj.testGoto();
            jumpObj.testBreak();
            jumpObj.testContinue();

            Console.WriteLine("------------------------------------4");

            // 5、数组的使用
            ArrayClass arrObj = new ArrayClass();
            //arrObj.testArray1();
            //arrObj.testArray2();
            arrObj.testArray3();
            arrObj.testArray4();
            arrObj.testArray5();

            Console.WriteLine("------------------------------------5");

            // 6、算术运算符
            OperationClass operationObj = new OperationClass();
            operationObj.testOperation();

            Console.WriteLine("------------------------------------6");

            // 7、逻辑运算符
            LogicOperationClass logicObj = new LogicOperationClass();
            logicObj.testLogic();

            Console.WriteLine("------------------------------------7");

            // 8、类型转换
            ConvertTypeClass convertObj = new ConvertTypeClass();
            convertObj.testConvert();
            Console.WriteLine("------------------------------------8");

            // 9、装箱和拆箱
            BoxingClass boxingObj = new BoxingClass();
            boxingObj.testBoxing();

            Console.WriteLine("------------------------------------9");

            // 10、装箱和拆箱
            CatchClass catchObj = new CatchClass();
            catchObj.testCatch();
            Console.WriteLine("------------------------------------10");

            // 11、定义类
            DeclareClass declareObj = new DeclareClass();
            Console.WriteLine(declareObj[123]);

            Console.WriteLine("------------------------------------11");



        }
    }
}
