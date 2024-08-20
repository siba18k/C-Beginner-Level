namespace _5._Control_Flow;

public class Demo_Foreach_Loops
{
   public static void demo_Foreach()
    {
        var name = "John Smith";
        
        // for (int i = 0; i < name.Length; i++)
        // {
        //     Console.WriteLine(name[i]); 
        // }
        
        foreach (var n in name) //this is the same way to acheive the previous code, quicker and less verbose
        {
            Console.WriteLine(n);
        }
        
        //Iterating over and array
        var numbers = new int[5]{1,2,3,4,5};
        foreach (var number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}