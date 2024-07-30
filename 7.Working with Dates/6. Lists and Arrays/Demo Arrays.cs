namespace _6._Lists_and_Arrays;

public class Demo_Arrays
{
    public static void Dem_Arrays()
    //static void Main(string[] args)
    {
        var numbers = new[]{1,2,3,4,5,86 };
        //Length
        Console.WriteLine($"Length: {numbers.Length}");
        // IndexOf()
        var finder = Array.IndexOf(numbers, 86);
        Console.WriteLine($"The Location of 86 is {finder}");
        // Clear()
        Array.Clear(numbers,0,2);
        foreach (var n in numbers)
        {
            Console.WriteLine(n);
        }
        // Copy()
        var another = new[] {1,23,4};
        Array.Copy(numbers,another,3);
        Console.WriteLine("Output of copy():");
        foreach (var n in another)
        {
            Console.WriteLine(n);
        }
        //Sort
        Array.Sort(numbers);
        Console.WriteLine("Effect of Sort(): ");
        foreach (var vNumber in numbers)
        {
            Console.WriteLine(vNumber);
        }
        //Reverse()
        Array.Reverse(numbers);
        Console.WriteLine("Effect of reverse: ");
        foreach (var rNumber in numbers)
        {
            Console.WriteLine(rNumber);
        }
    }
}