namespace _5._Control_Flow._11._Exercises;

public class Q4
{
    public static void q4()
    {
        var randomnum = new Random().Next(1,10);
        Console.WriteLine($"The Secret Number is: {randomnum}");

        for (int i = 1; i <= 5; i++)
        {
            Console.Write("Guess the right number: ");
            var guess = int.Parse(Console.ReadLine());
            if (guess == randomnum)
            {
                Console.WriteLine("You won the game!");
                return;
            }
            
            if (guess < randomnum)
            {
                Console.WriteLine("Go Higher");
            }
           
            if (guess > randomnum)
            {
                Console.WriteLine("Go Lower");
            }
        }
        Console.WriteLine("Tuff cookies bruv,game over");
    }
}