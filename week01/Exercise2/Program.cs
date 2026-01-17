using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your Grade Percentage? ");
        string grade_percentage = Console.ReadLine();

        int grade_value = int.Parse(grade_percentage);
        string letter = "";

        if (grade_value >= 90)
        {
            letter = "A";
        }
        else if (grade_value >= 80)
        {
            letter = "B";
        }
        else if (grade_value >= 70)
        {
            letter = "C";
        }
        else if (grade_value >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        if (grade_value % 10 >= 7 && letter != "A" && letter != "F")
        {
            letter += "+";
        }
        else if (grade_value % 10 < 3 && grade_value < 100 && letter != "F")
        {
            letter += "-";
        }

        Console.WriteLine($"Your Grade is {letter}");

        if (grade_value >= 70)
        {
            Console.WriteLine("Congrats on Passing the Class!");
        }
        else
        {
            Console.WriteLine("Make Sure To Try Harder Next Time");
        }
    }
}