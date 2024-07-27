using _5._Control_Flow.Seasons;

namespace _5._Control_Flow;

class DemoConditionalStatements
{
    public static void demoCond_()
    {
       var season = Season.Winter;
        switch (season)
        {
            case Season.Autumn:
                Console.WriteLine("It's autumn and a beautiful season");
                break;
            case Season.Spring:
                Console.WriteLine("It's  Spring,flowers and bees might come out");
                break;
            case Season.Summer:
            case Season.Winter: //Or winter
                Console.WriteLine("It's Summer and Winter at the same time...It's the end of the WORLD!!!");//Then this will 
                Console.WriteLine("Do wanna make a Snowman ?");//executed
                break;
            default:
                Console.WriteLine("That's not a real season chief");
                break;
        }
    }    
}