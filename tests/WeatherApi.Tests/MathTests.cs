namespace WeatherApi.Tests;

using static Math;

public class MathTests
{
    [Theory]
    [InlineData(new []{ 0, 0, 0, 0, 0 }, 0)]
    [InlineData(new []{ 1, 2, 3, 4, 5 }, 15)]
    [InlineData(new []{ -1, -2, 3, 4, 5 }, 9)]
    public void SumOfNumbersIsReturned(int[] numbers, int expectedSum)
    {
        var actualSum = Sum(numbers);
        
        Assert.Equal(expectedSum, actualSum);
    }
    
    [Theory]
    [InlineData(new []{ 0, 0, 0, 0, 0 }, 0)]
    [InlineData(new []{ 1, 2, 3, 4, 5 }, 5)]
    [InlineData(new []{ -1, -2, 3, 4, 5 }, 5)]
    public void LargestNumberIsReturned(int[] numbers, int expectedMax)
    {
        var actualMax = Max(numbers);
        
        Assert.Equal(expectedMax, actualMax);
    }
    
    [Theory]
    [InlineData(new []{ 0, 0, 0, 0, 0 }, 0)]
    [InlineData(new []{ 1, 2, 3, 4, 5 }, 1)]
    [InlineData(new []{ -1, -2, 3, 4, 5 }, -2)]
    public void SmallestNumberIsReturned(int[] numbers, int expectedMin)
    {
        var actualMin = Min(numbers);
        
        Assert.Equal(expectedMin, actualMin);
    }
}