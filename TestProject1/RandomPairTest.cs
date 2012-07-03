using PingPang;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace TestProject1
{
    
    
    /// <summary>
    ///这是 RandomPairTest 的测试类，旨在
    ///包含所有 RandomPairTest 单元测试
    ///</summary>
    [TestClass()]
    public class RandomPairTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///获取或设置测试上下文，上下文提供
        ///有关当前测试运行及其功能的信息。
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region 附加测试特性
        // 
        //编写测试时，还可使用以下特性:
        //
        //使用 ClassInitialize 在运行类中的第一个测试前先运行代码
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //使用 ClassCleanup 在运行完类中的所有测试后再运行代码
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //使用 TestInitialize 在运行每个测试前先运行代码
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //使用 TestCleanup 在运行完每个测试后运行代码
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///DoPair 的测试
        ///</summary>
        [TestMethod()]
        public void DoPairTest()
        {
            List<string> boyNames = new List<string>();
            boyNames.Add("boy1");
            boyNames.Add("boy2");
            boyNames.Add("boy3");
            boyNames.Add("boy4");
            boyNames.Add("boy5");
            boyNames.Add("boy6");
            boyNames.Add("boy7");
            boyNames.Add("boy8");
       
            List<string> list = boyNames; // TODO: 初始化为适当的值
            int groupmembercount = 2; // TODO: 初始化为适当的值
           
            RandomPair target = new RandomPair(list, groupmembercount); // TODO: 初始化为适当的值
             // TODO: 初始化为适当的值
            Dictionary<int, List<string>> actual;
            actual = target.DoPair();

            foreach (int i in actual.Keys)
            {
                Console.Write(i);
                foreach (string s in actual[i])
                {
                    Console.Write(s);
                }
                Console.WriteLine();
            }

            Assert.AreEqual(4, actual.Count);
            
        }
    }
}
