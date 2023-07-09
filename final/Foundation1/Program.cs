using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("'It\'s just a flesh wound'", "the Black Knight", 268);
        Video video2 = new Video("'Show us the Grail!'", "Arthur, King of the Britains", 124);
        Video video3 = new Video("'The Bridge of Death'", "Sir Lancelot", 117);
        Video video4 = new Video("'We Found a Witch!'", "Town's People", 296);

        Comment video1_Comment1 = new Comment("Arthur, King of the Britains", "You're arm's off!");
        Comment video1_Comment2 = new Comment("the Black Knight", "'Tis but a scratch.");
        Comment video1_Comment3 = new Comment("Arthur, King of the Britains", "You liar!");
        Comment video1_Comment4 = new Comment("the Black Knight", "Alright, we'll call it a draw.");

        Comment video2_Comment1 = new Comment("the Frenchie", "You don't frighten us English Pig-Dogs! Go and boil your bottoms!");
        Comment video2_Comment2 = new Comment("Arthur, King of the Britains", "Now look here, good man!");
        Comment video2_Comment3 = new Comment("the Frenchie", "I fart in your general direction! Your mother was a hamster and your father smelled of elderberries!");
        Comment video2_Comment4 = new Comment("the Frenchie", "Fetchez la vache!");

        Comment video3_Comment1 = new Comment("Bridge Keeper", "What is your name?");
        Comment video3_Comment2 = new Comment("Bridge Keeper", "What is your quest?");
        Comment video3_Comment3 = new Comment("Bridge Keeper", "What is your favorite color?");
        Comment video3_Comment4 = new Comment("Bridge Keeper", "What is the air speed velocity of an unladen swallow?");

        Comment video4_Comment1 = new Comment("Sir Bedevere", "How do you know she is a witch?");
        Comment video4_Comment2 = new Comment("Town's person", "Well, she turned me into a newt!");
        Comment video4_Comment3 = new Comment("Sir Bedevere", "A newt?....");
        Comment video4_Comment4 = new Comment("Town's person", "I got better.....");

        video1.CreateCommentList(video1_Comment1);
        video1.CreateCommentList(video1_Comment2);
        video1.CreateCommentList(video1_Comment3);
        video1.CreateCommentList(video1_Comment4);

        video2.CreateCommentList(video2_Comment1);
        video2.CreateCommentList(video2_Comment2);
        video2.CreateCommentList(video2_Comment3);
        video2.CreateCommentList(video2_Comment4);

        video3.CreateCommentList(video3_Comment1);
        video3.CreateCommentList(video3_Comment2);
        video3.CreateCommentList(video3_Comment3);
        video3.CreateCommentList(video3_Comment4);

        video4.CreateCommentList(video4_Comment1);
        video4.CreateCommentList(video4_Comment2);
        video4.CreateCommentList(video4_Comment3);
        video4.CreateCommentList(video4_Comment4);

        video1.DisplayVideoData();
        video2.DisplayVideoData();
        video3.DisplayVideoData();
        video4.DisplayVideoData();
    }

}