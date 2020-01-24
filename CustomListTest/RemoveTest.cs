using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomClassList;

namespace CustomListTest
{
    //[TestClass]
    //public class RemoveTest
    //{
    //    [TestMethod]
    //    public void Remove_RemoveOnlyItem_CapacityStays4()
    //    {
    //        //Arrange
    //        MyList<int> myList = new MyList<int>();
    //        int value = 5;
    //        int actual;
    //        int expected = 4;

    //        //Act
    //        myList.Add(value);
    //        myList.Remove(value);
    //        actual = myList.Capacity;

    //        //Assert
    //        Assert.AreEqual(expected, actual);
    //    }

    //    [TestMethod]
    //    public void Remove_RemoveValue0_CountStays1()
    //    {
    //        //Arrange
    //        MyList<int> myList = new MyList<int>();
    //        int value = 5;
    //        int valueRemove = 0;
    //        int actual;
    //        int expected = 1;

    //        //Act
    //        myList.Add(value);
    //        myList.Remove(valueRemove);
    //        actual = myList.Count;

    //        //Assert
    //        Assert.AreEqual(expected, actual);
    //    }

    //    [TestMethod]
    //    public void Remove_TakeFirstItemOutOfTwo_SecondItemMovesToIndex0()
    //    {
    //        //Arrange
    //        MyList<int> myList = new MyList<int>();
    //        int value1 = 5;
    //        int value2 = 10;
    //        int actual;
    //        int expected = 10;

    //        //Act
    //        myList.Add(value1);
    //        myList.Add(value2);
    //        myList.Remove(value1);
    //        actual = myList[0];

    //        //Assert
    //        Assert.AreEqual(expected, actual);
    //    }
    //    [TestMethod]
    //    public void Remove_RemoveThirdValueOutOf4_SecondValueStaysAtIndex1()
    //    {
    //        //Arrange
    //        MyList<int> myList = new MyList<int>();
    //        int value1 = 5;
    //        int value2 = 10;
    //        int value3 = 15;
    //        int value4 = 20;
    //        int actual;
    //        int expected = value2;

    //        //Act
    //        myList.Add(value1);
    //        myList.Add(value2);
    //        myList.Add(value3);
    //        myList.Add(value4);
    //        myList.Remove(value3);
    //        actual = myList[1];

    //        //Assert
    //        Assert.AreEqual(expected, actual);
    //    }

    //    [TestMethod]
    //    public void Remove_RemoveValueNotInList_CountStaysThree()
    //    {
    //        //Arrange
    //        MyList<int> myList = new MyList<int>();
    //        int value1 = 5;
    //        int value2 = 10;
    //        int value3 = 15;
    //        int valueRemove = 20;
    //        int actual;
    //        int expected = 3;

    //        //Act
    //        myList.Add(value1);
    //        myList.Add(value2);
    //        myList.Add(value3);
    //        myList.Remove(valueRemove);
    //        actual = myList.Count;

    //        //Assert
    //        Assert.AreEqual(expected, actual);
    //    }

    //    [TestMethod]
    //    public void Remove_OnlyRemoveTheFirstInstanceOfAValue_SecondInstanceOfValueStaysAndShiftedDowntoIndex2()
    //    {
    //        //Arrange
    //        MyList<string> myList = new MyList<string>();
    //        string value = "word";
    //        string value0 = "brick";
    //        string value1 = "rocks";
    //        string value2 = "snow";
    //        string expected = value;
    //        string actual;

    //        //Act
    //        myList.Add(value0);
    //        myList.Add(value);
    //        myList.Add(value1);
    //        myList.Add(value);
    //        myList.Add(value2);
    //        myList.Remove(value);
    //        actual = myList[2];

    //        //Assert
    //        Assert.AreEqual(expected, actual);
    //    }

    //    [TestMethod]
    //    public void Remove_OnlyRemoveTheFirstInstanceOfAValue_CountDecreasesByOneTo4()
    //    {
    //        //Arrange
    //        MyList<string> myList = new MyList<string>();
    //        string value = "word";
    //        string value0 = "brick";
    //        string value1 = "rocks";
    //        string value2 = "snow";
    //        int expected = 4;
    //        int actual;

    //        //Act
    //        myList.Add(value0);
    //        myList.Add(value);
    //        myList.Add(value1);
    //        myList.Add(value);
    //        myList.Add(value2);
    //        myList.Remove(value);
    //        actual = myList.Count;

    //        //Assert
    //        Assert.AreEqual(expected, actual);
    //    }
    //}
}
