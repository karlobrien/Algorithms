using System;
using System.Collections.Generic;

namespace Algos
{
    /// <summary>
    /// Quick Sort
    /// Best Case: O(n log n)
    /// Worst Case O(n^2)
    /// Average Case O(n log n)
    /// </summary>
    public static class QuickSortByValue
    {
        public static int[] Sort(int[] numbers)
        {
            if (numbers.Length <= 1)
                return numbers;

            List<int> less = new List<int>();
            List<int> pivotList = new List<int>();
            List<int> more = new List<int>();
            int partition = numbers[numbers.Length-1];

            for(int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > partition)
                    more.Add(numbers[i]);
                else if (numbers[i] < partition)
                    less.Add(numbers[i]);
                else
                    pivotList.Add(numbers[i]);
            }

            var lessArray = Sort(less.ToArray());
            var moreArray = Sort(more.ToArray());
            var pivotArray = pivotList.ToArray();

            int[] result = new int[lessArray.Length + moreArray.Length + pivotArray.Length];
            Array.Copy(lessArray, result, lessArray.Length);
            Array.Copy(pivotArray, 0, result, lessArray.Length, pivotArray.Length);
            Array.Copy(moreArray, 0, result, lessArray.Length + pivotArray.Length, moreArray.Length);

            return result;
        }
    }

    public static class QuickSortSegwick
    {
        /*
        QUICKSORT (A, p, r)
        if p < r
            q = PARTITION(A, p, r)
            QUICKSORT(A, p, q-1)
            QUICKSORT(A, q+1, r)

        PARTITION(A, p, r)
        x=A[r]
        i=p-1
        for j = p to r - 1
        if A <= x
            i = i + 1
            exchange A[i] with A[j]
        exchange A[i+1] with A[r]
        return i + 1
         */

        public static int[] QuickSort(int[] numbers, int low, int high)
        {
            int pivot_loc = 0;
            if (low < high)
            {
                pivot_loc = Partition(numbers, low, high);
                QuickSort(numbers, low, pivot_loc - 1);
                QuickSort(numbers, pivot_loc + 1, high);
            }

            return numbers;
        }

        private static int Partition(int[] numbers, int low, int high)
        {
            int pivot = numbers[high];
            int i = low - 1;
            for(int j = low; j < high; j ++)
            {
                if (numbers[j] < pivot)
                {
                    i++;
                    Swap(numbers, i, j);
                }
            }
            Swap(numbers, i+1, high);
            return i + 1;
        }

        private static void Swap(int[] items, int a, int b)
        {
            int temp = items[a];
            items[a] = items[b];
            items[b] = temp;
        }
    }


    public static class QuickSortByStruct
    {
        public static MarketDataStruct[] QuickSort(MarketDataStruct[] numbers, int low, int high)
        {
            int pivot_loc = 0;
            if (low < high)
            {
                pivot_loc = Partition(numbers, low, high);
                QuickSort(numbers, low, pivot_loc - 1);
                QuickSort(numbers, pivot_loc + 1, high);
            }

            return numbers;
        }

        private static int Partition(MarketDataStruct[] numbers, int low, int high)
        {
            var pivot = numbers[high];
            int i = low - 1;
            for(int j = low; j < high; j ++)
            {
                if (numbers[j].Close < pivot.Close)
                {
                    i++;
                    Swap(numbers, i, j);
                }
            }
            Swap(numbers, i+1, high);
            return i + 1;
        }

        private static void Swap(MarketDataStruct[] items, int a, int b)
        {
            var temp = items[a];
            items[a] = items[b];
            items[b] = temp;
        }
    }

    public static class QuickSortByRefence
    {
        public static MarketData[] Sort(MarketData[] numbers)
        {
            return numbers;
        }
    }

    public static class QuickSortGeneric<T>
    {
        public static T[] Sort(T[] numbers)
        {
            return numbers;
        }
    }
}