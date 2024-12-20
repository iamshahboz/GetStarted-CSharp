namespace ConsoleApp1;

public class DayOfWeek
{
    public void DaysOfTheWeek(int day)
    {
        var dayName = "Invalid day";
        
        
        if (day == 0)
        {
             dayName = "Monday";
        }
        else if (day == 1)
        {
             dayName = "Tuesday";
        }
        else if (day == 2)
        {
             dayName = "Wednesday";
        }
        else if (day == 3)
        {
             dayName = "Thursday";
        }
        else if (day == 4)
        {
             dayName = "Friday";
        }
        else if (day == 5)
        {
            dayName = "Saturday";
        }
        else if (day == 6)
        {
            dayName = "Sunday";
        }

        Console.WriteLine(dayName);
    }
}