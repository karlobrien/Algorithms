using System;

namespace Algos
{
    /// <summary>
    /// Bubble Sort
    /// Takes an array of numbers and sorts
    /// Best Case: O(n)
    /// Worst Case O(n^2)
    /// Average Case O(n^2)
    /// </summary>
    public static class BubbleSort
    {
        public static int[] Sort(int[] numbers)
        {
            int temp;
            int length = numbers.Length;
            for (int i = 0; i < length; i++)
            {
                for(int j=i+1; j < length; j++)
                {
                    if (numbers[i] > numbers[j])
                    {
                        temp = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = temp;
                    }
                }
            }

            return numbers;
        }

    }
}