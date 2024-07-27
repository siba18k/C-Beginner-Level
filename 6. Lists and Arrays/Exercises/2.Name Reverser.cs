namespace _6._Lists_and_Arrays.Exercises;

public class Name_Reverser 
{
    // static void Main(string[] args)
    public static void name_Reverser()
    {
        Console.Write("Enter your name and I'll reverse it: ");
        var name = Console.ReadLine();
        var nlist = new List<char>(name);
        
        nlist.Reverse();

        var strName = new string(nlist.ToArray());
        Console.WriteLine(strName);
        // foreach (var n in nlist)
        // {
        //     Console.Write(n);
        // }

    }
    
}