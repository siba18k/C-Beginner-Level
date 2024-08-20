namespace _5._Control_Flow;

public class Demo_While_Loops
{
    public static void demo_while_Loops()//It is best to use a while loop  whenever you don't know how many times you're going to
    //do an iteration
    {
        while (true)
        {
            Console.Write("Type your name [blank to terminate]: ");//The reason we're not using Writeline is so the cursor stays on the same line, so no linebreak
            var input = Console.ReadLine();
            // if (string.IsNullOrEmpty(input))
            // {
            //   break;  
            // } 
            if (!string.IsNullOrEmpty(input))
            {
                Console.WriteLine("@Echo: "+input);
                continue;//When the program echos the name, 'continue' makes it jump back to the beginning of the loop
             // instead of moving on to "break"  
            }
            else
            {
                Console.WriteLine("Program Terminated");
                break;
            }
        }
        //There is no right or wrong, It's all up to you and how readable you want your code to be 
    }
}