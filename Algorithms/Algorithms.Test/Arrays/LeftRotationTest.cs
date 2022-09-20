using Algorithms.Arrays;
using Algorithms.Exceptions;
using Algorithms.Sum;
using ExpectedObjects;
using Xunit;

namespace Algorithms.Test.Arrays;

public class LeftRotationTest
{
    private readonly int[] _input;

    public LeftRotationTest()
    { 
        _input = new int[5]{1,2,3,4,5};
    }


    [Fact]
    public void CanCreateArr()
    {
        var arrExpected = new
        {
            Input = _input,
        };

        var arr = new LeftRotation(arrExpected.Input);

        arrExpected.ToExpectedObject().ShouldMatch(arr);
    }


    [Fact]
    public void SumSucess()
    {
        var result = LeftRotationBuilder.NewWithAllProps(_input).Rotation(2);
        Assert.Equal(new int[5] {3,4,5,1,2}, result);
    }
    [Fact]
    public void Sum2Sucess()
    {
        var result = LeftRotation.Rotate(_input,2,5);
        Assert.Equal(new int[5] { 3, 4, 5, 1, 2 }, result);
    }
    [Fact]
    public void Sum3Sucess()
    {
        var result = LeftRotation.Rotate(new int[14] { 98, 67, 35, 1, 74, 79, 7, 26, 54, 63, 24, 17, 32, 81 },7,14);
        Assert.Equal(new int[14] { 26, 54, 63, 24, 17, 32, 81, 98, 67, 35, 1, 74, 79, 7 }, result);
    }
    [Fact]
    public void SumListSucess()
    {
        var result = LeftRotationBuilder.NewWithAllProps(_input).RotationList(2);
        Assert.Equal(new List<int>{ 3, 4, 5, 1, 2 }, result);
    }
    


}
