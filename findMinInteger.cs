using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;  

namespace GenericsPracticeProblems
{
    internal class findMinInteger
    {
        public void find_Min_Integer() {

            int num1 = 10;
            int num2 = 5;
            int num3 = 8;

            MinimumFinder<int> finder = new MinimumFinder<int>();
            int minimum = finder.FindMinimum(num1, num2, num3);

            Console.WriteLine("The minimum value is: " + minimum);
        }
    }
    public class MinimumFinder<T> where T : IComparable<T>
    {
        public T FindMinimum(T a, T b, T c)
        {
            T min = a;

            if (b.CompareTo(min) < 0)
            {
                min = b;
            }

            if (c.CompareTo(min) < 0)
            {
                min = c;
            }

            return min;
        }
    }

}
   
