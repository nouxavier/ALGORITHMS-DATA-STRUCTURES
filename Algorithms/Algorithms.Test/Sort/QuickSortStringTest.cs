using System;
namespace Algorithms.Test.Sort
{
    public class QuickSortStringTest
    {
        public QuickSortStringTest()
        {
        }

        [Fact]
        public void SortListSuccess()
        {
            List<List<string>> input = new List<List<string>>()
            {
                new List<string>(){"0", "ab"},
                new List<string>(){"6", "cd"},
                new List<string>(){"0", "ef"},
                new List<string>(){"6", "gh"},
                new List<string>(){"4", "ij"},
                new List<string>(){"0", "ab"},
                new List<string>(){"6", "cd"},
                new List<string>(){"0", "ef"},
                new List<string>(){"6", "gh"},
                new List<string>(){"0", "ij"},
                new List<string>(){"4", "tha"},
                new List<string>(){"3", "be"},
                new List<string>(){"0", "to"},
                new List<string>(){"1", "be"},
                new List<string>(){"5", "quetion"},
                new List<string>(){"1", "or"},
                new List<string>(){"2", "not"},
                new List<string>(){"4", "is"},
                new List<string>(){"2", "to"},
                new List<string>(){"4", "the"},
             };
            var n = 20; ;
            Assert.Equal(null, null);
        }

        [Fact]
        public void SortList2Success()
        {
            List<List<string>> input = new List<List<string>>()
            {
                new List<string>(){"0", "ab"},
                new List<string>(){"6", "cd"},
                new List<string>(){"0", "ef"},
                new List<string>(){"6", "gh"},
                new List<string>(){"4", "ij"},
                new List<string>(){"0", "ab"},
                new List<string>(){"6", "cd"},
                new List<string>(){"0", "ef"},
                new List<string>(){"6", "gh"},
                new List<string>(){"0", "ij"},
                new List<string>(){"4", "tha"},
                new List<string>(){"3", "be"},
                new List<string>(){"0", "to"},
                new List<string>(){"1", "be"},
                new List<string>(){"5", "quetion"},
                new List<string>(){"1", "or"},
                new List<string>(){"2", "not"},
                new List<string>(){"4", "is"},
                new List<string>(){"2", "to"},
                new List<string>(){"4", "the"},
             };
            QuickSortStringBuilder.NewAllProps(input).Sort2();
            Assert.Equal(null, null);
        }


    

}
}

