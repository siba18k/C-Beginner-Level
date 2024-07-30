namespace Claude_SideQuests.String_Methods;

public class SubStringMethod
{
    public void Susbstring()
    {
        string str = "Hello, World!";
        string sub1 = str.Substring(7); // "World!"
        string sub2 = str.Substring(0, 5); // "Hello"
        Console.WriteLine(sub1);
        Console.WriteLine(sub2);
    } 
}