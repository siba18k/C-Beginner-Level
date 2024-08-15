internal class Cond_Statements2
{
    public enum VeggiState
    {
        Green = 1,
        Stinky = 2,
        Orangy = 3
    }
    public static void cond_Statements2()
    {
        var Mainput = new List<int>(3);
        var count = 0;
        while (count < 3)
        {
            Console.Write("Choose to see the state of your veggies[1 - Pickle; 2 - Cabbage; 3 - Butternut]: ");
            var input = int.Parse(Console.ReadLine());
            if (input > 3| string.IsNullOrWhiteSpace(input.ToString()))
            {
                Console.WriteLine("Please select a number from 1 to 3");
                continue;
            }
            Mainput.Add(input);
            count += 1 ;
            
        }

        foreach (var num in Mainput)
        {
            switch (num)
            {
                case (int)VeggiState.Green:
                    Console.WriteLine($"The pickle is a green as can be" + 
                                      $"No need to restock ");
                    break;
                case (int)VeggiState.Orangy:
                    Console.WriteLine("That Butternut is taking up all the space in the fridge chief " +
                                      "\n Its also really orange");
                    break;
                case(int)VeggiState.Stinky:
                    Console.WriteLine(@"That cabbage is Stinkyyyy
But don't start investing bruh");
                    break;
            }
        }
        // switch (input)
        // {
        //     case (int)VeggiState.Green:
        //         Console.WriteLine($"The pickle is a green as can be" +
        //                           $"No need to restock ");
        //         break;
        //     case (int)VeggiState.Orangy:
        //         
        
        // {
            // Console.WriteLine("That's a good pickle");
            // if (cabbage == "Stinky")
                // Console.WriteLine("Cabbage has joined the party");
            // if (buttternut == "Orange")
                // Console.WriteLine("Veggies - roll out");
        // }
   
    }
}