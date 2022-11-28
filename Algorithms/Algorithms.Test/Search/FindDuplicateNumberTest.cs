using System;
using Algorithms.Search;

namespace Algorithms.Test.Search
{
    public class FindDuplicateNumberTest
    {
        public FindDuplicateNumberTest()
        {
        }

        [Fact]
        public void ForceBruteSuccess()
        {
            int[] arr1 = new int[] { 11 };
            int[] arr2 = new int[] { 11 };
            int[] expected = new int[] { 11 };

            var output = FindDuplicateNumber.ForceBrute(arr1, arr2);
            Assert.Equal(expected, output);

        }
        [Fact]
        public void BinarySearchNotExistSuccess()
        {
            int[] arr1 = new int[] { 1, 3, 5, 9 };
            int[] arr2 = new int[] { 2, 4, 6, 10 };
            int[] expected = new int[] {  };


            var output = FindDuplicateNumber.BinarySearch(arr1, arr2);
            Assert.Equal(expected, output);

        }

        [Fact]
        public void BinarySearchExistSuccess()
        {
            int[] arr1 = new int[] { 1, 3, 5, 9 };
            int[] arr2 = new int[] { 1, 2, 9 };
            int[] expected = new int[] { 1, 9};


            var output = FindDuplicateNumber.BinarySearch(arr1, arr2);
            Assert.Equal(expected, output);

        }
    }
}

