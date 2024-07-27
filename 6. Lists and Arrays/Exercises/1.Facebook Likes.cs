namespace _6._Lists_and_Arrays.Exercises;

public class Facebook_Likes
{
    public static void facebook_likes()
    {
        Console.WriteLine("Facebook Post Spy 2024");
        var like_list = new List<string>();
        var like_count = 0;      
        
        while (true)
        {
            Console.Write("Enter the name of person who liked your Facebook post[leave blank to exit]: ");
            var acc_name = Console.ReadLine();
            like_list.Add(acc_name);
            if (String.IsNullOrWhiteSpace(acc_name))
            {
                break;
            }
            like_count += 1;
        }
        

        if (like_count == 0)
        {
            Console.WriteLine("Another likeless post");
        }
        
        else if (like_count == 1)
        {
                Console.WriteLine($"{like_list[0]} has liked your post");
        }
        else if (like_count == 2)
        {
                var name1 = like_list[0]; 
                var name2 = like_list[1]; 
                Console.WriteLine($"{name1} and {name2} have liked your post");
        }
        else if (like_count >= 3)
        {
            var name1 = like_list[0]; 
            var name2 = like_list[1]; 
            Console.WriteLine($"{name1} and {name2} and {like_count - 2} other people have liked your post");
            
        }
    }
}