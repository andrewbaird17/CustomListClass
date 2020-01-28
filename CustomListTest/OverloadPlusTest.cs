using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomClassList;

namespace CustomListTest
{
    [TestClass]
    public class OverloadPlusTest
    {
        [TestMethod]
        public void OverloadPlus_AddListsofEqualSize3_CountEquals6()
        {
            //Arrange
            MyList<int> one = new MyList<int>() { 1, 3, 5 };
            MyList<int> two = new MyList<int>() { 2, 4, 6 };
            int expected = 6;
            int actual;

            //Act
            MyList<int> result = one + two;
            actual = result.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void OverloadPlus_AddListsofEqualSize4_ListEqualTo13572468()
        {
            //Arrange
            MyList<int> one = new MyList<int>() { 1, 3, 5, 7 };
            MyList<int> two = new MyList<int>() { 2, 4, 6, 8 };
            MyList<int> expectedlist = new MyList<int>() { 1, 3, 5, 7, 2, 4, 6, 8};
            string expected = expectedlist.ToString();
            

            //Act
            MyList<int> resultlist = one + two;
            string actual = resultlist.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void OverloadPlus_AddListsOfDifferentSize_ResultingListHasCapacity8()
        {
            //Arrange
            MyList<int> one = new MyList<int>() { 1, 3, 5, 7 };
            MyList<int> two = new MyList<int>() { 2, 4 };
            int expected = 8;
            int actual;

            //Act
            MyList<int> result = one + two;
            actual = result.Capacity;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void OverloadPlus_AddListsOfDifferentSize_ResultingListShouldBe135724()
        {
            //Arrange
            MyList<string> one = new MyList<string>() { "1", "3", "5", "7" };
            MyList<string> two = new MyList<string>() { "2", "4" };
            MyList<string> expectedlist = new MyList<string>() { "1", "3", "5", "7", "2", "4" };
            string expected = expectedlist.ToString();

            //Act
            MyList<string> result = one + two;
            string actual = result.ToString();

            //Assert
            Assert.AreEqual(expected,actual);
        }
    }
}
