namespace _7.Working_with_Dates;

public class Time_Span//Represents a length of time usually Hours - Minutes
{
    // pubic static void tmespan()
    static void Main(string[] args)
    {
        
        //Creating
        var timeSpan = new TimeSpan(1,2,3);
        Console.WriteLine(timeSpan);

        var timeSpan1 = new TimeSpan(1, 0, 0);
        Console.WriteLine(timeSpan1);
        
        var timeSpan2 = TimeSpan.FromHours(1);
        Console.WriteLine(timeSpan2);

        var start = DateTime.Now;
        var end = DateTime.Now.AddMinutes(2);
        var duration = end - start;//This gives you a TimeSpan
        Console.WriteLine($"Duration: {duration}");

        //Properties
        Console.WriteLine($"Minutes: {timeSpan.Minutes}");
        Console.WriteLine($"Total Minutes: {timeSpan.TotalMinutes}");
        
        //Add and Subtract
        Console.WriteLine($"Add Example:{timeSpan.Add(TimeSpan.FromMinutes(8))}");
        Console.WriteLine($"Subtract Example:{timeSpan.Subtract(TimeSpan.FromMinutes(2))}");
        
        
        //ToString
        Console.WriteLine($"ToString: {timeSpan.ToString()}");
        
        //Parse
        // var parsedtimeSpan = TimeSpan.Parse("01:09:12");
        // Console.WriteLine($"Parsed: {parsedtimeSpan}");
        Console.WriteLine($"Parse: {TimeSpan.Parse("01:04:05")}");
    }
}