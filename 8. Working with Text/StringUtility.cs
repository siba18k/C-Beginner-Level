namespace Working_with_Text;

public class StringUtility
{
   public static string SummarizeText(string text,int maxLength = 20)
    {
        if (text.Length < maxLength)
        {
            Console.WriteLine(text);
        }
        
        else
        {
            var words = text.Split(" ");
            var charcount = 0;
            var summaryWords = new List<string>();
            foreach (var word in words)
            {
                summaryWords.Add(word);

                charcount += word.Length + 1;
                if (charcount > maxLength)
                {
                    break;
                }
            }

            return string.Join("  ", summaryWords) + "...";

        }

        return null;
    }
}