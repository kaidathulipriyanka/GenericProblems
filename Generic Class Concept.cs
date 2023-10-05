using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GenericsPracticeProblems.DeleteELeFromArrayUseGenMethod;

namespace GenericsPracticeProblems
{
    internal class Generic_Class_Concept
    {
        public void Generic_class()
        {
            {
                // Sample array containing integers, doubles, and characters
                object[] mixedArray = { 10, 3.14, 'A', 20, 'B', 3.14, 'C', 30, 'D' };

                // Element to delete (you can change this as needed)
                object elementToDelete = 3.14;

                // Create a DeleteArray instance with the mixedArray
                var deleteArray = new DeleteArray<object>(mixedArray);

                // Call DeleteMethod to remove the specified element
                mixedArray = deleteArray.DeleteMethod(elementToDelete);

                // Print the updated array
                deleteArray.PrintArray(mixedArray);
            }
        }
    }

    public class DeleteArray<T>
    {
        private T[] inputArray;

        public DeleteArray(T[] array)
        {
            inputArray = array;
        }

        public T[] DeleteMethod(T elementToDelete)
        {
            // Use LINQ to filter out the elements to be deleted
            var resultArray = inputArray.Where(element => !element.Equals(elementToDelete)).ToArray();

            return resultArray;
        }

        public void PrintArray(T[] array)
        {
            Console.WriteLine("Array after deleting element: ");
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}

