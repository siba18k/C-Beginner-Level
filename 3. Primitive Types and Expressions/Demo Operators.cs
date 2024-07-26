namespace Hello_Galaxy;

public class Dem0_0perators
{
    public static void demo_Operators()
    {
        var a = 1;
        var b = 2;
        var c = 3;
        Console.WriteLine((a + b)*c);//BODMAS applies to C# so Brackets takes precedence over Multiplication
        Console.WriteLine((float)a/(float)b);
        Console.WriteLine(a > b);
        Console.WriteLine(a == b);
        Console.WriteLine(a != b);
        Console.WriteLine(!(a != b));//In situations with double negatives always invert the double negatives 
        // into a positive e.g Console.WriteLine(a == b)
        Console.WriteLine(c>b && c>a);// AND 
        Console.WriteLine(c>b || c==a);// OR
        Console.WriteLine(!(c > b || c == a));//Changes true to false(Probably wont be used 
        
    }
}