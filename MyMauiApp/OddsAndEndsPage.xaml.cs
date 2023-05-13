using System.Diagnostics;

namespace MyMauiApp;

public partial class OddsAndEndsPage : ContentPage
{
    public OddsAndEndsPage()
    {
        InitializeComponent();
    }

    async void Alert(object sender, EventArgs e)
    {
        await DisplayAlert("Alert", "You have been alerted", "OK");
    }

    async void Prompt(object sender, EventArgs e)
    {
        string alert;
        bool answer = await DisplayAlert("Question?",
                     "Would you like to play a game", "Yes", "No");
        if (answer)
            alert = "Great! I love games";
        else alert = "Maybe next time";
        await DisplayAlert("Play a game", alert, "OK");
    }

    async void ActionSheet(object sender, EventArgs e)
    {
        string action = await DisplayActionSheet(
            "ActionSheet: Send to?", "Cancel", null, "Email", 
            "Twitter", "Facebook");

        await DisplayAlert("Alert", $"You chose {action}", "OK");
    }

    async void ActionSheetWithDelete(object sender, EventArgs e)
    {
        string action = await DisplayActionSheet(
            "ActionSheet: SavePhoto?", "Cancel", "Delete", 
            "Photo Roll", "Email");

        await DisplayAlert("Alert", $"You chose {action}", "OK");
    }

    async void PromptForInput(object sender, EventArgs e)
    {
        string name = await DisplayPromptAsync("Your Name", "What's your name?");
        if (name != null & name != "")
            await DisplayAlert("Your Name", $"Hello {name}", "OK");
    }

    async void SolveMathProblem(object sender, EventArgs e)
    {
        string result = await DisplayPromptAsync("Math Problem", "What's 5 + 5?",
            initialValue: "", maxLength: 2, keyboard: Keyboard.Numeric);

        if (result != null && result != "")
        {
            if (result == "10")
                await DisplayAlert("Math Problem", "Correct! 5+5=10", "OK");
            else
                await DisplayAlert("Math Problem", "Sorry. It's 10", "OK");
        }
    }
}
