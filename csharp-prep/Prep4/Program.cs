using System;
using System.Collections.Generic;
using System.Data;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

        Console.WriteLine("Enter a list of numbers, type 0 when finished. ");

        List<int> numbers = new List<int>();
        int num = 100;

        while (num != 0)
        {
            Console.Write("Enter number: ");
            string numStr = Console.ReadLine();
            num = int.Parse(numStr);
            
            numbers.Add(num);
        }

        // foreach (int i in numbers)
        // {
        //     Console.WriteLine(i);
        // }
        float total = 0;
        foreach (int i in numbers)
        {
            total = total + i;
        }
        Console.WriteLine($"The sum is: {total}");

        float average;
        average = total / (numbers.Count - 1);
        // Console.WriteLine($"The average is: {average:D3}");
        // string averageStr = average.ToString("D3");
        // string.Format("This is my number: {0:D3}", average);
        string averageStr = average.ToString("0.00");
        Console.WriteLine($"The average is: {averageStr}");


        int largest = 0;
        foreach (int i in numbers)
        {
            if (i > largest)
            {
                largest = i;
            }
        }
        Console.WriteLine($"The largest is: {largest}");

        int biggest = numbers.Max();  //another way to get the largest number
        Console.WriteLine(biggest);


        double smallestPos = double.PositiveInfinity;
        foreach (int i in numbers)
        {
            if (i < smallestPos && i > 0)
            {
                smallestPos = i;
            }
        }
        Console.WriteLine($"The smallest positive number is: {smallestPos}");


        numbers.Sort();
        Console.WriteLine("List in sorted order: ");
        foreach (var i in numbers)
        {
            Console.WriteLine(i);
        }

    }
}