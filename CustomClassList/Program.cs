using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomClassList
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> one = new MyList<int>() { 1, 3, 5, 7 };
            MyList<int> two = new MyList<int>() { 2, 4, 6, 8 };
            

            //Act
            MyList<int> result = one + two;

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }

    }
}
