using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomClassList;

namespace CustomListTest
{
    [TestClass]
    public class OverloadMinusTest
    {
        [TestMethod]
        public void OverloadMinus_RemoveSimilarItemsInBothLists_ResultingListShouldHaveCountOf2()
        {
            //Arrange
            MyList<int> one = new MyList<int>() { 1, 3, 5 };
            MyList<int> two = new MyList<int>() { 2, 1, 6 };
            int expected = 2;
            int actual;

            //Act
            MyList<int> result = one - two;
            actual = result.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void OverloadMinus_RemoveExactSameList_ResultingListShouldBeNullAtIndex0()
        {
            //Arrange
            MyList<string> one = new MyList<string>() { "testing", "is", "fun" };
            MyList<string> two = new MyList<string>() { "testing", "is", "fun" };
            string actual;

            //Act
            MyList<string> result = one - two;
            actual = result[0];
            //Assert
            Assert.IsNull(actual);
        }
    }
}
