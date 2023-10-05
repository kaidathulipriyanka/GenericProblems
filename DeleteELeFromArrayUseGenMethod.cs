using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsPracticeProblems
{
    internal class DeleteELeFromArrayUseGenMethod
    {
        public void DeleteELeFromArray_UseGenMethod()
        {
            int[] intArray = { 1, 2, 3, 4, 5 };
            double[] doubleArray = { 1.1, 2.2, 3.3, 4.4, 5.5 };
            char[] charArray = { 'A', 'B', 'C', 'D', 'E' };

            int[] resultIntArray = DeleteArray<int>.DeleteMethod(intArray, 3);
            double[] resultDoubleArray = DeleteArray<double>.DeleteMethod(doubleArray, 2.2);
            char[] resultCharArray = DeleteArray<char>.DeleteMethod(charArray, 'C');

            Console.WriteLine("Integer Array after deletion:");
            foreach (var item in resultIntArray)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nDouble Array after deletion:");
            foreach (var item in resultDoubleArray)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nCharacter Array after deletion:");
            foreach (var item in resultCharArray)
            {
                Console.WriteLine(item);
            }
        }
            public class DeleteArray<T>
        {
            public static T[] DeleteMethod(T[] inputArray, T elementToDelete)
            {
                int indexToDelete = -1;

                // Find the index of the element to delete
                for (int i = 0; i < inputArray.Length; i++)
                {
                    if (inputArray[i].Equals(elementToDelete))
                    {
                        indexToDelete = i;
                        break;
                    }
                }

                if (indexToDelete == -1)
                {
                    // Element not found, return the original array
                    return inputArray;
                }
                else
                {
                    // Create a new array with one less element
                    T[] newArray = new T[inputArray.Length - 1];

                    // Copy elements before the element to delete
                    for (int i = 0; i < indexToDelete; i++)
                    {
                        newArray[i] = inputArray[i];
                    }

                    // Copy elements after the element to delete
                    for (int i = indexToDelete + 1; i < inputArray.Length; i++)
                    {
                        newArray[i - 1] = inputArray[i];
                    }

                    return newArray;
                }
            }
        }


    }
}

