namespace Task_Practice;

public class Post
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Topic { get; set; }

    public Post(Guid id, string title, string topic)
    {
        Id = id;
        Title = title;
        Topic = topic;
    }
}