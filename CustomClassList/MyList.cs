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
        T item;
        private int count;
        public int Count
        {
            get
            {
                return count;
            }
        }
        private int tempcapacity;
        public int Capacity
        {
            get
            {
                return tempcapacity;
            }
        }
        public int nextIndex;

        //Constructor
        public MyList()
        {
            items = new T[tempcapacity];
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
            if (count == tempcapacity)
            {
                IncreaseCapacity();
                MakeTempArray();
                CombineTempAndOldArray();
            }
        }
        public void MakeTempArray()
        {
            tempitems = new T[tempcapacity];
            for (int i = 0; i < tempcapacity; i++)
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
            if (tempcapacity == 0)
            {
                MakeInitialArray();
                int newCapacity = 4;
                tempcapacity = newCapacity;
            }
            else
            {
                int newCapacity = tempcapacity * 2;
                tempcapacity = newCapacity;
            }
        }
        public void ItemAddedToNextIndexSpot(T input)
        {
            items[nextIndex] = input;
            nextIndex += 1;
        }
        public void MakeInitialArray()
        {
            tempcapacity = 1;
            items = new T[tempcapacity];
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
        public override string ToString()
        {
            StringBuilder stringbuilder = new StringBuilder();
            for (int i = 0; i < count; i++)
            {
                stringbuilder.Append(items[i]);
            }
            string stringList = stringbuilder.ToString();
            return stringList;
        }

        // Member Overload "+" Method
        public static MyList<T> operator +(MyList<T> one, MyList<T> two)
        {
            MyList<T> comboList = new MyList<T>();
            foreach (T unit in one)
            {
                comboList.Add(unit);
            }
            foreach (T unit in two)
            {
                comboList.Add(unit);
            }
            // return combined list
            return comboList;
        }

        // Member Overload "-" Method
        public static MyList<T> operator -(MyList<T> one, MyList<T> two)
        {
            MyList<T> comboList = new MyList<T>();

            foreach (T unit in one)
            {
                comboList.Add(unit);
            }
            foreach (T unit in two)
            {
                bool removed = false;
                bool inArray = comboList.CheckIfValueInArray(unit, removed);
                if (inArray == true)
                {
                    comboList.Remove(unit);
                }
            }
            return comboList;
        }

        //Member Zip Method
        public MyList<T> Zip(MyList<T> list)
        {
            MyList<T> zipList = new MyList<T>();
            for (int i = 0; i < count; i++)
            {
                if (i < list.count)
                {
                    zipList.Add(items[i]);
                    zipList.Add(list[i]);
                }
                else
                {
                    break;
                }
            }
            return zipList;
        }

        // Member Sort Method Using Quick Sort
        //public MyList<T> Sort()
        //{
        //    MyList<T> sortedList = new MyList<T>();

        //    return sortedList;
        //}

        //// Quick Sort Algorithm(Take in list, left (smallest index), right (highest index))
        //public static void Quick_Sort(MyList<T> list, int low, int high)
        //{
        //    if (low < high)
        //    {
        //        int pivot = Partition(list, low, high);

        //        if (pivot > 1)
        //        {
        //            Quick_Sort(list, low, pivot - 1);
        //        }
        //        if (pivot + 1 < high)
        //        {
        //            Quick_Sort(list, pivot + 1, high);
        //        }
        //    }
        //}
        //public static int Partition(MyList<T> list, int low, int high)
        //{
        //    int pivot = list[low];

        //    return pivot;
        //}

}
}
