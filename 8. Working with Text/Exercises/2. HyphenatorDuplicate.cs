namespace Working_with_Text.Exercises;

public class HyphenatorDuplicate {
    public static void hypenatorduplicate()
    {
        Console.Write("Enter a series of numbers separated by hypens: ");
        var hyphennumbers = Console.ReadLine();

        var stringList = hyphennumbers.Split('-');
        var integerList = stringList.Select(int.Parse).ToArray();

        bool isDup = DuplicateChecker(integerList);
        Console.WriteLine(isDup ? "Duplicate":"Not Duplicate" );

    }

   public static bool DuplicateChecker(int[] numbers)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers.Length <= 1) 
            {
                return false;
            }
            
            if (numbers[i+1] == numbers[i])
            {
                return true;
            }
            else if (numbers[i] != numbers[i+1])
            {
                return false;
            }
            
        }

        return true;
    }
}