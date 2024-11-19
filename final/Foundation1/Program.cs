using System;

class Program
{
    static void Main(string[] args)
    {

        // Console.WriteLine("Hello Foundation1 World!");

        Video obstacleVideo = new Video("World's Deadliest Obstacle Course!", "Mr. Beast", 1705);
        Comment obstacleComment1 = new Comment( "@Elianidelacruz47","I love how karl was just so supportive and kind to Mac.");
        Comment obstacleComment2 = new Comment("@matiou6723", "First thing he thought about doing with the money is helping his friends. He is truly a hero.");
        Comment obstacleComment3 = new Comment("@JADIAZ", "Let's push to 300M!");

        obstacleVideo.AddComment(obstacleComment1);
        obstacleVideo.AddComment(obstacleComment2);
        obstacleVideo.AddComment(obstacleComment3);

        Video townVideo = new Video("Littleroot Town", "Joshua Sandoval", 48);
        Comment townComment1 = new Comment( "@souly2995","It only took 48 seconds to fall asleep yesterday.");
        Comment townComment2 = new Comment("@PsychicStoryteller", "This is one of those internet checkpoints.");
        Comment townComment3 = new Comment("@simong.3068", "Honestly, this is extremely beautiful.");

        townVideo.AddComment(townComment1);
        townVideo.AddComment(townComment2);
        townVideo.AddComment(townComment3);

        Video beatVideo = new Video("Worst rap beat in existence", "SwehgBone", 59);
        Comment beatComment1 = new Comment("@Get_yotted","I lost it here");
        Comment beatComment2 = new Comment("@thecatthatgotaway", "When you have no internet and play garage band for 3 hours");
        Comment beatComment3 = new Comment("@BigFish437", "I love the part where it ends.");

        beatVideo.AddComment(beatComment1);
        beatVideo.AddComment(beatComment2);
        beatVideo.AddComment(beatComment3);

        List<Video> videoList = new List<Video>{
            obstacleVideo,
            townVideo,
            beatVideo
        };

        foreach (Video video in videoList)
        {
            video.DisplayVideoInformation();
            foreach (Comment comment in video.GetCommentList())
            {
                comment.DisplayCommentInformation();
            }
            Console.WriteLine();
        }
    }
}