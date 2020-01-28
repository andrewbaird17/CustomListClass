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
        public void OverloadMinus_RemoveSimilarItemsInBothLists_ResultingListShouldBe35()
        {
            //Arrange
            MyList<int> one = new MyList<int>() { 1, 3, 5 };
            MyList<int> two = new MyList<int>() { 2, 1, 6 };
            MyList<int> expectedlist = new MyList<int>() { 3, 5 };
            string expected = expectedlist.ToString();

            //Act
            MyList<int> result = one - two;
            string actual = result.ToString();

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
        [TestMethod]
        public void OverloadMinus_RemoveSimilarItemsButFirstListHasValueTwice_ResultingListShouldRemoveOnlyFirstValue()
        {
            //Arrange
            MyList<int> A = new MyList<int>() { 1, 3, 3 };
            MyList<int> B = new MyList<int>() { 3, 4, 5 };
            MyList<int> expectedlist = new MyList<int>() { 1, 3 };
            string expected = expectedlist.ToString();

            //Act
            MyList<int> result = A - B;
            string actual = result.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void OverloadMinus_RemoveSimilarItemsButSecondListHasValueTwice_ResultingListShouldRemoveOnlyFirstValue()
        {
            //Arrange
            MyList<int> B = new MyList<int>() { 3, 4, 5 };
            MyList<int> A = new MyList<int>() { 1, 3, 3 };
            MyList<int> expectedlist = new MyList<int>() { 4, 5};
            string expected = expectedlist.ToString();

            //Act
            MyList<int> result = B - A;
            string actual = result.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void OverloadMinus_MinusListsOfDifferentSize_ResultingListShouldBeStrings159()
        {
            //Arrange
            MyList<string> one = new MyList<string>() { "1", "3", "5", "7","9" };
            MyList<string> two = new MyList<string>() { "2", "3", "4", "7" };
            MyList<string> expectedlist = new MyList<string>() { "1", "5", "9" };
            string expected = expectedlist.ToString();

            //Act
            MyList<string> result = one - two;
            string actual = result.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
