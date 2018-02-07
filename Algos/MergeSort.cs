using System;
using System.Collections.Generic;

namespace Algos
{
    public class MarketData
	{
		public int Close { get;set; }
	}

	public struct MarketDataStruct
	{
		public int Close;
	}

    /// <summary>
    /// Merge Sort
    /// Takes an array of numbers and sorts
    /// Best Case: O(n log n)
    /// Worst Case O(n log n)
    /// Average Case O(n log n)
    /// </summary>
    public static class MergeSort
    {
        public static int[] Sort(int[] numbers)
        {
            return MergeSortMe(numbers, 0, numbers.Length - 1);
        }

        private static int[] MergeSortMe(int[] numbers, int low, int high)
        {
            if (low < high)
            {
                int middle = (low / 2) + (high /2);
                MergeSortMe(numbers, low, middle);
                MergeSortMe(numbers, middle+1, high);
                return Merge(numbers, low, middle, high);
            }
            else{
                return numbers;
            }
        }

        private static int[] Merge(int[] input, int low, int middle, int high)
        {
            int left = low;
            int right = middle + 1;
            int[] tmp = new int[(high - low) + 1];
            int tmpIndex = 0;

            while ((left <= middle) && (right <= high))
            {
                if (input[left] < input[right])
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

        /// <summary>
        /// Object implementation
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        public static MarketData[] Sort(MarketData[] numbers)
        {
            return MergeSortMe(numbers, 0, numbers.Length - 1);
        }

        private static MarketData[] MergeSortMe(MarketData[] numbers, int low, int high)
        {
            if (low < high)
            {
                int middle = (low / 2) + (high /2);
                MergeSortMe(numbers, low, middle);
                MergeSortMe(numbers, middle+1, high);
                return Merge(numbers, low, middle, high);
            }
            else{
                return numbers;
            }
        }

        private static MarketData[] Merge(MarketData[] input, int low, int middle, int high)
        {
            int left = low;
            int right = middle + 1;
            MarketData[] tmp = new MarketData[(high - low) + 1];
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


        /// <summary>
        /// Struct implementation
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        public static MarketDataStruct[] Sort(MarketDataStruct[] numbers)
        {
            return MergeSortMe(numbers, 0, numbers.Length - 1);
        }

        private static MarketDataStruct[] MergeSortMe(MarketDataStruct[] numbers, int low, int high)
        {
            if (low < high)
            {
                int middle = (low / 2) + (high /2);
                MergeSortMe(numbers, low, middle);
                MergeSortMe(numbers, middle+1, high);
                return Merge(numbers, low, middle, high);
            }
            else{
                return numbers;
            }
        }

        private static MarketDataStruct[] Merge(MarketDataStruct[] input, int low, int middle, int high)
        {
            int left = low;
            int right = middle + 1;
            MarketDataStruct[] tmp = new MarketDataStruct[(high - low) + 1];
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