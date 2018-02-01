using System;

namespace Algos
{
    /// <summary>
    /// Insertion Sort
    /// Takes an array of numbers and sorts
    /// </summary>
    public static class InsertionSort
    {
        public static int[] Sort(int[] numbers)
        {
            int temp;
            for (int i = 0; i < numbers.Length-1; i++)
            {
                for(int j=i+1; j>0; j--)
                {
                    if (numbers[j-1] > numbers[j])
                    {
                        temp = numbers[j-1];
                        numbers[j-1] = numbers[j];
                        numbers[j] = temp;
                    }
                }
            }

            return numbers;
        }

    }
}