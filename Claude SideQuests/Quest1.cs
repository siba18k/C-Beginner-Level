namespace Claude_SideQuests;

public class Program
{
    public void Quest1()
    {
        Console.Write("Enter a number: ");
        var usrInput = int.Parse(Console.ReadLine());

        if (usrInput > 0)
        {
            Console.WriteLine("The number is positive");
        }

        else if (usrInput < 0)
        {
            Console.WriteLine("The number is negative");
        }
        else
        {
            Console.WriteLine("The number is zero");
        }
    }
}