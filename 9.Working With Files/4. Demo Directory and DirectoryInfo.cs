public class Demo_Dir_and_DirInfo
{
    public static void demo_dir_and_Dir_Info()
    {
        Directory.CreateDirectory(@"C:\Users\dubes\RiderProjects\CSharp-Beginner-Level\9.Working With Files\Created Directory");
        var Gotfiles = Directory.GetFiles(@"C:\Users\dubes\RiderProjects\CSharp-Beginner-Level\9.Working With Files\Paste"
            ,"*.txt",SearchOption.AllDirectories);
        foreach (var VARIABLE in Gotfiles)
        {
            Console.Write(VARIABLE);
        }

        var director = Directory.GetDirectories(@"C:\Users\dubes\RiderProjects\CSharp-Beginner-Level"
            ,"*.cs",SearchOption.AllDirectories);
        foreach (var dir in director)
        {
            Console.Write(director);
        }

        if (Directory.Exists(@"C:\Users\dubes\RiderProjects\CSharp-Beginner-Level"))
        {
            Console.WriteLine("\nIt exists bruv");
        }
    }
}
