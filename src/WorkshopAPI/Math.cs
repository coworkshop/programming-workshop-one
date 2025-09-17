namespace WorkshopAPI;

public static class Math
{
    /// <summary>
    /// Summarizes a list of numbers and returns the result.
    /// </summary>
    /// <param name="numbers">List of numbers</param>
    /// <returns>The sum</returns>
    public static int Sum(int[] numbers)
    {
        var sum = 0;

        foreach (var number in numbers)
            sum += number;

        return sum;
    }

    /// <summary>
    /// Finds the largest number in a list.
    /// </summary>
    /// <param name="numbers">List of numbers</param>
    /// <returns>The largest number</returns>
    public static int Max(int[] numbers)
    {
        var max = numbers[0];

        for (var i = 0; i < numbers.Length; i++)
            if (numbers[i] > max)
                max = numbers[i];

        return max;
    }

    /// <summary>
    /// Finds the smallest number in a list.
    /// </summary>
    /// <param name="numbers">List of numbers</param>
    /// <returns>The smallest number</returns>
    public static int Min(int[] numbers)
    {
        var min = numbers[0];

        foreach (var number in numbers)
            if (number < min)
                min = number;

        return min;
    }
}