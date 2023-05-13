namespace MyMauiApp;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        MainPage = new AppShell();
    }

    protected override Window CreateWindow
        (IActivationState activationState)
    {
        var window = base.CreateWindow(activationState);
#if WINDOWS || MACCATALYST
        window.Created += Window_Created;
        window.SizeChanged += Window_SizeChanged;
#else
        AppState.Width = DeviceDisplay.Current.MainDisplayInfo.Width;
        AppState.Height = DeviceDisplay.Current.MainDisplayInfo.Height;
#endif
        return window;
    }

    private void Window_SizeChanged(object sender, EventArgs e)
    {
#if WINDOWS || MACCATALYST
        var window = (Window)sender;
        AppState.Width = window.Width;
        AppState.Height = window.Height;
#endif
    }

    private async void Window_Created(object sender, EventArgs e)
    {
        await Task.Delay(0);
#if WINDOWS || MACCATALYST
        const int defaultWidth = 1280;
        const int defaultHeight = 720;

        var window = (Window)sender;
        window.Width = defaultWidth;
        window.Height = defaultHeight;
        window.X = -defaultWidth;
        window.Y = -defaultHeight;

        await window.Dispatcher.DispatchAsync(() => { });

        var displayInfo = DeviceDisplay.Current.MainDisplayInfo;
        window.X = (displayInfo.Width / 
            displayInfo.Density - window.Width) / 2;
        window.Y = (displayInfo.Height / 
            displayInfo.Density - window.Height) / 2;
        AppState.Width = window.Width;
        AppState.Height = window.Height;
#endif
    }
}
