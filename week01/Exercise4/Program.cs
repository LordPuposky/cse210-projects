using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (true)
        {
            Console.Write("Enter number: ");
            int num = int.Parse(Console.ReadLine());
            if (num == 0)
                break;
            numbers.Add(num);
        }

        if (numbers.Count == 0)
        {
            Console.WriteLine("No numbers entered.");
            return;
        }

        // Sum of all numbers
        int sum = 0;
        foreach (var n in numbers)
            sum += n;

        // Calculate average
        double average = (double)sum / numbers.Count;

        // Find the maximum number
        int max = numbers[0];
        foreach (var n in numbers)
            if (n > max)
                max = n;


        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");

        // Find the smallest positive number in the list
        int minPositive = int.MaxValue;
        foreach (var n in numbers)
            if (n > 0 && n < minPositive)
                minPositive = n;

        if (minPositive != int.MaxValue)
            Console.WriteLine($"The smallest positive number is: {minPositive}");

        // Sort the list using bubble sort algorithm
        for (int i = 0; i < numbers.Count - 1; i++)
        {
            for (int j = 0; j < numbers.Count - 1 - i; j++)
            {
                if (numbers[j] > numbers[j + 1])
                {
                    int temp = numbers[j];
                    numbers[j] = numbers[j + 1];
                    numbers[j + 1] = temp;
                }
            }
        }

        // Print the sorted list
        Console.WriteLine("The sorted list is:");
        foreach (var n in numbers)
            Console.WriteLine(n);
    }
}
