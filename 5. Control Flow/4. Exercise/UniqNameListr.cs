namespace _5._Control_Flow._4._Exercise;

public class UniqNameListr
{
    public static void uniqNamelistr()
    {
        Console.WriteLine("Name Lister\n");
        var NameList = new HashSet<string>();
        while (true)
        {
            Console.Write("Enter the name of the thing you're thinking about[leave blank or 'done' to escape]: ");
            var name = Console.ReadLine();
            if (!string.IsNullOrEmpty(name))
            {
                NameList.Add(name);
                Console.WriteLine($"'{name}' was added to the list of names");
            }

            if (string.IsNullOrWhiteSpace(name)| name == "done")
            {
                Console.WriteLine("Preparing List for viewing");
                Console.WriteLine("This is the list of things on your mind are ");
                foreach (var n in NameList)
                {
                    Console.Write($" {n} ;");
                }
                break;
            }
        }
    }
}