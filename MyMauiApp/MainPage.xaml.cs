namespace MyMauiApp;

public partial class MainPage : ContentPage
{
    int count = 0;

    public MainPage()
    {
        InitializeComponent();
    }

    private async void OnCounterClicked(object sender, EventArgs e)
    {
        count++;

        if (count == 1)
            CounterBtn.Text = $"Clicked {count} time";
        else
            CounterBtn.Text = $"Clicked {count} times";

        SemanticScreenReader.Announce(CounterBtn.Text);

        // Copy the button text to the clipboard
        await Clipboard.Default.SetTextAsync(CounterBtn.Text);

        // read and examine the text in the clipboard:
        var text = await Clipboard.Default.GetTextAsync();
        if (text == "Clicked 3 times")
        {

        }
    }
}

