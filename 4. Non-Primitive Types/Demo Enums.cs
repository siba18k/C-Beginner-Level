namespace _4._Non_Primitive_Types;
//Because Enum is a new type we need to define it at the database level
public enum ShippingMethod
{
    RegularAirMAil = 1,
    RegisteredAirMail =2,
    Express = 3
}
public static class Demo_Enums
{
    public static void DemoEnums()
    {
        var method = ShippingMethod.Express;
        Console.WriteLine((int)method);//You have to cast it to an (int) if you want it to return the value in the console
        
        var methoID = 3;
        Console.WriteLine((ShippingMethod)methoID);//The number 3 represent the .Express ShippingMethod

        Console.WriteLine(method.ToString()); //ToString() is used automatically in Console.WriteLine
        // But you can use ToString() if you are not using Console.WriteLine()
        
        //Parsing in programming is getting a string and converting that to a new type
        var methodName = "Express";
        var shippngskippper = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);
        Console.WriteLine(shippngskippper);
    }
}