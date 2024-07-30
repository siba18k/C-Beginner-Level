namespace Working_with_Text;
using System.Text;

public class DemoStringBulider
{
    public static void demo_stringbuilder()//easy and fast to create a string and modify it on the fly
    {//Remember that with stringbuilder you wont get string  searching methods, it's all about manipulation
        var builder = new StringBuilder("Hello Word");
            builder
              .AppendLine()
              .Append('-', 10)
              .AppendLine()
              .Append("Header")
              .AppendLine()
              .Append('-', 10)
              .Replace('-', '*');
        
        // builder.Remove(0, 10);
        // builder.Insert(0, new string('+',10));
        Console.WriteLine(builder);

        Console.WriteLine($"First Char:  {builder[0]}");
        
    }
}