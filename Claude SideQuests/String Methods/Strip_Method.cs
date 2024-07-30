// See https://aka.ms/new-console-template for more information
public abstract class Strip1Method
{
    public static void Strip_Method()
    {
    string str = "apple,banana,orange";
    string[] fruits = str.Split(','); // ["apple", "banana", "orange"]
    Console.WriteLine(fruits[1] + fruits[0] );
    
    }
}
