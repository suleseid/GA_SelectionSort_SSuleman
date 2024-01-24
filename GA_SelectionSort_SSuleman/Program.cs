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
                // Swap the found minimum element with the element at the current index.
                // This will move the minimum element to the sorted part of the array.
                int temp = arr[minIndex];
                arr[minIndex] = arr[currentIndex];
                arr[currentIndex] = temp;
            }
        }

    }
}
