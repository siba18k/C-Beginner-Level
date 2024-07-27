public class Person
{
    public string FirstName;
    public string LastName;

    public void Greet()
    {
        Console.WriteLine("Hello there "+ FirstName+" welcome to the simaulation");
        Console.WriteLine("I see that your surname is "+LastName+" as well" +
                          "\nWe surely do live in the matrix.");
    }
}