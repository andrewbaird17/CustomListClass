using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomClassList;

namespace CustomListTest
{
    [TestClass]
    public class AddTest
    {
        [TestMethod]
        public void Add_AddValueToList_CheckZeroIndex()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int expected = 2;

            //Act
            myList.Add(2);

            //Assert
            Assert.AreEqual(expected, myList[0]);
        }

        [TestMethod]
        public void Add_CheckCountAfterAdding_CountIs1()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int initial= 2;
            int expected = 1;

            //Act
            myList.Add(initial);

            //Assert
            Assert.AreEqual(expected, myList.Count);
        }
        [TestMethod]
        public void Add_CheckSecondValueAdd_ValueAtIndex1()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int value = 2;
            int secondValue = 15;

            //Act
            myList.Add(value);
            myList.Add(secondValue);

            //Assert
            Assert.AreEqual(secondValue, myList[1]);
        }
    }
}
