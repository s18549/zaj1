using System;

public class Program
{
    public static void Main()
    {
        int[] numbers = { 5, 10, 15, 20, 25 };
        double average = CalculateAverage(numbers);
        Console.WriteLine("Średnia: " + average);
    }

    public static double CalculateAverage(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
            throw new ArgumentException("Tablica liczb nie może być pusta.");

        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }

        return (double)sum / numbers.Length;
    }
}
