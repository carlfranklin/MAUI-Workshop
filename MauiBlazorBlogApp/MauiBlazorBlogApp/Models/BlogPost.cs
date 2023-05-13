namespace MauiBlazorBlogApp.Models;

public class BlogPost
{
    public DateTime PublishDate { get; set; }
    public string Author { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Content { get; set; } = string.Empty;
}
