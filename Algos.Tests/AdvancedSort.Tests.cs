using System;
using Xunit;
using Algos;

namespace Algos.Tests
{

    public class AdvancedSortingTests
    {
        [Fact]
        public void Validate_Data_MergeSort()
        {
            int[] items = new int[10];
            Random random = new Random();

            for (var i = 0; i < 10; i++)
                items[i] = random.Next(0, 100);

            var sortedArray = MergeSort.Sort(items);

            for(int i = 1; i < sortedArray.Length; i++)
                Assert.True(sortedArray[i-1] <= sortedArray[i]);

        }

        [Fact]
        public void Validate_Data_QuickSort()
        {
            long size = 100;
            int[] items = new int[size];
            Random random = new Random();

            for (var i = 0; i < size; i++)
                items[i] = random.Next(0, 100);

            var sortedArray = QuickSortByValue.Sort(items);
            //var sortedArray = QuickSortSegwick.QuickSort(items, 0, items.Length - 1);
            for(int i = 1; i < sortedArray.Length; i++)
                Assert.True(sortedArray[i-1] <= sortedArray[i]);

        }

        private void Print(int[] data)
        {
            Console.WriteLine("-----------");
            foreach(var i in data)
                Console.WriteLine(i);
             Console.WriteLine("-----------");
        }
    }
}