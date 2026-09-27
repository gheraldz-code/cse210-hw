using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");
        string theTitle;
        string theAuthor;
        int theLength;
        int quantityOfVideos;
        List<Video> videoList = new List<Video>();
        
        theTitle = "A Million Dreams - The Greatest Showman Broadway";
        theAuthor = "One Voice Children's Choir";
        theLength = 293;
        Video video1 = new Video(theTitle, theAuthor, theLength);
        Comment firstComment = new Comment("@halyn423","Never have I ever seen a single choir deliver such consistently magnificent performances. All of you are amazing!");
        video1.AddComment(firstComment);
        Comment secondComment = new Comment("@kingcraig7629","I am going to be singing this at my sister birthday 🎂 and I liked my own comment 😢");
        video1.AddComment(secondComment);
        Comment thirdComment = new Comment("@virginiacampos5575","While the children in this choir are all so talented, I want to give a shout out to the director. To know what voices to blend takes a talent. Well done");
        video1.AddComment(thirdComment);
        videoList.Add(video1);

        theTitle = "The Character of Christ";
        theAuthor = "D. Todd Christofferson";
        theLength = 730;
        Video video2 = new Video(theTitle, theAuthor, theLength);
        Comment comment04 = new Comment("@다나-f87","If we are to succeed in developing a Christlike Character, we must possess His motivations—His thoughts, desires, and intents of the heart.");
        video2.AddComment(comment04);
        Comment comment05 = new Comment("@derekotsuji9037","\"Look to the needs of others and humility follows\" That will be my motto going forward.");
        video2.AddComment(comment05);
        Comment comment06 = new Comment("@Pinkmeg1989","One of my favorite talks this conference.");
        video2.AddComment(comment06);
        videoList.Add(video2);

        theTitle = "When the Savior Comes Again";
        theAuthor = "Angelic Faithful Voice";
        theLength = 242;
        Video video3 = new Video(theTitle, theAuthor, theLength);
        Comment comment07 = new Comment("@KevinReeve","There are approximately 2 billion kids 0 -14 years old on the earth today.   What a chorus that will be when he comes again!");
        video3.AddComment(comment07);
        Comment comment08 = new Comment("@dkiddos7184","Hello everyone I had a blessing happen to me and I was able to sing with this choir I was so grateful thank you for all your kind supportive comments it was such a blessing to sing with children like me who know that Jesus is our savior and redeemer and it will be a joyful day when our beloved savior comes again");
        video3.AddComment(comment08);
        Comment comment09 = new Comment("@MeriL1980","These children had angels singing with them… or are they the angels? How could you not shed a tear or two? This was incredible!! ❤");
        video3.AddComment(comment09);
        videoList.Add(video3);

        foreach (Video item in videoList)
        {
            Console.WriteLine($"Title: {item.GetTitle()}");
            Console.WriteLine($"Author: {item.GetAuthor()}");
            Console.WriteLine($"Length: {item.GetLength()}");
            quantityOfVideos = item.QuantityOfComments();
            Console.WriteLine($"Quantity of comments: {quantityOfVideos}");
            Console.WriteLine(item.GetComment());
            Console.WriteLine();
        }
    }
}