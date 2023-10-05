using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsPracticeProblems
{
    public class FindMinfloat
    {
        public void Find_Min_float()
        {

            float float1 = 3.14f;
            float float2 = 2.71f;
            float float3 = 1.618f;

            float minimumFloat = FindMinimum(float1, float2, float3);

            Console.WriteLine("Minimum float: " + minimumFloat);
        }
        public static T FindMinimum<T>(T value1, T value2, T value3) where T : IComparable<T>
        {
            if (value1.CompareTo(value2) <= 0 && value1.CompareTo(value3) <= 0)
            {
                return value1;
            }
            else if (value2.CompareTo(value1) <= 0 && value2.CompareTo(value3) <= 0)
            {
                return value2;
            }
            else
            {
                return value3;
            }
          }

     }   
}
