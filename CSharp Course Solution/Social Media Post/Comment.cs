namespace Social_Media_Post;

public class Comment
{
    public Comment(string text, DateTime moment)
    {
        Text = text;
        Moment = moment;
    }
    
    public DateTime Moment { get; set; }
    public string Text { get; set; }
} 