namespace Working_with_Text.StringsUtility;

public class Live_Coding_Summarising_Text
{
    public static void live_coding_Summarising_Text()
    {
        var sentence = "This text took me a really really really really really really really really really really really really really really really really really really really really long time to type";
        var summary = StringUtility.SummarizeText(sentence,50);
        Console.WriteLine(summary);
    }
}