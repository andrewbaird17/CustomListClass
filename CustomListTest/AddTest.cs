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
            MyList<int> myList = new MyList<int>();
            int expected = 2;
            int actual;

            //Act
            myList.Add(2);
            actual = myList[0];

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_CheckCountAfterAdding_CountIs1()
        {
            //Arrange
            MyList<int> myList = new MyList<int>();
            int initial= 2;
            int expected = 1;
            int actual;

            //Act
            myList.Add(initial);
            actual = myList.Count;
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_CheckSecondValueAdd_ValueAtIndex1()
        {
            //Arrange
            MyList<int> myList = new MyList<int>();
            int value = 2;
            int secondValue = 15;
            int actual;

            //Act
            myList.Add(value);
            myList.Add(secondValue);
            actual = myList[1]; 

            //Assert
            Assert.AreEqual(secondValue, actual);
        }
        [TestMethod]
        public void Add_CheckMultipleValuesAdd_ValueAtIndex2()
        {
            //Arrange
            MyList<string> myList = new MyList<string>();
            string value0 = "word";
            string value1 = "work";
            string value2 = "powerpoint";
            string value3 = "excel";
            string actual;

            //Act
            myList.Add(value0); 
            myList.Add(value1);
            myList.Add(value2);
            myList.Add(value3);
            actual = myList[2];

            //Assert
            Assert.AreEqual(value2, actual);
        }

        [TestMethod]
        public void Add_SameValueAddedMultipleTimes_ValueWasAddedAtLastIndex()
        {
            //Arrange
            MyList<string> myList = new MyList<string>();
            string value0 = "word";
            string actual;

            //Act
            myList.Add(value0);
            myList.Add(value0);
            myList.Add(value0);
            myList.Add(value0);
            myList.Add(value0);
            actual = myList[4];

            //Act
            Assert.AreEqual(value0, actual);
        }

        [TestMethod]
        public void Add_MultipleValuesAdded_CapacityIncreases()
        {
            //Arrange
            MyList<string> myList = new MyList<string>();
            string value0 = "word";
            string value1 = "work";
            string value2 = "powerpoint";
            string value3 = "excel";
            string value4 = "chrome";
            int actual;
            int expected = 8;

            //Act
            myList.Add(value0);
            myList.Add(value1);
            myList.Add(value2);
            myList.Add(value3);
            myList.Add(value4);
            actual = myList.Capacity;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_AddAValue_Capacityis4()
        {
            //Arrange 
            MyList<string> myList = new MyList<string>();
            string value = "Word";
            int actual;
            int expected = 4;

            //Act 
            myList.Add(value);
            actual = myList.Capacity;

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
