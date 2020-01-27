﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomClassList
{
    public class MyList<T>
    {
        //Member Variables (HAS A)
        T[] items;
        T[] tempitems;
        public T item;
        private int count;
        public int Count
        {
            get
            {
                 return count;
            }
        }
        private int capacity;
        public int Capacity
        {
            get
            {
                return capacity;
            }
        }
        public int nextIndex;

        //Constructor
        public MyList()
        {
            items = new T[capacity];
            count = 0;
        }

        //Member Add Methods (CAN DO)
        public void Add(T input)
        {
            CapacityCheck();
            IncreaseCount();
            ItemAddedToNextIndexSpot(input);

        }
        public T this[int index]
        {
            get
            {
                return items[index];
            }
            set
            {
                items[index] = value;
            }
            //Throw the IndexOutofRange Error

        }
        public void CapacityCheck()
        {
            if (count == capacity)
            {
                IncreaseCapacity();
                MakeTempArray();
                CombineTempAndOldArray();
            }
        }
        public void MakeTempArray()
        {
            tempitems = new T[capacity];
            for (int i = 0; i < capacity; i++)
            {
                tempitems[i] = item;
            }
        }
        public void CombineTempAndOldArray()
        {
            for (int i = 0; i < count; i++)
            {
                tempitems[i] = items[i];
            }
            items = tempitems;
        }
        public void IncreaseCapacity()
        {
            if (capacity == 0)
            {
                MakeInitialArray();
                int newCapacity = 4;
                capacity = newCapacity;
            }
            else
            {
                int newCapacity = capacity * 2;
                capacity = newCapacity;
            }
        }
        public void ItemAddedToNextIndexSpot(T input)
        {
            items[nextIndex] = input;
            nextIndex += 1;
        }
        public void MakeInitialArray()
        {
            capacity = 1;
            items = new T[capacity];
            items[nextIndex] = item;
        }
        public void IncreaseCount()
        {
            count += 1;
        }
        public void DecreaseCount()
        {
            count -= 1;
        }

        //Member Remove Methods (CAN DO)
        public void Remove(T input)
        {
            // Actually Remove an item from array
            // Don't decrease count if value not in array

            try
            {

            }
            catch (IndexOutOfRangeException)
            { 
                Console.WriteLine($"Error: Index out of Range, Try again with a value between 0 and {this.Count - 1}");
            }


        }
        public void ValueNotInArrayCountStaysSame()
        {
            
        }
        public void TakeItemOutAtCertainIndex()
        {

        }
    }
}
