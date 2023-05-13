namespace MyMauiApp;

public partial class OrientationPage : ContentPage
{
    public OrientationPage()
    {
        InitializeComponent();
    }

    private void ToggleOrientation(object sender, EventArgs e)
    {
        if (OrientationSensor.Default.IsSupported)
        {
            if (!OrientationSensor.Default.IsMonitoring)
            {
                // Turn on orientation
                OrientationSensor.Default.ReadingChanged += Orientation_ReadingChanged;
                OrientationSensor.Default.Start(SensorSpeed.UI);
            }
            else
            {
                // Turn off orientation
                OrientationSensor.Default.Stop();
                OrientationSensor.Default.ReadingChanged -= Orientation_ReadingChanged;
                OrientationLabel.TextColor = Colors.Black;
                OrientationLabel.Text = "Orientation";
            }
        }
    }

    private void Orientation_ReadingChanged(object sender, OrientationSensorChangedEventArgs e)
    {
        // Update UI Label with orientation state
        OrientationLabel.TextColor = Colors.Green;
        if (IsLandscape(e.Reading))
            OrientationLabel.Text = "Landscape";
        else
            OrientationLabel.Text = "Portrait";
    }

    private bool IsLandscape(OrientationSensorData orientationSensorData)
    {
        var value = orientationSensorData.Orientation;
        if (value.Y >= 0.00)
            return true;
        else
            return false;
    }
}
