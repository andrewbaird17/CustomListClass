﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomClassList;

namespace CustomListTest
{
    [TestClass]
    public class ToStringTest
    {
        [TestMethod]
        public void ToString_TestIfAnythingThere_NothingToConvert()
        {
            //Arrange
            MyList<int> myList = new MyList<int>();
            string expected = "";

            //Act
            string actual = myList.TooString();

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void ToString_ConvertTheFirstItemToAString_FirstItemReturnedAsTypeString()
        {
            //Arrange
            MyList<int> myList = new MyList<int>() {0};
            string expected = "0";
            string actual;
            //Act
            actual = myList.TooString();

            //Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void ToString_ConvertEntireInputListToAString_ListIsOneLongString()
        {
            //Arrange
            MyList<int> myList = new MyList<int>() { 0, 1, 2, 3, 4, 5};
            string expected = "012345";
            string actual;

            //Act
            actual = myList.TooString();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
