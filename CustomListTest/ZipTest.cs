using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomClassList;

namespace CustomListTest
{
    [TestClass]
    public class ZipTest
    {
        [TestMethod]
        public void Zip_CombineSimilarSizeLists_ResultBe123456()
        {
            // Arrange
            MyList<int> odd = new MyList<int>() { 1, 3, 5 };
            MyList<int> even = new MyList<int>() { 2, 4, 6 };
            MyList<int> expectedlist = new MyList<int> { 1, 2, 3, 4, 5, 6 };
            string expected = expectedlist.ToString();

            //Act
            MyList<int> result = MyList<int>.Zip(odd, even);
            string actual = result.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Zip_CombineSimilarSizeLists_CapacityShouldBe8()
        {
            // Arrange
            MyList<int> odd = new MyList<int>() { 1, 3, 5 };
            MyList<int> even = new MyList<int>() { 2, 4, 6 };
            MyList<int> expectedlist = new MyList<int> { 1, 2, 3, 4, 5, 6 };
            int expected = 8;
            int actual; 

            //Act
            MyList<int> result = MyList<int>.Zip(odd, even);
            actual = result.Capacity;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Zip_CombineListsOfDifferentSizeSmallerFirst_ResultBe()
        {
            // Arrange
            MyList<string> one = new MyList<string>() { "testing", "fun" };
            MyList<string> two = new MyList<string>() { "is", "lets", "do", "more" };
            MyList<string> expectedlist = new MyList<string> { "testing", "is", "fun", "lets"};
            string expected = expectedlist.ToString();

            //Act
            MyList<string> result = MyList<string>.Zip(one, two);
            string actual = result.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Zip_CombineListsOfDifferentSizeBiggerFirst_ResultBeistestingletsfun()
        {
            // Arrange
            MyList<string> one = new MyList<string>() { "is", "lets", "do", "more" };
            MyList<string> two = new MyList<string>() { "testing", "fun" };
            MyList<string> expectedlist = new MyList<string> { "is", "testing", "lets", "fun"};
            string expected = expectedlist.ToString();

            //Act
            MyList<string> result = MyList<string>.Zip(one, two);
            string actual = result.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
