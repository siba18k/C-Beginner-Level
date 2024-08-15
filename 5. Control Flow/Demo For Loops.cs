namespace _5._Control_Flow;

public class Demo_For_Loops
{
   public static void demofor_Loops()
    {
        Console.Write(@"Type number you want multiples of:");
        var strIng = Console.ReadLine();
        var input = int.Parse(strIng);
        Console.WriteLine();
        Console.WriteLine($"Here are the multiples of {input}:");
        Console.WriteLine("\nFoward Count: ");
        for (int i = 1 ; i <= input; i++)//forwards
        {
            if (i % 2 ==0)
            {
                Console.WriteLine(i);
            }
        }

        Console.WriteLine("\n Reverse Count: ");
        for (int i = input; i >= 1; i--)
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
    }
}