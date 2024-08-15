namespace _5.Control_Flow._11._Exercises;

public class Q2
{
   public static void q2()
    {
        var sum = 0;
        while (true)
        {
            Console.Write("Enter a number(ok or leave blank to exit): ");
            var input = Console.ReadLine();

            if (input.ToLower() == "ok" | string.IsNullOrWhiteSpace(input))
            {
                break;
            }
            sum += int.Parse(input);
        }

        Console.WriteLine($"Total Sum: {sum}");
    }
}