public class Typeconv
{
    public static void typeconv()
    {
        // byte b = 1;
        // int i = b;
        // Console.WriteLine(i); //This compiles

        int i = 1;
        byte b = (byte)i;//Like so
        Console.WriteLine(b); //This won't compile unless it is casted "(byte)" and it wont lose data because the 
        // max value in a bit is 255
        
        // But what if we go over 255?
        int over = 1000;
        byte under = (byte)over;//Like so
        Console.WriteLine(under); //we get 232 because some of the bits were lost
        
        // Non-Compatible Types:
        var number = "1234";
        var num = int.Parse(number);
        Console.WriteLine(num);
        try
        {
            // Non-Compatible Types:
            var numberc = "1234";//Byte can only be from 1 to 255
            byte numc = byte.Parse(numberc);
            Console.WriteLine(numc);
        }
        catch (Exception)
        {
            Console.WriteLine("The number could not be converted to a byte");
        }

        try
        {
            var str = "tru3"; //"true" will output True - Which is correct"
            bool rght = bool.Parse(str);
            Console.WriteLine(rght);
        }
        catch (Exception)
        {
            Console.WriteLine("Not a Boolean bro");
            
        }
    }
}