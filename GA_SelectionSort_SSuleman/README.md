Guided Assignment - Implementing Selection Sort in C#
Introduction
Selection Sort is a fundamental sorting algorithm known for its simplicity and ease of implementation. It works by repeatedly selecting the minimum element from the unsorted section of an array and placing it at the beginning. This process is repeated until the entire array is sorted.


Detailed Requirements
Project Setup:

Create a new console application in your IDE.
Name the project GA_SelectionSort_Suleman Seid .
Add a comment on the main page of your program with your name.
Understanding of Selection Sort Algorithm (15 Points):

1A. Write pseudo-code explaining the Selection Sort algorithm.
Answer;-
=> procedure selectionSort(arr: List of Comparable)
    // Get the length of the input array
    arrayLength = length(arr)

    // Iterate through the array
    for currentIndex from 0 to arrayLength - 1
        // Assume the current index as the minimum
        minIndex = currentIndex

        // Find the minimum element in the remaining unsorted array
        for unsortedIndex from currentIndex + 1 to arrayLength - 1
            if arr[unsortedIndex] < arr[minIndex]
                minIndex = unsortedIndex
        end for

        // Swap the found minimum element with the element at the current index
        swap arr[currentIndex] and arr[minIndex]
    end for
end procedur


1B.Describe the process of selecting the minimum element and moving it to the beginning of the array.
=> The selection sort algorithm works by repeatedly finding the smallest (or largest)
element in the unsorted part of the array and swapping it with the first element of that part.
This way, the sorted part of the array grows from the left to the right, while 
the unsorted part shrinks from the right to the left. For example, 
if we have an array of numbers [64, 25, 12, 22, 11], the algorithm will perform the following steps:

=>In the first iteration, the algorithm will scan the whole array and find the minimum element, which is 11.
It will swap 11 with the first element, which is 64. 
The array will become [11, 25, 12, 22, 64]. The first element is now sorted and the rest of the array is unsorted.

=>In the second iteration, the algorithm will scan the unsorted part of the array, which is [25, 12, 22, 64], 
and find the minimum element, which is 12. It will swap 12 with the first element of the unsorted part, which is 25. 
The array will become [11, 12, 25, 22, 64]. The first two elements are now sorted and the rest of the array is unsorted.

=>In the third iteration, the algorithm will scan the unsorted part of the array, which is [25, 22, 64], 
and find the minimum element, which is 22. It will swap 22 with the first element of the unsorted part, which is 25.
The array will become [11, 12, 22, 25, 64]. The first three elements are now sorted and the rest of the array is unsorted.

=>In the fourth iteration, the algorithm will scan the unsorted part of the array, which is [25, 64], 
and find the minimum element, which is 25. It will swap 25 with the first element of the unsorted part, which is 25. 
The array will become [11, 12, 22, 25, 64]. The first four elements are now sorted and the rest of the array is unsorted.

=>In the fifth iteration, the algorithm will scan the unsorted part of the array, which is [64], 
and find the minimum element, which is 64. It will swap 64 with the first element of the unsorted part, which is 64. 
The array will become [11, 12, 22, 25, 64]. The whole array is now sorted and the algorithm is done.


1C.Explain the significance of finding the minimum element in each iteration.

=>Finding the minimum element in each iteration ensures that 
the sorted part of the array is always in ascending order. 
By swapping the minimum element with the first element of the unsorted part, 
the algorithm maintains the invariant that the elements to the left of the current index are sorted 
and the elements to the right of the current index are unsorted. This way, the algorithm can sort the array in place, without using any extra space.

1D.Implementation of Selection Sort (15 Points):
public static void SelectionSort(int[] arr)
{
    // Get the length of the input array
    int arrayLength = arr.Length;

    // Iterate through the array
    for (int currentIndex = 0; currentIndex < arrayLength - 1; currentIndex++)
    {
        // Assume the current index as the minimum
        int minIndex = currentIndex;

        // Find the minimum element in the remaining unsorted array
        for (int unsortedIndex = currentIndex + 1; unsortedIndex < arrayLength; unsortedIndex++)
        {
            // If the current element is smaller than the minimum element, update the min index
            if (arr[unsortedIndex] < arr[minIndex])
            {
                minIndex = unsortedIndex;
            }
        }

        // Swap the found minimum element with the element at the current index
        int temp = arr[minIndex];
        arr[minIndex] = arr[currentIndex];
        arr[currentIndex] = temp;
    }
}

Implement the Selection Sort algorithm in C#.
Ensure your code adheres to the provided algorithm.
Include clear comments explaining each step of the code.
Explanation of Algorithm Logic (15 Points):

3.A Provide comments detailing:
The purpose of the outer loop and the inner loop.

=>The purpose of the outer loop and the inner loop. 
The outer loop iterates through the array from the first element to the second last element.
For each iteration, the outer loop sets the current index as the minimum index 
and calls the inner loop to find the actual minimum element 
in the unsorted part of the array. 
The inner loop iterates through the array from the current index plus one to the last element. 
For each iteration, the inner loop compares the current element with the minimum element 
and updates the minimum index if the current element is smaller.

3.B The process of finding the minimum element.

=>The process of finding the minimum element is done by the inner loop. 
The inner loop starts with the minimum index as the current index 
and compares each element in the unsorted part of the array with the minimum element. 
If the current element is smaller than the minimum element,
the minimum index is updated to the current index. 
This way, the inner loop keeps track of the smallest element in the unsorted part of the array.

3C. How the algorithm maintains the sorted and unsorted portions of the array.

=>The algorithm maintains the sorted and unsorted portions of the array 
by swapping the minimum element with the element at the current index. 
This way, the minimum element is moved to the sorted part of the array, 
while the element at the current index is moved to the unsorted part of the array. 
The sorted part of the array grows from the left to the right, 
while the unsorted part of the array shrinks from the right to the left.

3D. Implementing Efficient Sorting Technique (15 Points):
Implement conditions to optimize sorting efficiency using Selection Sort.

=>One possible condition to optimize sorting efficiency 
using Selection Sort is to check if the minimum index is different from the current index 
before swapping the elements. 
This will avoid unnecessary swaps when the minimum element is already at the correct position.
For example, We can modify the code as follows:
public static void SelectionSort(int[] arr)
{
    // Get the length of the input array
    int arrayLength = arr.Length;

    // Iterate through the array
    for (int currentIndex = 0; currentIndex < arrayLength - 1; currentIndex++)
    {
        // Assume the current index as the minimum
        int minIndex = currentIndex;

        // Find the minimum element in the remaining unsorted array
        for (int unsortedIndex = currentIndex + 1; unsortedIndex < arrayLength; unsortedIndex++)
        {
            // If the current element is smaller than the minimum element, update the min index
            if (arr[unsortedIndex] < arr[minIndex])
            {
                minIndex = unsortedIndex;
            }
        }

        // Swap the found minimum element with the element at the current index
        // Only if the min index is different from






