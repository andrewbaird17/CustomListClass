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
        public void OverloadPlus_AddListsofEqualSize3_ListEqualTo135246()
        {
            //Arrange
            MyList<int> one = new MyList<int>() { 1, 3, 5 };
            MyList<int> two = new MyList<int>() { 2, 4, 6 };
            MyList<int> expected = new MyList<int>() { 1, 3, 5, 2, 4, 6 };
            

            //Act
            MyList<int> result = one + two;
            
            //Assert
            Assert.AreSame(expected, result);
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
            MyList<string> expected = new MyList<string>() { "1", "3", "5", "7", "2", "4" };

            //Act
            MyList<string> result = one + two;
            

            //Assert
            Assert.AreSame(expected, result);
        }
    }
}
