using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace MyMauiApp.ViewModels;

public class BlogPostOldViewModel : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler PropertyChanged;

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
    
    private DateTime publishDate;
    public DateTime PublishDate
    {
        get => publishDate;
        set => Set(ref publishDate, value);
    }

    private string author;
    public string Author
    {
        get => author;
        set
        {
            author = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Author"));
        }
    }

    private string title;
    public string Title
    {
        get => title;
        set => Set(ref title, value);
    }

    private string description;
    public string Description
    {
        get => description;
        set => Set(ref description, value);
    }

    private string content;
    public string Content
    {
        get => content;
        set => Set(ref content, value);
    }

    private string message;
    public string Message
    {
        get => message;
        set => Set(ref message, value);
    }

    private ICommand saveCommand;
    public ICommand SaveCommand => saveCommand ??= new Command(() =>
    {
        _blogPost.PublishDate = PublishDate;
        _blogPost.Author = Author;
        _blogPost.Title = Title;
        _blogPost.Description = Description;
        _blogPost.Content = Content;
        
        // Save stuff here

        Message = $"Saved at {DateTime.Now.ToLongTimeString()}";
    });

    private bool Set<T>(ref T field, T newValue, 
        [CallerMemberName] string propertyName = null)
    {
        if (!EqualityComparer<T>.Default.Equals(field, newValue))
        {
            field = newValue;
            PropertyChanged?.Invoke(this, 
                new PropertyChangedEventArgs(propertyName));
            return true;
        }
        return false;
    }
}
