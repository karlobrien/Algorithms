using System;
using System.Collections.Generic;

namespace Algos
{

    public struct Data : IData
    {
        public long Close { get; set; }
    }

    public interface IData
    {
        long Close { get; set; }
    }

    /// <summary>
    /// Merge Sort
    /// Takes an array of numbers and sorts
    /// Best Case: O(n log n)
    /// Worst Case O(n log n)
    /// Average Case O(n log n)
    /// </summary>
    public static class MergeSortGeneric<T> where T : IData
    {
        public static T[] Sort(T[] numbers)
        {
            return MergeSort(numbers, 0, numbers.Length - 1);
        }

        private static T[] MergeSort(T[] numbers, int low, int high)
        {
            if (low < high)
            {
                int middle = (low / 2) + (high /2);
                MergeSort(numbers, low, middle);
                MergeSort(numbers, middle+1, high);
                return Merge(numbers, low, middle, high);
            }
            else{
                return numbers;
            }
        }

        private static T[] Merge(T[] input, int low, int middle, int high)
        {
            int left = low;
            int right = middle + 1;
            T[] tmp = new T[(high - low) + 1];
            int tmpIndex = 0;

            while ((left <= middle) && (right <= high))
            {
                if (input[left].Close < input[right].Close)
                {
                    tmp[tmpIndex] = input[left];
                    left = left + 1;
                }
                else
                {
                    tmp[tmpIndex] = input[right];
                    right = right + 1;
                }
                tmpIndex = tmpIndex + 1;
            }

            if (left <= middle)
            {
                while (left <= middle)
                {
                    tmp[tmpIndex] = input[left];
                    left = left + 1;
                    tmpIndex = tmpIndex + 1;
                }
            }

            if (right <= high)
            {
                while (right <= high)
                {
                    tmp[tmpIndex] = input[right];
                    right = right + 1;
                    tmpIndex = tmpIndex + 1;
                }
            }

            for (int i = 0; i < tmp.Length; i++)
            {
                input[low + i] = tmp[i];
            }

            return input;
        }

    }
}