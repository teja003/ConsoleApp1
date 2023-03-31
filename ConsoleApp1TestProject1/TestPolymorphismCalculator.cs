using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProblemSolving;

namespace TestProject
{
    [TestClass]
    public class TestLuckyNumberPredictor
    {
        [DataTestMethod]
        [DataRow(10,8)]
        [DataRow(29, 34)]
        [DataRow(14, 13)]
        [DataRow(3, 3)]
        public void TestPedictorLucky(int dob, int lucky)
        {
            LuckyNumberPredictor predict = new LuckyNumberPredictor(dob);
            Assert.AreEqual(lucky,predict.GetLuckyNumber());
        }

        [DataTestMethod]
        [DataRow(10, 1)]
        [DataRow(29, 11)]
        [DataRow(14, 5)]
        [DataRow(3, 3)]
        public void TestPedictorUnLucky(int dob, int lucky)
        {
            LuckyNumberPredictor predict = new LuckyNumberPredictor(dob);
            Assert.AreEqual(lucky, predict.GetUnLuckyNumber());
        }
    }

    [TestClass]
    public class TestPolyMorphismCalculatorNormal
    {
        private NormalCalculator nc;
        [TestInitialize]
        public void Initialize()
        {
            nc = new NormalCalculator();
        }

        [DataTestMethod]
        [DataRow(1,1,2)]
        [DataRow(1,2,3)]
        [DataRow(1,3,4)]
        [DataRow(4,4,8)]
        public void TestAddNumber(int a, int b, int res)
        {
            Assert.AreEqual(res,nc.AddNums(a, b));
        }
    }
}
