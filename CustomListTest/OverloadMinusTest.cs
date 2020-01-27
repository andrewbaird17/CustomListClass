using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomClassList;

namespace CustomListTest
{
    [TestClass]
    public class OverloadMinusTest
    {
        [TestMethod]
        public void OverloadMinus_RemoveSimilarItemsInBothLists_ResultingListShouldHaveCountOf4()
        {
            //Arrange
            MyList<int> one = new MyList<int>() { 1, 3, 5 };
            MyList<int> two = new MyList<int>() { 2, 1, 6 };
            int expected = 4;
            int actual;

            //Act
            MyList<int> result = one - two;
            actual = result.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void OverloadMinus_RemoveSimilarItemsInBothLists_ResultingListShouldBe3526()
        {
            //Arrange
            MyList<int> one = new MyList<int>() { 1, 3, 5 };
            MyList<int> two = new MyList<int>() { 2, 1, 6 };
            MyList<int> expected = new MyList<int>() { 3, 5, 2, 6 };

            //Act
            MyList<int> result = one - two;


            //Assert
            Assert.AreSame(expected, result);
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
        [TestMethod]
        public void OverloadMinus_RemoveSimilarItemsButFirstListHasValueTwice_ResultingListShouldRemoveOnlyFirstValue()
        {
            //Arrange
            MyList<int> A = new MyList<int>() { 1, 3, 3 };
            MyList<int> B = new MyList<int>() { 3, 4, 5 };
            MyList<int> expected = new MyList<int>() { 1, 3, 4, 5 };

            //Act
            MyList<int> result = A - B;

            //Assert
            Assert.AreSame(expected, result);
        }
        [TestMethod]
        public void OverloadMinus_RemoveSimilarItemsButSecondListHasValueTwice_ResultingListShouldRemoveOnlyFirstValue()
        {
            //Arrange
            MyList<int> B = new MyList<int>() { 3, 4, 5 };
            MyList<int> A = new MyList<int>() { 1, 3, 3 };
            MyList<int> expected = new MyList<int>() { 4, 5, 1, 3 };

            //Act
            MyList<int> result = B - A;

            //Assert
            Assert.AreSame(expected, result);
        }
        [TestMethod]
        public void OverloadPlus_AddListsOfDifferentSize_ResultingListShouldBeStrings15924()
        {
            //Arrange
            MyList<string> one = new MyList<string>() { "1", "3", "5", "7","9" };
            MyList<string> two = new MyList<string>() { "2", "3", "4", "7" };
            MyList<string> expected = new MyList<string>() { "1", "5", "9", "2", "4" };

            //Act
            MyList<string> result = one + two;


            //Assert
            Assert.AreSame(expected, result);
        }
    }
}
