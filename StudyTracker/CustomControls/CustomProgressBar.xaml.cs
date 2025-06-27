namespace StudyTracker.CustomControls;

public partial class CustomProgressBar : ContentView
{
    public CustomProgressBar()
    {
        InitializeComponent();
    }
    public static readonly BindableProperty ProgressProperty =
           BindableProperty.Create(nameof(Progress), typeof(double), typeof(CustomProgressBar), 0.0, propertyChanged: OnProgressChanged);

    public double Progress
    {
        get => (double)GetValue(ProgressProperty);
        set => SetValue(ProgressProperty, value);
    }

    private static void OnProgressChanged(BindableObject bindable, object oldValue, object newValue)
    {
        var control = (CustomProgressBar)bindable;
        double progress = Math.Clamp((double)newValue, 0, 1);

        // Update width based on total grid width
        control.ProgressBox.WidthRequest = control.RootGrid.Width * progress;
    }
}