using System.Globalization;

namespace Working_with_Text.Exercises;

public class PascalCase
{
    public static void pasCal_case()
    {
        Console.Write("Enter a few words separated by a space:");
        var words = Console.ReadLine();

        var wordarr = words.Split(" ");
        var firstlet = wordarr[0][0];
        Console.WriteLine(firstlet);
        // foreach (var wrd in wordarr)
        // {
        //     var nuwrdorder = wrd[0].ToUpper();
        //     Console.Write(nuwrdorder);
        // }
    }
}