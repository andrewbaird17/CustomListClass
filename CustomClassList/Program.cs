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
            MyList<string> mixedList = new MyList<string>() { "is", "lets", "do", "more", "testing", "fun" };
            MyList<string> expectedList = new MyList<string>() { "do", "fun", "is", "lets", "more", "testing" };
            string expected = expectedList.ToString();

            //Act
            mixedList.Sort();
            string actual = mixedList.ToString();
        }

    }
}
