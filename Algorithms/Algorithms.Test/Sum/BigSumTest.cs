using Algorithms.Exceptions;
using Algorithms.Sum;
using ExpectedObjects;
using Xunit;

namespace Algorithms.Test.Sum;

public class BigSumTest
{
    private readonly long[] _input;

    public BigSumTest()
    { 
        _input = new long[] { 1, 1, 1, 1 };
    }


    [Fact]
    public void CanCreateSum()
    {
        var sumExpected = new
        {
            Input = _input,
        };

        var sum = new BigSum(sumExpected.Input);

        sumExpected.ToExpectedObject().ShouldMatch(sum);
    }

    [Theory]
    [InlineData(null)]
    [InlineData(new long[] { })]
    public void InputNullSum(long[] input)
    {
        Assert.Throws<DomainException>(() => BigSumBuilder.NewWithAllProps(input));
    }

    [Theory]
    [InlineData(new long[] { 1000000001, 1000000002, 1000000003, 1000000004, 1000000005})]
    public void ResultSum1Sucess(long[] input)
    {
        var result = BigSumBuilder.NewWithAllProps(input).ResultSum();
        Assert.Equal(5000000015, result);
    }

    [Theory]
    [InlineData(new long[] { 1000000001, 1000000002, 1000000003, 1000000004, 1000000005 })]
    public void ResultSum1Fail(long[] input)
    {
        var result = BigSumBuilder.NewWithAllProps(input).ResultSum();
        Assert.NotEqual(5000000012, result);
    }

}
