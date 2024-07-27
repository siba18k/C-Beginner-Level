namespace _6._Lists_and_Arrays;

public class Demo_Lists
{
    public static void demo_list()
    // static void Main(string[] args)
    {
        var numberlist = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };
        numberlist.Add(9);
        numberlist.AddRange(new List<int>(){21,22,23,24,25,21});//Whenever you see IEnumerable you can use an array or a list
        foreach (var n in numberlist)
        {
            Console.WriteLine(n);
        }

        Console.WriteLine();
        Console.WriteLine($"The index of 21 is: {numberlist.IndexOf(21)}");//Beginning of List
        Console.WriteLine($"The index of 21 is: {numberlist.LastIndexOf(21)}");//End of List
        Console.WriteLine($"Count: {numberlist.Count}");//Counts number of values in the list

        Console.WriteLine();
        numberlist.Remove(21);
        Console.WriteLine("Result after removal:");
        foreach (var n in numberlist)
        {
            Console.WriteLine(n);
        }

        Console.WriteLine();
        var onelist = new List<int>{ 1, 0, 2, 1, 2, 1, 22, 1, 2, 32 };  
        // foreach (var o in onelist)//In C# we are not allowed to modify our collection inside a foreach loop
        // {
        //     if (o == 1)
        //         onelist.Remove(o); //This modifying a collection
        // }
        
        //We need to use a normal for loop without throwing an exception
        for (var i = 0; i < onelist.Count; i++)
        {
            if (onelist[i] == 1)
                onelist.Remove(onelist[i]); 
        }
        foreach (var o in onelist)
        {
            Console.WriteLine(o);

        }
        onelist.Clear();
        Console.WriteLine($"Count: {onelist.Count}");//Counts number of values in the list

    }
}
