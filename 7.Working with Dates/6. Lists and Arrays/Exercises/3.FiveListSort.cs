namespace _6._Lists_and_Arrays.Exercises;

public class FiveNumSort
{
    // static void Main(string[] args)
    public static void fNumSort()
    {
        Console.WriteLine(@"Number Sorter
Type 5 Numbers and I'll sort them");
        var listNum = new List<int>();
        while (listNum.Count < 5)
        {
            try
            {
                Console.Write("Type a number: ");
                var num = int.Parse(Console.ReadLine());

                if (listNum.Contains(num))
                {
                    Console.WriteLine("You've repeated the number try again");
                    continue;
                }

                listNum.Add(num);

                listNum.Sort();
                

            }
            catch (FormatException)
            {
                Console.WriteLine("Please don't leave any blank spaces");
                continue;
            }
        }
        Console.WriteLine("Result:");
        foreach (var n in listNum)
        {
            Console.Write($"{n},");

        }
    }
}