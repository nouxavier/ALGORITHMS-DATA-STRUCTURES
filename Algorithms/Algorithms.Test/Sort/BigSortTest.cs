using System;
namespace Algorithms.Test.Sort
{
    public class BigSortTest
    {
        public BigSortTest()
        {
        }

        [Fact]
        public void PrintSortDescendingSucess()
        {
            var input = new string[] { "1", "200", "150", "3" };
            Assert.Equal(new string[] { "200", "150","3", "1" } , BigSortBuilder.NewAllProps(input).SortDescending());
        }
        [Fact]
        public void Print2SortDescendingSucess()
        {
            var input = new string[] { "6", "31415926535897932384626433832795", "1", "3", "10", "3", "5" };
            Assert.Equal(new string[] { "31415926535897932384626433832795", "10", "6", "5", "3", "3", "1"}, BigSortBuilder.NewAllProps(input).SortDescending());
        }
        [Fact]
        public void PrintIncreseSucess()
        {
            var input = new string[] { "1", "200", "150", "3" };
            Assert.Equal(new string[] { "1", "3", "150", "200"}, BigSortBuilder.NewAllProps(input).SortIncrese());
        }
        [Fact]
        public void Print2IncreseSucess()
        {
            var input = new string[] { "6", "31415926535897932384626433832795", "1", "3", "10", "3", "5" };
            Assert.Equal(new string[] { "1", "3", "3", "5", "6","10", "31415926535897932384626433832795" }, BigSortBuilder.NewAllProps(input).SortIncrese());
        }

    }
}

