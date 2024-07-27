namespace _6._Lists_and_Arrays;

public class Lists //are a dynamic size type, for when we don't know ahead of time how many values we are going to store
{
    public static void lists()
    {
        var numbers = new List<int>();//It is a generic type
        var numbers2 = new List<int>(){1,2,3,4,5,6,7,8,9,0};//when you know the values ahead of time
        var posi = numbers.IndexOf(4);
        numbers.Add(19);
        // You have to iterate over a list or array in order to write each value to the console
        Console.WriteLine(posi);
    }
}