﻿using System;
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
        public void Sort_TakeInAMixedListOfTwoInts_ReturnedListSortedfromSmallToBig()
        {
            //Arrange
            MyList<int> mixedList = new MyList<int>() { 2, 1, 1, 1, 1, 1, 2, 2, 2, 2, 1, 2 };
            MyList<int> expectedList = new MyList<int>() { 1, 1, 1, 1, 1, 1, 2, 2, 2, 2, 2, 2 };
            string expected = expectedList.ToString();

            //Act
            MyList<int> result = mixedList.Sort();
            string actual = result.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
