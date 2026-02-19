using System;

class Program
{
    static void Main(string[] args)
    {
        DateTime dateTime = DateTime.Today;
        string date = $"{dateTime.Day} {LetterMonth(dateTime.Month)} {dateTime.Year}";

        List<Activity> activities = new List<Activity>();
        activities.Add(new Running(date, 30, 3.3));
        activities.Add(new Cycling(date, 60, 6.8));
        activities.Add(new Swimming(date, 15, 13));

        foreach(Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }

    static string LetterMonth(int number)
    {
        if(number == 1)
        {
            return "Jan";
        }
        else if(number == 2)
        {
            return "Feb";
        }
        else if(number == 3)
        {
            return "Mar";
        }
        else if(number == 4)
        {
            return "Apr";
        }
        else if(number == 5)
        {
            return "May";
        }
        else if(number == 6)
        {
            return "Jun";
        }
        else if(number == 7)
        {
            return "Jul";
        }
        else if(number == 8)
        {
            return "Aug";
        }
        else if(number == 9)
        {
            return "Sep";
        }
        else if(number == 10)
        {
            return "Oct";
        }
        else if(number == 11)
        {
            return "Nov";
        }
        else if(number == 12)
        {
            return "Dec";
        }
        return "";
    }
}