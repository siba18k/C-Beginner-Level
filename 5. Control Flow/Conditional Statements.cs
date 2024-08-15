internal class Cond_Statements
{
    public static void cond_Statements()
    {
        var pickle = "Green";
        var cabbage = "Stinky";
        var buttternut = "Orange";
        if (pickle == "Green")
        {
            Console.WriteLine("That's a good pickle");
            if (cabbage == "Stinky")
                Console.WriteLine("Cabbage has joined the party");
            if (buttternut == "Orange")
                Console.WriteLine("Veggies - roll out");
        }
   
    }
}