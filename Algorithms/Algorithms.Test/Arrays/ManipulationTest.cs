using System;
using Algorithms.Arrays;

namespace Algorithms.Test.Arrays
{
    public class ManipulationTest
    {
        private  int n, m;
        private int[,] _queries;

        public ManipulationTest ()
        {
            n = 10;
            _queries = new int[3, 3] { {1,2,100},{ 2,5,100 }, {3, 4, 100} };
            
        }
        [Fact]
        public void Manipulation2Success()
        {
            n = 5;
            m = 3;

            _queries = new int[3, 3] { { 1, 2, 100 }, { 2, 5, 100 }, { 3, 4, 100 } };
            var result = ManipulationBuilder.NewBuilder(n, m, _queries).Manipulation();
            Assert.Equal(200, result);
        }

        [Fact]
        public void Manipulation4Success()
        {
            n = 5;
            m = 3;

            _queries = new int[3, 3] { { 1, 2, 100 }, { 2, 5, 100 }, { 3, 4, 100 } };
            var result = ManipulationBuilder.NewBuilder(n, m, _queries).ManipulationOptimized();
            Assert.Equal(200, result);
        }

        [Fact]
        public void ManipulationSuccess()
        {
            n = 5;
            m = 3;
            var queries = new List<List<int>>
            { new List<int>(){ 1, 2, 100 },
                new List<int>(){ 2, 5, 100 },
                new List<int>(){ 3, 4, 100 } };
            var result = ManipulationBuilder.NewBuilder(n, m, _queries).Manipulation(5, 3, queries);
            Assert.Equal(200, result);
        }

        [Fact]
        public void Manipulation3Success()
        {
            n = 5;
            m = 3;
            var queries = new List<List<int>>
            { new List<int>(){ 2, 6, 8 },
                new List<int>(){ 3,5,7 },
                new List<int>(){ 1,8,1 },
                new List<int>(){ 5,9,15} };
            var result = ManipulationBuilder.NewBuilder(n, m, _queries).Manipulation(10, 4, queries);
            Assert.Equal(31, result);
        }

    }
}

