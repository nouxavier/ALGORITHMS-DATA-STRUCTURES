using Algorithms.Arrays;
using Algorithms.Exceptions;
using Algorithms.Sum;
using ExpectedObjects;
using Xunit;

namespace Algorithms.Test.Arrays;

public class ArrayDSTest
{
    private readonly int[] _input;

    public ArrayDSTest()
    { 
        _input = new int[] { 1, 1, 1, 1 };
    }


    [Fact]
    public void CanCreateArr()
    {
        var arrExpected = new
        {
            Input = _input,
        };

        var arr = new ArrayDS(arrExpected.Input);

        arrExpected.ToExpectedObject().ShouldMatch(arr);
    }


    [Theory]
    [InlineData(new int[] { 1,4,3,2})]
    public void RevertSucess(int[] input)
    {
        var result = ArrayDSBuilder.NewWithAllProps(input).ReverseInput();
        Assert.Equal(new int[] { 2, 3, 4, 1 }, result);
    }

    [Theory]
    [InlineData(new int[] { 1, 4, 3, 2 })]
    public void RevertForSucess(int[] input)
    {
        var result = ArrayDSBuilder.NewWithAllProps(input).ReverseInputFor();
        Assert.Equal(new int[] { 2, 3, 4, 1 }, result);
    }

}
