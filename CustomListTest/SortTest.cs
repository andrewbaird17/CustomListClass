using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomClassList;

namespace CustomListTest
{
    [TestClass]
    public class SortTest
    {
        [TestMethod]
        public void Sort_TakeInAMixedListOfInts_ReturnedListSortedfromSmallToBig()
        {
            //Arrange
            MyList<int> mixedList = new MyList<int>() { 5, 9, 32, 56, 89, 17, 3, 14, 1, 100, 59, 99, 32, 69 };
            MyList<int> expectedList = new MyList<int>() { 1, 3, 5, 9, 14, 17, 32, 32, 56, 59, 69, 89, 100 };
            string expected = expectedList.ToString();

            //Act
            MyList<int> result = mixedList.Sort();
            string actual = result.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Sort_TakeInAMixedListOfStrings_ReturnedListSortedInAlphabeticalOrder()
        {
            //Arrange
            MyList<string> mixedList = new MyList<string>() { "a", "lazy", "fox", "jumps", "over", "the", "log"};
            MyList<string> expectedList = new MyList<string>() { "a", "fox","jump", "lazy", "log", "over", "the"};
            string expected = expectedList.ToString();

            //Act
            MyList<string> result = mixedList.Sort();
            string actual = result.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
