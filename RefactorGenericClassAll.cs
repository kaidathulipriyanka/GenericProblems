using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;  

namespace GenericsPracticeProblems
{
    internal class RefactorGenericClassAll
    {
        public void  Refactor_GenericClassAll() {
            int minValue = new MinMax<int>(10, 5, 20).FindMinimum();
            double minDouble = new MinMax<double>(3.14, 2.71, 1.618).FindMinimum();
            string minString = new MinMax<string>("apple", "banana", "cherry").FindMinimum();

            Console.WriteLine($"Minimum int: {minValue}");
            Console.WriteLine($"Minimum double: {minDouble}");
            Console.WriteLine($"Minimum string: {minString}");
        }

        public class MinMax<T> where T : IComparable<T>
        {
            private T value1;
            private T value2;
            private T value3;

            public MinMax(T v1, T v2, T v3)
            {
                value1 = v1;
                value2 = v2;
                value3 = v3;
            }

            public T FindMinimum()
            {
                return Minimum(value1, value2, value3);
            }

            private static T Minimum(T a, T b, T c)
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
 }
