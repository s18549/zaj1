using System;

public class Program
{
    public static void Main()
    {
        int[] numbers = { 5, 10, 15, 20, 25 };
        double average = CalculateAverage(numbers);
        Console.WriteLine("Średnia: " + average);

        int max = FindMaxValue(numbers);
        Console.WriteLine("Maksymalna wartość: " + max);
    }

    public static double CalculateAverage(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
            throw new ArgumentException("Tablica liczb nie może być pusta.");

        int sum = 0;
        foreach (int nume in numbers)
        {
            sum += nume;
        }

        return (double)sum / numbers.Length;
    }

    public static int FindMaxValue(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
            throw new ArgumentException("Tablica liczb nie może być pusta.");

        int max = numbers[0];
        foreach (int num in numbers)
        {
            if (num > max)
            {
                max = num;
            }
        }

        return max;
    }
}
