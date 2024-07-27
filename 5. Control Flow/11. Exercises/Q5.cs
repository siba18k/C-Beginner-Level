    using System;
    using System.Linq;
namespace CSharp1Exercises.ControlFlow;

public class Q5
{
    // static void Main(string[] args)
    // {
    //     Console.Write("Enter a series of number separated by a comma ");
    //     var usernum = Console.ReadLine();
    //     var nlist =usernum.Split(",");
    //     
    //     var max = int.Parse(nlist[0]);
    //     foreach (var str in max)
    //     {
    //         var num = int.Parse(max);
    //         
    //     }
    // }
    
    
    // static void Main(string[] args)
    // {
    //     Console.Write("Enter commoa separated numbers: ");
    //     var input = Console.ReadLine();
    //
    //     var numbers = input.Split(',');
    //
    //     // Assume the first number is the max 
    //     var max = Convert.ToInt32(numbers[0]);
    //
    //     foreach (var str in numbers)
    //     {
    //         var number = Convert.ToInt32(str);
    //         if (number > max)
    //             max = number;
    //     }
    //
    //     Console.WriteLine("Max is " + max);
    //
    // }
    

    class Program
    {
        static void Q5()
        {
            Console.Write("Enter a series of numbers separated by commas: ");
            var userinput = Console.ReadLine();

            string[] strInput = userinput.Split(",");
            int[] numInput = strInput.Select(num => int.Parse(num.Trim())).ToArray();

            var LargestNum = numInput.Max();
            Console.WriteLine($"The largest number is: {LargestNum}");
        }
    }
}