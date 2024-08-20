public class Arrays
{
    public static void arrays()
    {
        //Single Dimension Arrays 
        var numbers = new int[5];
        var numbers2 = new int[5]{1,2,3,4,5};
        Console.WriteLine($"{numbers[0]} and {numbers2[1]}");
        
        // Multi Dimension Arrays
        var rectarray = new int[3, 5] //You need to specify the dimensions of the array
        {//For when you know the values ahead of time
            { 1, 2, 3, 4, 5 },
            { 6, 7, 8, 9, 10 },
            { 11, 12, 13, 14, 15 }
        };
        var element = rectarray[2, 3];//This is called a 2D array
        Console.WriteLine(element);

        var reccubearray = new int[3, 5, 4];
        
        // Syntax(Jagged) Array 
        //A jagged array is an array that contains other arrays
        var jagged = new int[3][];//Jagged has two square brackets
        jagged[0]=new int[3];
        jagged[1]=new int[4];
        jagged[2]=new int[5];

        jagged[0][0] = 1;
        Console.WriteLine(jagged[0][0]);
        var length = jagged.Length;
        Console.WriteLine($"The array has {length} values");

    }
}