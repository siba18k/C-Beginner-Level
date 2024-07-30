namespace Working_with_Text.Exercises;

public class TipeSpan {
    public static void timeChecker()
    {
        while (true)
        {
            Console.Write("Enter a time value in the 24-hour time format (e.g. 19:00): ");
            var userinput = Console.ReadLine();
            
            if (IsTimeFormat(userinput))
                break;
        }
    }

    public static bool IsTimeFormat(string? userinput)
    {
        var time = userinput.Split(":");
        if (time.Length != 2 || string.IsNullOrWhiteSpace(userinput))
        {
            Console.WriteLine("Please type in an actual time");
            return true;
        }

        var hour = int.Parse(time[0]);
        var min = int.Parse(time[1]);
        if (hour is >= 00 and <= 23 && min is >= 00 and <= 60)
        {
            Console.WriteLine("This time is valid");
            return false;
        }

        Console.WriteLine("Invalid Time Bruv");
        return false;
    }
}