using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Learn C# Programming","Sarah Johnson", 300);
        video1.AddComment(new Comment("Alice","Great explanation, very clear!"));
        video1.AddComment(new Comment("Bob","Loved the examples, thank you!"));
        video1.AddComment(new Comment("Charlie","Finally understood the basics, thanks!"));

        Video video2 = new Video("Virtual Tour of Paris","Emily Brown", 500);
        video2.AddComment(new Comment("Noah","What a beautiful place, I hope to visit someday."));
        video2.AddComment(new Comment("Olivia","Thanks for sharing this experience."));
        video2.AddComment(new Comment("James","Loved the video, Paris is amazing."));

        Video video3 = new Video("Home Workout Routine","David Wilson", 600);
        video3.AddComment(new Comment("Ava","Just what I needed, thanks!"));
        video3.AddComment(new Comment("Michael","Great exercises, starting tomorrow."));
        video3.AddComment(new Comment("Isabella","Easy to follow and very effective."));

        Video video4 = new Video("2024 Smartphone Comparison","TechGuru Alex", 200);
        video4.AddComment(new Comment("Jessica","Your reviews are always so thorough. This helped me decide on my next phone purchase."));
        video4.AddComment(new Comment("John","I agree, TechGuru Alex provides great information."));
        video4.AddComment(new Comment("Mary","I appreciate the unbiased opinions. Keep up the great work!"));
        video4.AddComment(new Comment("Rachel","Could you do a follow-up video on the battery life of these phones?"));

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        videos.Add(video4);
        
        foreach (var video in videos)
        {
            Console.WriteLine(video.ShowVideoInfo());
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");

            List<Comment> comments = video.GetComments();

            foreach (var comment in comments)
            {
                Console.WriteLine(comment.ShowCommentInfo());
            }

        Console.WriteLine();
        
        }
    }
}