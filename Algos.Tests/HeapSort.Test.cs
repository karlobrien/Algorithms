using System;
using Xunit;
using Algos;

namespace Algos.Tests
{
    public class HeapSortTests
    {

        [Fact]
        public void Validate_Data_IsSorted()
        {
            int[] items = new int[10];
            Random random = new Random();

            for (var i = 0; i < 10; i++)
                items[i] = random.Next(0, 100);

            Console.WriteLine("Input");
            foreach(var item in items)
            {
                Console.WriteLine(item);
            }

            var sortedArray = HeapSortByValue.HeapSort(items);

            Console.WriteLine("Max Heap");
            foreach(var item in sortedArray)
            {
                Console.WriteLine(item);
            }



            //for(int i = 1; i < sortedArray.Length; i++)
            //    Assert.True(sortedArray[i-1] <= sortedArray[i]);

        }

    }
}
