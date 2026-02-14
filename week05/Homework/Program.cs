using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment myAssignment = new Assignment("Henry Snow", "Extra Credit");
        Console.WriteLine(myAssignment.GetSummary());

        Console.WriteLine();

        MathAssignment myMathAssignment = new MathAssignment("Alice Holly", "Geometry", "3.4", "3-9");
        Console.WriteLine(myMathAssignment.GetSummary());
        Console.WriteLine(myMathAssignment.GetHomeworkList());
        
        Console.WriteLine();

        WritingAssignment myWritingAssignment = new WritingAssignment("Thomas Weathers", "History", "The Great Depression");
        Console.WriteLine(myWritingAssignment.GetSummary());
        Console.WriteLine(myWritingAssignment.GetWritingInformation());
    }
}