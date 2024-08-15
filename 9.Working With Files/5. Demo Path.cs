public class Demo_Path
{
    public static void demo_Path()
    {
        var path = @"C:\Users\dubes\RiderProjects\CSharp-Beginner-Level\8. Working with Text\8. Working with Text.sln";
        Console.WriteLine($"Extension: {Path.GetExtension(path)}");
        Console.WriteLine($"Full Path: {Path.GetFullPath(path)}");
        Console.WriteLine($"Full Filename: {Path.GetFileName(path)}");
        Console.WriteLine($"Extension: {Path.GetExtension(path)}");
        
        
    }
}