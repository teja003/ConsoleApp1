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
    public class PhotoBookTest
    {
        [TestMethod]
        public void TestDefaultPhotoBook()
        {
            PhotoBook defaultBook = new PhotoBook();
            Assert.AreEqual(16,defaultBook.GetNumberPages());
        }

        [TestMethod]
        public void TestLargePhotoBook()
        {
            AddPhotoBook largeBook = new AddPhotoBook();
            Assert.AreEqual(64, largeBook.GetNumberPages());
        }
        [TestMethod]
        public void TestMediumPhotoBook()
        {
            PhotoBook mediumBook = new PhotoBook(32);
            Assert.AreEqual(32, mediumBook.GetNumberPages());
        }
    }
}
