using System.Text;

namespace Social_Media_Post;

public class Post
{
    public string Title { get; set; }
    public DateTime Moment { get; set; }
    public string Content { get; set; }
    public int TotLikes { get; set; }

    private List<Comment> Comments { get; set; } = new List<Comment>();
    public void AddComment(Comment comment) => Comments.Add(comment);
    public void RemoveComment(Comment comment) => Comments.Remove(comment);

    public Post() {}
    public Post(DateTime moment, string title, string content, int totLikes)
    {
        Moment = moment;
        Title = title;
        Content = content;
        this.TotLikes = totLikes;
    }
    
    public override string ToString()
    {
        StringBuilder builder = new StringBuilder();
        
        builder.AppendLine($"{Title} ({Moment.ToString("d/M/yy hh:mm")})");
        builder.AppendLine(Content);
        builder.AppendLine("=======================");
        builder.AppendLine($"LIKES: {TotLikes}");
        builder.AppendLine("=======================");

        foreach (Comment comment in Comments)
            builder.AppendLine($"{comment.Text} ({comment.Moment.ToString("d/M/yy hh:mm")})");
        
        return builder.ToString();
    }
}