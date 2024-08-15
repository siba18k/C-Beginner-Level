namespace Working_With_Files
{
    public class Demo_File_and_FileInfo
    {
        public static void demo_File_and_FileInfo()
        {
            // File provides static method
            var path = @"C:\Mini SSD\Delete Me.txt";
            File.Copy(@"C:\Users\dubes\RiderProjects\CSharp-Beginner-Level\9.Working With Files\Copy.txt",
                @"C:\Users\dubes\RiderProjects\CSharp-Beginner-Level\9.Working With Files\Paste\Pasted.txt",
                true);
            if (File.Exists(path))
            {
                File.Delete(path);
                Console.WriteLine("Done");

            }
            else
            {
                File.Create(@"C:\Mini SSD\I AM 2 REBORN!!!.txt");
                Console.WriteLine("Done");
            }

            var Rebpath = @"C:\Mini SSD\I AM REBORN!!!.txt";
            Console.WriteLine(File.ReadAllText(Rebpath));
            
            
            // FileInfo methods are more performace friendly 
            
            var FileInfo = new FileInfo(Rebpath);
            // FileInfo.Delete();
            FileInfo.CopyTo(@"C:\Mini SSD\I AMREBORN!!!.txt");//This copies the contents of a file to an existing file
            // to a new file 
            // FileInfo.Exist is a property, not a method
            if (FileInfo.Exists)
            {
                Console.WriteLine("It works kiddo");
            }

            var directoryInfo = new DirectoryInfo(@"C:\Users\dubes\RiderProjects\CSharp-Beginner-Level");
            directoryInfo.GetFiles();
            
        }
        
    }
}

