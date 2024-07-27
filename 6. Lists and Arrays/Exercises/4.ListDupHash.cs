namespace _6._Lists_and_Arrays.Exercises;

public class _ListDupHash {
    // static void Main(string[] args)
    public static void _listDupHash()
    {
        Console.WriteLine("List Duplicate Sorter");
        var uniqueList = new HashSet<int>();
        while (true)
        {
            Console.Write("Enter as many numbers as you want['Quit' to stop]: ");
            var numInput = Console.ReadLine();
            if (numInput.ToLower() == "Quit" | String.IsNullOrWhiteSpace(numInput))
            {
                break;
            }
            uniqueList.Add(int.Parse(numInput));//Remember to .Parse() after break; condition
        }
        foreach (var n in uniqueList)
        {
            Console.WriteLine(n);
        }
    }
}