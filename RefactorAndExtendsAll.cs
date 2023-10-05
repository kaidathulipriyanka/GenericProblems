using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsPracticeProblems
{
    public class RefactorAndExtendsAll
    {
        public void Refactor_And_ExtendsAll() {

            int minInt = FindMin(5, 2, 7);
            Console.WriteLine("Minimum of three integers: " + minInt);

            // Find minimum of three floats
            float minFloat = FindMin(3.14f, 2.71f, 1.618f);
            Console.WriteLine("Minimum of three floats: " + minFloat);

            // Find minimum of three strings
            string minString = FindMin("apple", "banana", "cherry");
            Console.WriteLine("Minimum of three strings: " + minString);
        }
    
            public static T FindMin<T>(T a, T b, T c) where T : IComparable<T>
            {
                if (a.CompareTo(b) <= 0 && a.CompareTo(c) <= 0)
                {
                    return a;
                }
                else if (b.CompareTo(a) <= 0 && b.CompareTo(c) <= 0)
                {
                    return b;
                }
                else
                {
                    return c;
                }
            }

        }  
 }
