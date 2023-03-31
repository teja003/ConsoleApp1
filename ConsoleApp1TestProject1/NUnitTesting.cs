using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ConsoleApp1;

namespace ConsoleApp1TestProject1
{
    [TestFixture]
    public class NUnitTesting
    {
        [Test]
        public void TestAdd()
        {
            int res = Program.AddNums(3, 2);
            Assert.AreEqual(5, res);
        }
    }
}
