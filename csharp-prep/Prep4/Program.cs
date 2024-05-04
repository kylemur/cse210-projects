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
            total += i;
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


// using System;
// using System.Collections.Generic;

// class Program
// {
//     static void Main(string[] args)
//     {
//         List<int> numbers = new List<int>();
        
//         // Please note we could use a do-while loop here instead
//         int userNumber = -1;
//         while (userNumber != 0)
//         {
//             Console.Write("Enter a number (0 to quit): ");
            
//             string userResponse = Console.ReadLine();
//             userNumber = int.Parse(userResponse);
            
//             // Only add the number to the list if it is not 0
//             if (userNumber != 0)
//             {
//                 numbers.Add(userNumber);
//             }
//         }

//         // Part 1: Compute the sum
//         int sum = 0;
//         foreach (int number in numbers)
//         {
//             sum += number;
//         }

//         Console.WriteLine($"The sum is: {sum}");

//         // Part 2: Compute the average
//         // Notice that we first cast the sum variable to be a float. Otherwise, because
//         // both the sum and the count are integers, the computer will do integer division
//         // and I will not get a decimal value (even though it puts the result into a float variable).

//         // By making one of the variables a float first, the computer knows that it has to
//         // do the floating point division, and we get the decimal value that we expect.
//         float average = ((float)sum) / numbers.Count;
//         Console.WriteLine($"The average is: {average}");

//         // Part 3: Find the max
//         // There are several ways to do this, such as sorting the list
        
//         int max = numbers[0];

//         foreach (int number in numbers)
//         {
//             if (number > max)
//             {
//                 // if this number is greater than the max, we have found the new max!
//                 max = number;
//             }
//         }

//         Console.WriteLine($"The max is: {max}");
//     }
// }