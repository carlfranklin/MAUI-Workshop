namespace MyMauiApp;

public partial class BlogPage : ContentPage
{
    public BlogPage()
    {
        InitializeComponent();
        BindingContext = this;
        BlogDataManager.GetBlogPosts();
    }

    public List<BlogPost> BlogPosts => BlogDataManager.BlogPosts;

    public int Column2Width => Convert.ToInt32(AppState.Width) - 180;
    public int ContentWidth => Convert.ToInt32(AppState.Width) - 100;
}
