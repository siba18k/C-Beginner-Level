namespace _6._Lists_and_Arrays.Exercises;

public class _CommaList
{
    // static void Main(string[] args)
    public static void _commalist()
    {
        while (true)
        {
            Console.Write("Enter a list of numbers separated by commas: ");
            var comlist = Console.ReadLine();
                try
                {
                    var strList = comlist.Split(',');
                    var intList = strList.Select(num => int.Parse(num.Trim())).ToArray(); //Remember to .Trim()
                    //the string being .Parsed()

                    if (intList.Length < 5)
                    {
                        Console.WriteLine("Invalid List. Please enter at least 5 numbers.");
                    }

                    var minThree = intList.OrderBy(n => n).Take(3).ToArray();
                    Console.WriteLine($"The 3 smallest numbers are: {string.Join(", ", minThree)}");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter only numbers separated by commas.");
                }

        }
    }
}
