using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomClassList;

namespace CustomListTest
{
    [TestClass]
    public class RemoveTest
    {
        [TestMethod]
        public void Remove_RemoveOnlyItemValue0_CapacityStays4()
        {
            //Arrange
            MyList<int> myList = new MyList<int>();
            int value = 5;
            int valueRemove = 0;
            int actual;
            int expected = 4;

            //Act
            myList.Add(value);
            myList.Remove(valueRemove);
            actual = myList.Capacity;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_FirstItemOutOfTwo_SecondItemMovesToIndex0()
        {
            //Arrange
            MyList<int> myList = new MyList<int>();
            int value1 = 5;
            int value2 = 10;
            int actual;
            int expected = 10;

            //Act
            myList.Add(value1);
            myList.Add(value2);
            myList.Remove(value1);
            actual = myList[0];

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_LastValue()
        {
            //Arrange


            //Act


            //Assert

        }

        [TestMethod]
        public void Remove_RemoveValueNotInList_CountStaysTheSame()
        {
            //Arrange


            //Act


            //Assert
            
        }
    }
}
