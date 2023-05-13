namespace MyMauiApp;

public partial class VideoPage : ContentPage
{
    public VideoPage()
    {
        InitializeComponent();
        BindingContext = this;
    }

    public double VideoWidth => AppState.Width - 40;
    public double VideoHeight
    {
        get
        {
#if WINDOWS || MACCATALYST
            return AppState.Height - 100;
#else
            return 300;
#endif
        }
    }
}
