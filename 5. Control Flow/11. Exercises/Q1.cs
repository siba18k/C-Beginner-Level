namespace _5._Control_Flow._11._Exercises;

public class Q1
{
   public static void q1()
    {
        var count = 0;
        var num = 100;
        for (int i = 1; i < num; i++)
        {
            if (i % 3 == 0)
            {
                Console.WriteLine(i);
                count++;
            }
        }

        Console.WriteLine("There are {0} numbers divisible by 3",count);
    }
}