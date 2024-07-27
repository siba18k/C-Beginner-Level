// See https://aka.ms/new-console-template for more information

public class Date_Time//Are an immutable type, you need to use .Add()  to modify them
{
    public static void datentime()
    // static void Main(string[] args)
    {
        var dateTime = new DateTime(2024,7,12);
        var now = DateTime.Now;
        var today = DateTime.Today;
        Console.WriteLine(dateTime);
        Console.WriteLine(today);
        
        
        Console.WriteLine($"Hour: {now.Hour}");
        Console.WriteLine($"Minute: {now.Minute}");
        Console.WriteLine($"Second: {now.Second}");

        
        var tomorrow = now.AddDays(800);//If you want to go to the past then use a negative number
        Console.WriteLine(tomorrow);
        
        //Converting Dates to String
        Console.WriteLine(now.ToLongDateString());
        Console.WriteLine(now.ToShortDateString());
        Console.WriteLine(now.ToLongTimeString());
        Console.WriteLine(now.ToShortTimeString());
        Console.WriteLine(now.ToString());
        Console.WriteLine(now.ToString("yy-MMM-dd ddd hh:mm"));//When you wanna format the date
     //Go search c#datetime format specifier if you want more   
    }
}