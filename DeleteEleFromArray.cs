using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsPracticeProblems 
{
    internal class DeleteEleFromArray
    {
        public void Delete_Ele_FromArray() {
            object[] mixedArray = { 10, 20.5, 'A', 30, 40.5, 'B', 50, 60.5, 'C' };

            Console.WriteLine("Original Array:");
            PrintArray(mixedArray);

            mixedArray = DeleteElement(mixedArray, 20.5); // Delete 20.5 (double)
            mixedArray = DeleteElement(mixedArray, 'B');  // Delete 'B' (character)

            Console.WriteLine("\nArray after Deletion:");
            PrintArray(mixedArray);

            Console.ReadLine();
        }

        public static object[] DeleteElement(object[] array, object elementToDelete)
        {
            int newSize = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (!array[i].Equals(elementToDelete))
                {
                    newSize++;
                }
            }

            object[] newArray = new object[newSize];
            int newIndex = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (!array[i].Equals(elementToDelete))
                {
                    newArray[newIndex] = array[i];
                    newIndex++;
                }
            }

            return newArray;
        }

        public static void PrintArray(object[] array)
        {
            foreach (object element in array)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }
    }

}
  
