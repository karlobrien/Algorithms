using System;
using Xunit;
using Algos;

namespace Algos.Tests
{
    public class BuddleSortTests
    {

        [Fact]
        public void Validate_Data_IsSorted()
        {
            int[] items = new int[10];
            Random random = new Random();

            for (var i = 0; i < 10; i++)
                items[i] = random.Next(0, 100);

            var sortedArray = BubbleSort.Sort(items);

            for(int i = 1; i < sortedArray.Length; i++)
                Assert.True(sortedArray[i-1] <= sortedArray[i]);

        }

    }
}
