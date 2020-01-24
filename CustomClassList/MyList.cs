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
        int Count;
        int Capacity;

        //Constructor
        public MyList()
        {
            items = new T[Capacity];
            Capacity = 4;
        }

        //Member Methods (CAN DO)
        public void Add(T item)
        {
            MakeNewArray(Capacity);

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
        }
        public void IncreaseCount()
        {
            Count += 1;
        }
        public void DecreaseCount()
        {
            Count -= 1;
        }
        public void CapacityCheck()
        {
            if (Count > Capacity)
            {
                DoubleCapacity();
            }  
        }
        public int DoubleCapacity()
        {
            int newCapacity = Capacity * 2;
            Capacity = newCapacity;
            return Capacity;
        }
        public void MakeNewArray(int Capacity)
        {
            T[] tempitems;
            tempitems = new T[Capacity];
            foreach (T item in items)
            {
                
         
            }
        }

    }
}
