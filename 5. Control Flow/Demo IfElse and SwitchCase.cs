using CSharp1Exercises.ControlFlow;

class DemoConditionalStatements
{
    
    public static void Main()
    {
        Console.Write("Enter the number for the season: ");
        var input = int.Parse(Console.ReadLine());
        
        switch (input)
        {
            case (int)Season.Autumn://We use casting(int) in order to call the enum fields represented by digits
                Console.WriteLine("It's autumn and a beautiful season");
                break;
            case (int)Season.Spring:
                Console.WriteLine("It's  Spring,flowers and bees might come out");
                break;
            case (int)Season.Summer:
            case (int)Season.Winter: //Or winter
                Console.WriteLine(
                    "It's Summer and Winter at the same time...It's the end of the WORLD!!!"); //Then this will 
                Console.WriteLine("Do wanna make a Snowman ?"); //executed
                break;
            default:
                Console.WriteLine("That's not a real season chief");
                break;
        }
    }

}