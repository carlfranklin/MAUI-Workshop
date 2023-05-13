namespace MyMauiApp;

public partial class MVVMPage : ContentPage
{
    //apublic BlogPostOldViewModel ViewModel { get; private set; }
    public BlogPostNewViewModel ViewModel { get; private set; }

    public MVVMPage()
    {
        InitializeComponent();

        // instantiate and initialize the ViewModel

        //ViewModel = new BlogPostOldViewModel();
        ViewModel = new BlogPostNewViewModel();

        var blogPost = new BlogPost()
        {
            PublishDate = DateTime.Now,
            Author = "Carl Franklin",
            Title = "The MVVM Community Toolkit Rocks!",
            Description = "Less code is better",
            Content = "The MVVM Community Toolkit lets " +
                "you easily create ViewModels that" +
                "with code generation and no INotifyPropertyChanged goo!"
        };
        ViewModel.Initialize(blogPost);

        // Set the page's Binding Context
        BindingContext = ViewModel;
    }
}
