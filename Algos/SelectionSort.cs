using System;

namespace Algos
{
    /// <summary>
    /// Takes an array of numbers and sorts
    /// Best Case: O(n)
    /// Worst Case O(n^2)
    /// Average Case O(n^2)
    /// </summary>
    public static class SelectionSort
    {
        public static int[] Sort(int[] numbers)
        {
            int min, temp;
            for (int x = 0; x < numbers.Length; x++)
            {
                min = x;
                for (int y = x + 1; y < numbers.Length; y++)
                {
                    if (numbers[y] < numbers[min])
                    {
                        min = y;
                    }
                }

                //swap the min element
                if (min != x)
                {
                    temp = numbers[x];
                    numbers[x] = numbers[min];
                    numbers[min] = temp;
                }

            }

            return numbers;
        }

    }
}