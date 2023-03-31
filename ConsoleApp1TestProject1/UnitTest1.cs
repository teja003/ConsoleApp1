using ConsoleApp1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace ConsoleApp1TestProject1
{
    [TestClass]
    public class UnitTest1
    {

        [TestCategory("Addtion")]
        [TestMethod]
        public void TestMethod1()
        {
            int res = Program.AddNums(1, 2);
            Assert.AreEqual(3, res);
        }


        [TestCategory("Addtion")]
        [TestMethod]
        public void TestMethod2()
        {
            int res = Program.AddNums(1, 1);
            Assert.AreEqual(3, res);
        }

        [TestCategory("Addtion")]
        [DataTestMethod]
        [DataRow(1, 1,2)]
        [DataRow(1, 2,3)]
        [DataRow(10,2,12)]
        [DataRow(10,12,22)]
        public void TestMethod3(int a, int b, int expected)
        {
            int res = Program.AddNums(a,b);
            Assert.AreEqual(res, expected);
        }

        [TestCategory("Addtion")]
        [TestMethod]
        [Ignore]
        public void TestMethod4()
        {
            int res = Program.AddNums(1, 4);
            Assert.AreEqual(5, res);
        }

        [TestCategory("Addition")]
        [TestMethod]
        public void TestMethod5()
        {
            int res = Program.AddNums(3, 4);
            Assert.AreEqual(7, res);
        }

        [TestCategory("Subtraction")]
        [TestMethod]
        public void TestSubNumsMethod()
        {
            int res = Program.SubNums(5, 1);
            Assert.AreEqual(4, res);
        }
    }
}