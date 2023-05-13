namespace MyMauiApp;

public partial class ShakePage : ContentPage
{
    public ShakePage()
    {
        InitializeComponent();
    }

    private void ToggleShake(object sender, EventArgs e)
    {
        if (Accelerometer.Default.IsSupported)
        {
            if (!Accelerometer.Default.IsMonitoring)
            {
                // Turn on accelerometer
                Accelerometer.Default.ShakeDetected += Accelerometer_ShakeDetected;
                Accelerometer.Default.Start(SensorSpeed.Game);
            }
            else
            {
                // Turn off accelerometer
                Accelerometer.Default.Stop();
                Accelerometer.Default.ShakeDetected -= Accelerometer_ShakeDetected;
                ShakeLabel.TextColor = Colors.Black;
                ShakeLabel.Text = "Shake";
            }
        }
    }

    private void Accelerometer_ShakeDetected(object sender, EventArgs e)
    {
        // Update UI Label with a "shaked detected" notice, in red
        ShakeLabel.TextColor = Colors.Red;
        ShakeLabel.Text = $"Shake detected";
    }
}
