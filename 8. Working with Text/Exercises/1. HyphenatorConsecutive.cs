using System.Text;

namespace Working_with_Text.Exercises;

public class HyphenatorConsec
{
    public static void hypehnatorConsec()
    {
        Console.Write("Enter consecutive numbers separated by hyphens: ");
        var hypnum = Console.ReadLine();

        var splitnums = hypnum.Split('-');
        var intnums = splitnums.Select(int.Parse).ToArray();

        bool isConsecutive = IsConsecutive(intnums);
        HyphenatorDuplicate.DuplicateChecker(intnums);

        
        Console.WriteLine(isConsecutive ? "Consecutive" : "Not Consecutive");
       

    
    }
    static bool IsConsecutive(int[] numbers)
             {
                 if (numbers.Length <= 1) //If there are 0 or 1 numbers, we consider them consecutive by default.
                 {
                     return true;
                 }

                 var difference = numbers[1] - numbers[0];//We calculate the difference between the first two numbers.

                 for (var i = 2; i < numbers.Length; i++)
                 {
                     if (numbers[i] - numbers[i-1] != difference)
                     {
                         return false;
                     }
                 }

                 return true;
             }
}