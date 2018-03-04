using System;
using System.Collections.Generic;

namespace Algos
{
    /// <summary>
    /// Best Case O(nlogn)
    /// Sort a nearly sorted array
    /// Find k largest or smallest elements in array
    /// Heapsort can be used in time-critical applications because Worst case time complexity of Heapsort is better than Quicksort, so it is guaranteed with Heapsort that the time won't grow more than nLogn.
    ///
    /// </summary>
    public static class HeapSortByValue
    {
        public static int[] HeapSort(int[] numbers)
        {
            // Build our max heap.
            BuildMaxHeap(numbers);

            // Find last element.
            var lastElement = numbers.Length - 1;

            // Continue heap sorting until we have
            // just one element left in the array.
            while(lastElement > 0) {
                Swap(numbers, 0, lastElement);

                Heapify(numbers, lastElement, 0);

                lastElement--;
            }
            return numbers;
        }

        public static int[] BuildMaxHeap(int[] numbers)
        {
            var i = numbers.Length / 2 - 1;
            while (i >= 0)
            {
                Heapify(numbers, numbers.Length, i);
                i--;
            }
            //Console.WriteLine($"Max: {numbers[9]}");
            return numbers;
        }
        //Build the heap - heapify
        private static void Heapify(int[] numbers, int max, int i)
        {
            int largest, leftChild, righChild;

            while (i < max)
            {
                largest = i;
                leftChild = 2 * i + 1;
                righChild = 2 * i + 2;

                 //Check left is root
                if (leftChild < max && numbers[leftChild] > numbers[largest])
                    largest = leftChild;

                if (righChild < max && numbers[righChild] > numbers[largest])
                    largest = righChild;

                if (largest == i)
                    return;

                Swap(numbers, i, largest);
                i = largest;

            }
        }

        private static void Swap(int[] numbers, int x, int y)
        {
            int temp = numbers[x];
            numbers[x] = numbers[y];
            numbers[y] = temp;
        }

        //Then remove one item from the heap and continue
    }
}