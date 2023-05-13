namespace MyMauiApp.ViewModels;

public partial class BlogPostNewViewModel : ObservableObject
{
    private BlogPost _blogPost;

    public void Initialize(BlogPost blogPost)
    {
        PublishDate = blogPost.PublishDate;
        Author = blogPost.Author;
        Title = blogPost.Title;
        Description = blogPost.Description;
        Content = blogPost.Content;
        _blogPost = blogPost;
    }

    [ObservableProperty]
    private DateTime publishDate;

    [ObservableProperty]
    private string author;

    [ObservableProperty]
    private string title;

    [ObservableProperty]
    private string description;

    [ObservableProperty]
    private string content;

    [ObservableProperty]
    private string message;

    [RelayCommand]
    private void Save()
    {
        _blogPost.PublishDate = PublishDate;
        _blogPost.Author = Author;
        _blogPost.Title = Title;
        _blogPost.Description = Description;
        _blogPost.Content = Content;

        // Save stuff here

        Message = $"Saved at {DateTime.Now.ToLongTimeString()}";
    }
}
