namespace MAUILayouts.Pages;

public partial class StackLayoutDemo : ContentPage
{
	public StackLayoutDemo()
	{
		InitializeComponent();
	}

    private void verticalStackLayoutButton_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new VerticalStackLayoutDemo());
    }

    private void horizontalStackLayoutButton_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new HorizontalStackLayoutDemo());
    }

    private void gridDemoButton_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new GgridDemo());
    }

    private void AbsolutlyLayoutButton_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new AbsoluteLayoutDemo());
    }
}