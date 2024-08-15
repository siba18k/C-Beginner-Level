namespace CSharp1Exercises.ControlFlow;

public class Q3
{
    public static void q3(string[] args)
    {
        Console.Write("Enter a number: ");
        var number = int.Parse(Console.ReadLine());

        var factorial = 1;
        
        for (var i = 1; i <= number; i++)
            factorial *= i;

        Console.WriteLine("{0}! = {1}", number, factorial);
    }
}