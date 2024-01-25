using NUnit.Framework;
using NUnit.Framework.Legacy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_SelectionSort_SSuleman
{
    internal class Program
    {
        
        public static void SelectionSort(int[] arr)
        {
            // Get the length of the input array
            int arrayLength = arr.Length;

            // Iterate through the array
            for (int currentIndex = 0; currentIndex < arrayLength - 1; currentIndex++)
            {
                // Assume the current index as the minimum
                int minIndex = currentIndex;

                // To find the minimum element in the remaining unsorted array 
                //lets use for loop,
                for (int unsortedIndex = currentIndex + 1; unsortedIndex < arrayLength; unsortedIndex++)
                {
                    // If the current element is smaller than the minimum element,
                    // update the min index
                    if (arr[unsortedIndex] < arr[minIndex])
                    {
                        minIndex = unsortedIndex;
                    }
                }
                
                int temp = arr[minIndex];
                arr[minIndex] = arr[currentIndex];
                arr[currentIndex] = temp;

            }

        }
        public static void Main(string[] args)
        {
            // Create an array of integers
            int[] arr = new int[] { 9, 7, 2, 15, 6, 4,10, 11 };

            // Print the array before sorting
            Console.WriteLine("Array before sorting:");
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            // Call the SelectionSort method on the array
            SelectionSort(arr);

            // Print the array after sorting
            Console.WriteLine("Array after sorting:");
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}
