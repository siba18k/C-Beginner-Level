namespace Working_with_Text;

public class StringS
{
    public static void string_s()
    {
        Console.WriteLine("Hello World".ToLower());
        Console.WriteLine("Hello World".ToUpper());
        Console.WriteLine("    Hello My Fwiend   ".Trim());
        Console.WriteLine("Marshall".IndexOf('a'));
        Console.WriteLine("Hallo Combat Evolved".LastIndexOf('C'));
        Console.WriteLine("Hallo Combat Evolved".Substring(0));//Prints the whole string
        Console.WriteLine("Hallo Combat Evolved".Substring(0,5));//Slices the string
        Console.WriteLine("Hallo Combat Evolved".Replace("ll", "l"));
        
        //Null Checkin
        string.IsNullOrEmpty("");
        string.IsNullOrWhiteSpace("");
        
        //Splitting
        var italy = "Baggio played for italy".Split(' ');//will return array of strings
        
        //Converting
        // var s = "1234";
        // int i = int.Parse(s);
        // var j = Convert.ToInt32(s);
        
        //Converting Numbers to Strings
        var s = 1234;
        var si = s.ToString();
        var t = s.ToString("C");
        var ti = s.ToString("C0");//For when you want no decimal places 
        Console.WriteLine($"{si}\n{t}\n{ti}");




    }
}