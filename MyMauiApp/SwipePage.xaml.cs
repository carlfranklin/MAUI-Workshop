namespace MyMauiApp;

public partial class SwipePage : ContentPage
{
    public SwipePage()
    {
        InitializeComponent();
    }

    void OnSwiped(object sender, SwipedEventArgs e)
    {
        switch (e.Direction)
        {
            case SwipeDirection.Left:
                SwipeLabel.Text = "Swipe Direction: Left";
                break;
            case SwipeDirection.Right:
                SwipeLabel.Text = "Swipe Direction: Right";
                break;
            case SwipeDirection.Up:
                SwipeLabel.Text = "Swipe Direction: Up";
                break;
            case SwipeDirection.Down:
                SwipeLabel.Text = "Swipe Direction: Down";
                break;
        }
    }
}
