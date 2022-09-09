using Social_Media_Post;

Post post1 = new Post
{
    Moment = DateTime.Now,
    Title = "Traveling to New Zealand",
    Content = "I'm going to visit this wonderful county!",
    TotLikes = 12
};
post1.AddComment(new Comment("liiiindoooo", DateTime.Now.AddDays(5)));
post1.AddComment(new Comment("que mara", DateTime.Now.AddDays(6)));

Post post2 = new Post
{
    Moment = DateTime.Now.AddHours(8).AddDays(10),
    Title = "Good night guys",
    Content = "See you tomorrow",
    TotLikes = 5
};

post2.AddComment(new Comment("boa man", DateTime.Now.AddHours(3)));


Console.WriteLine();
Console.WriteLine(post1.ToString());
Console.WriteLine();
Console.WriteLine(post2.ToString());