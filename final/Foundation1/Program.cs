using System;

class Program
{


    static void Main(string[] args)
    {
        //I wanted to make up the videos for fun
        Video video1 = new Video("How to find nickel in Subnautica", "The Alien Fish Guy", 492);
        video1.AddComment(new Comment("smallChinchilla", "Thanks for making this, I almost lost my prawn suit to a ghost leviathan while looking for some nickel for the neptune rocket"));
        video1.AddComment(new Comment("PURPLEGUY", "idk why this was reccomended to me i dont even play this game"));
        video1.AddComment(new Comment("number1peeperfan", "You still have to swim by crab squids to get there???"));

        Video video2 = new Video("A look at the history of shark fearmongering", "Bio Historian", 1656);
        video2.AddComment(new Comment("GothShark_uwu", "I'm so glad Peter Benchley spend the rest of his life trying to save sharks... just imagine how what happened weighed on the poor guys mind"));
        video2.AddComment(new Comment("adrienne3756", "Wow, I didn't know this! :O"));
        video2.AddComment(new Comment("darthbubba", "i dont care im still gonna watch jaws"));
        video2.AddComment(new Comment("quizzLlamma", "can't beleive people thought those bites were from turtles lol"));

        Video video3 = new Video("I GAVE ONE LUCKY CODER A NEW FREE COMPUTER | Mr Code Beast C# Tournament Vlogging", "Mr Code Beast", 993);
        video3.AddComment(new Comment("JarvisTube", "MR CODE BEAST!!!"));
        video3.AddComment(new Comment("coolsnail67", "MR CODE BEAST!!!"));
        video3.AddComment(new Comment("IRateCheese", "MR CODE BEAST!!!"));
        video3.AddComment(new Comment("mrcodebeastfan!!","guys can we stop with the meme it isnt funny :/"));
        video3.AddComment(new Comment("justin6784", "mr code beast can u buy me a computer my mom took mine"));
        video3.AddComment(new Comment("ieatsand^^", "MR CODE BEAST!!!"));



        List<Video> videos = new List<Video> { video1, video2, video3 };

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.VideoSeconds} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"{comment.User}: {comment.Text}");
            }
            Console.WriteLine();
        }
    }


}