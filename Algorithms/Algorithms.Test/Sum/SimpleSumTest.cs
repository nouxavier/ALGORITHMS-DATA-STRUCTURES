using Algorithms.Exceptions;
using Algorithms.Sum;
using ExpectedObjects;
using Xunit;

namespace Algorithms.Test.Sum;

public class SimpleSumTest
{
    private readonly int[] _input;

    public SimpleSumTest()
    { 
        _input = new int[] { 1, 1, 1, 1 };
    }


    [Fact]
    public void CanCreateSum()
    {
        var sumExpected = new
        {
            Input = _input,
        };

        var sum = new SimpleSum(sumExpected.Input);

        sumExpected.ToExpectedObject().ShouldMatch(sum);
    }

    [Theory]
    [InlineData(null)]
    [InlineData(new int[] { })]
    public void InputNullSum(int[] input)
    {
        Assert.Throws<DomainException>(() => SimpleSumBuilder.NewWithAllProps(input));
    }

    [Theory]
    [InlineData(new int[] {1,1,1,1})]
    public void ResultSum1Sucess(int[] input)
    {
        var result = SimpleSumBuilder.NewWithAllProps(input).ResultSum();
        Assert.Equal(4, result);
    }

    [Theory]
    [InlineData(new int[] { 1, 1, 1, 1 })]
    public void ResultSum1Fail(int[] input)
    {
        var result = SimpleSumBuilder.NewWithAllProps(input).ResultSum();
        Assert.NotEqual(5, result);
    }

}
