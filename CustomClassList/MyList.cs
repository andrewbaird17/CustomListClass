using System;
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
        public int Count;
        public int Capacity;
        public int nextIndex;

        //Constructor
        public MyList()
        {
            items = new T[Capacity];
            Count = 0;
        }

        //Member Methods (CAN DO)
        public void Add(T item)
        {
            IncreaseCount();
            CapacityCheck();


        }
        public T this[int index]
        {
            get
            {
                return this[index];
            }
            set
            {
                this[index] = value;
            }
        }

        public void CapacityCheck()
        {
            if (Count > Capacity)
            {
                IncreaseCapacity();
                T[] tempitems = MakeTempArray();
                CombineTempAndOldArray();
            }
        }
        public T[] MakeTempArray()
        {
            tempitems = new T[Capacity];
            for (int i = 0; i < Capacity; i++)
            {
                tempitems[i] = item;
            }
            return tempitems;
        }
        public void CombineTempAndOldArray()
        {
            for (int i = 0; i < Count; i++)
            {
                tempitems[i] = items[i];
            }
            items = tempitems;
        }
        public void IncreaseCapacity()
        {
            if (Capacity == 0)
            {
                MakeInitialArray();
                int newCapacity = 4;
                Capacity = newCapacity;
            }
            else
            {
                int newCapacity = Capacity * 2;
                Capacity = newCapacity;
            }
        }
        public void MakeInitialArray()
        {
            Capacity = 1;
            items = new T[Capacity];
            items[nextIndex] = item;
        }
        public void IncreaseCount()
        {
            Count += 1;
        }
        public void DecreaseCount()
        {
            Count -= 1;
        }
    }
}
