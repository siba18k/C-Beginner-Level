namespace _5._Control_Flow._4._Exercise;

public class Exercises
{
    public void Question1()
    {
        var FitRating = 100;
            if (FitRating >= 1 & FitRating <= 10 )
            {
                Console.WriteLine("Valid Fit Bro");
            }
            else
            {
                Console.WriteLine("Invalid Fit Bro, get off the team");
            }
        
    }

    public void Question2()
    {
        var num1 = 23;
        var num2 = 22;
        if (num1 > num2)
        {
            Console.WriteLine("Num1 is bigger");
        } 
        else if (num1 < num2)
        {
            Console.WriteLine("Num2 is bigger");
        }
        else //or else if(num1 == Num2)
        {
            Console.WriteLine("Num1 and Num2 are the same number Your Welcome ;)");
        }
    }

    public void Question3()
    {
        var width = 3480;
        var height = 2460;
        if (width > height | height == width)
        {
            Console.WriteLine("The image is in Landscape Mode");
        }  
        else if (height > width )
        {
            Console.WriteLine("The image is in Portrait Mode");
        }
    }
}