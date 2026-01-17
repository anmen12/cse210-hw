using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        int answer = -1;
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (answer != 0)
        {
            Console.Write("Enter number: ");
            answer = int.Parse(Console.ReadLine());

            if (answer != 0)
            {
                numbers.Add(answer);
            }
        }

        //Sum
        Console.WriteLine($"The sum is: {SumNumbers(numbers)}");

        //Average
        Console.WriteLine($"The average is: {Convert.ToDouble(SumNumbers(numbers)) / numbers.Count}");

        //Largest
        Console.WriteLine($"The largest number is: {FindLargest(numbers)}");
    }

    static int SumNumbers(List<int> numbers)
    {
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        return sum;
    }

    static int FindLargest(List<int> numbers)
    {
        int largest = numbers[0];
        foreach (int number in numbers)
        {
            if (number > largest)
            {
                largest = number;
            }
        }
        return largest;
    }
}