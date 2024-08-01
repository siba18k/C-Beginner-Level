namespace Working_with_Text;

public class DemoStrings
{
    public static void _demo_string_s()
    {
        var fulname = " Sibahle Dube ";
        Console.WriteLine("Trim: '{0}'",fulname.Trim());
        Console.WriteLine("Upper Trimmmed: '{0}'",fulname.ToUpper().Trim());
        
        var fultrim = fulname.Trim();

        //This is good to know if you're gonna doing complex string processing
        var index = fultrim.IndexOf(' ');
        var firstname = fultrim.Substring(0,index); // So "Sibahle"
        var lastname = fultrim.Substring(index + 1);//Index + 1 till the end so: ' ' until "Dube"
        Console.WriteLine($"Firstname: {firstname}\nLastname: {lastname}");
        
        
        //Theres an easier way of doing this using the Split Method
        var names = fulname.Split(" ");
        Console.WriteLine($"Fistname: {names[1]}\nLastname: {names[2]} ");

        //Replace
        Console.WriteLine($"Replaced name: {fulname.Replace("Sibahle", "Tanaka")}");//The original string is not affected 

        //IsNullOrWhiteSpace
        if (string.IsNullOrWhiteSpace(" "))
        {
            Console.WriteLine("Invalid");
        }

        
        var str = "20";
        var num = int.Parse(str);
        var tooFar = num + 100;
        Console.WriteLine($"Your age is: {tooFar}");
        Console.WriteLine();

        float price = 25.90f;
        var currprice =  price.ToString("C2");//Curency with 2 decimal points  
        Console.WriteLine($"The price of Bread today is: {currprice}");
    }
}