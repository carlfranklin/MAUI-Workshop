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
        if (!IsPortrait(e.Reading))
            OrientationLabel.Text = "Landscape";
        else
            OrientationLabel.Text = "Portrait";
    }

    private bool IsPortrait(OrientationSensorData orientationSensorData)
    {
        var q = orientationSensorData.Orientation;

        var sinp = +2.0 * (q.W * q.Y - q.Z * q.X);
        double pitch;
        if (Math.Abs(sinp) >= 1)
            pitch = Math.CopySign(Math.PI / 2, sinp); // use 90 degrees if out of range
        else
            pitch = Math.Asin(sinp);

        // Convert pitch to degrees for easier understanding
        pitch = pitch * 180.0 / Math.PI;

        // The device is considered in portrait mode if it's tilted horizontally, meaning the pitch
        // is closer to 0 or 180.
        if ((pitch <= 45 && pitch >= -45) || pitch >= 135 || pitch <= -135)
            return true;  // Portrait
        else
            return false; // Landscape
    }

}
