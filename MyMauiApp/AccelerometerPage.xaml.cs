namespace MyMauiApp;

public partial class AccelerometerPage : ContentPage
{
    public AccelerometerPage()
    {
        InitializeComponent();
    }

    private void ToggleAccelerometer(object sender, EventArgs e)
    {
        if (Accelerometer.Default.IsSupported)
        {
            if (!Accelerometer.Default.IsMonitoring)
            {
                // Turn on accelerometer
                Accelerometer.Default.ReadingChanged += Accelerometer_ReadingChanged;
                Accelerometer.Default.Start(SensorSpeed.UI);
            }
            else
            {
                // Turn off accelerometer
                Accelerometer.Default.Stop();
                Accelerometer.Default.ReadingChanged -= Accelerometer_ReadingChanged;
            }
        }
    }

    private void Accelerometer_ReadingChanged(object sender, AccelerometerChangedEventArgs e)
    {
        // Update UI Label with accelerometer state
        AccelLabel.TextColor = Colors.Green;
        AccelLabel.Text = $"Accel: {e.Reading}";
    }
}
