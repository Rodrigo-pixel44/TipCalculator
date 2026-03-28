namespace TipCalculator;

public partial class SobrePage : ContentPage
{
	public SobrePage()
	{
		InitializeComponent();
	}

    private void PerfilButton_Clicked(object sender, EventArgs e)
    {

    }
    private void GitHubButton_Clicked(object sender, EventArgs e)
    {
        Launcher.OpenAsync("https://github.com/Rodrigo-pixel44");
    }

}