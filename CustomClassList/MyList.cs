using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomClassList
{
    public class MyList<T> : IEnumerable
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

        // Overall Member Methods
        public T this[int index]
        {
            get
            {
                if ((index < 0) || (index > count))
                {
                    throw new ArgumentOutOfRangeException("Not valid argument");
                }
                else
                {
                    return items[index];
                }
            }
            set
            {
                items[index] = value;
            }
        }
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return items[i];
            }
        }

        //Member Add Methods (CAN DO)
        public void Add(T input)
        {
            CapacityCheck();
            IncreaseCount();
            ItemAddedToNextIndexSpot(input);

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

        //Member Remove Methods (CAN DO)
        public bool Remove(T removeinput)
        {
            bool removed = false;
            removed = CheckIfValueInArray(removeinput, removed);
            CompareRemoved(removed, removeinput);
            return removed;
        }
        public bool CheckIfValueInArray(T removeinput, bool removed)
        {
            for (int i = 0; i < count; i++)
            {
                if (items[i].Equals(removeinput))
                {
                    removed = true;
                }
            }
            return removed;
        }
        public void CompareRemoved(bool removed, T removeinput)
        {
            if (removed == true)
            {
                RemoveItem(removeinput);
            }
        }
        public void RemoveItem(T removeinput)
        {
            int removeone = 0;
            for (int i = 0; i < count; i++)
            {
                if ((items[i].Equals(removeinput)) && removeone < 1)
                {
                    removeone += 1;
                    MakeTempArray();
                    CombineAndShiftArrayValues(i);
                    DecreaseCount();
                }
            }
        }
        public void CombineAndShiftArrayValues(int i)
        {
            int k = 0;
            for (int j = 0; j < count; j++)
            {
                if (i == j)
                {
                    k++;
                    j--;
                    i = -1;
                }
                else if (k == count)
                {
                    nextIndex -= 1;
                    break;
                }
                else
                {
                    tempitems[j] = items[k];
                    k++;
                }
            }
            items = tempitems;
        }
        public void DecreaseCount()
        {
            count -= 1;
        }

        // Member ToString Methods (CAN DO)
        public string TooString()
        {
            string stringList = "";
            foreach (T value in items)
            {
                value.ToString();
            }
            return stringList;
        }
    }
}
