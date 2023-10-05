using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsPracticeProblems
{
    internal class findMinstring
    {
        public void Find_Min_String()
        {

            string string1 = "apple";
            string string2 = "banana";
            string string3 = "cherry";

            MinimumFinder<string> finder = new MinimumFinder<string>();

            string minimum = finder.FindMinimum(string1, string2, string3);

            Console.WriteLine("The minimum string is: " + minimum);
        }
        public class MinimumFinder<T> where T : IComparable<T>
        {
            public T FindMinimum(T value1, T value2, T value3)
            {
                T minimum = value1;

                if (value2.CompareTo(minimum) < 0)
                {
                    minimum = value2;
                }

                if (value3.CompareTo(minimum) < 0)
                {
                    minimum = value3;
                }

                return minimum;
            }
        }
    }
}   