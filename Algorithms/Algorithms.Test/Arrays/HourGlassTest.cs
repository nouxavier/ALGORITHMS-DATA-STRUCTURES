using Algorithms.Arrays;
using Algorithms.Exceptions;
using Algorithms.Sum;
using ExpectedObjects;
using Xunit;

namespace Algorithms.Test.Arrays;

public class HourGlassTest
{
    private readonly int[,] _input;

    public HourGlassTest()
    { 
        _input = new int[6,6] { {1,1,1,0,0,0},
                                {0,1,0,0,0,0},
                                {1,1,1,0,0,0},
                                {0,0,2,4,4,0},
                                {0,0,0,2,0,0},
                                {0,0,1,2,4,0},
        };
    }


    [Fact]
    public void CanCreateArr()
    {
        var arrExpected = new
        {
            Input = _input,
        };

        var arr = new HourGlass(arrExpected.Input);

        arrExpected.ToExpectedObject().ShouldMatch(arr);
    }


    [Fact]
    public void SumSucess()
    {
        var result = HourGlassBuilder.NewWithAllProps(_input).Sum();
        Assert.Equal(19, result);
    }

    [Fact]
    public void SumListSucess()
    {
        List<List<int>> input  = new List<List<int>> { new List<int>{1,1,1,0,0,0},
                                new List<int>{0,1,0,0,0,0},
                                new List<int>{1,1,1,0,0,0},
                                new List<int>{0,0,2,4,4,0},
                                new List<int>{0,0,0,2,0,0},
                                new List<int>{0,0,1,2,4,0},
        };
        var result = HourGlass.SumList(input);
        Assert.Equal(19, result);
    }

    [Fact]
    public void SumList2Sucess()
    {
        List<List<int>> input = new List<List<int>> {
            new List<int> { -1,  -1,   0,  -9,  -2, -2  },
            new List<int> { -2, - 1, - 6, - 8, - 2, - 5 },
            new List<int> { -1, - 1, - 1, - 2, - 3, - 4 },
            new List<int> { -1, - 9, - 2, - 4, - 4, - 5 },
            new List<int> { -7, - 3, - 3, - 2, - 9, - 9 },
            new List<int> { -1, - 3, - 1, - 2, - 4, - 5 },
        };
        var result = HourGlass.SumList(input);
        Assert.Equal(19, result);
    }

}
