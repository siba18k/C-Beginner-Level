namespace _4._Non_Primitive_Types;

public class Person
{
    public int Age;
}

public class Enum_Program
{
    public static void DemoRefernceTypesAndValues()
    {
        var number = 1;
        Increment(number);
        Console.WriteLine(number);

        var person = new Person(){Age = 20};
        MakeOld(person);
        Console.WriteLine(person.Age);
        
    }

    public static void Increment(int number)
    {
        number += 10;
    }

    public static void MakeOld(Person person)
    {
        person.Age += 10;
    }
}