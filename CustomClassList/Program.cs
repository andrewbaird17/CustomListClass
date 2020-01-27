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
            string word;
            MyList<int> myList = new MyList<int>() { 1,2,3,4,5};
            foreach (int item in myList)
            {
               word = item.ToString();
               Console.WriteLine(word);
            }
            
            Console.ReadLine();
        }

    }
}
