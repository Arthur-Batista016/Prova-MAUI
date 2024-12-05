using OpenWeather.ViewModels;

namespace OpenWeather.Views;

public partial class AppView : ContentPage
{
	public AppView()
	{
		InitializeComponent();
		BindingContext = new AppViewModel();
	}

    private async void botao_Clicked(object sender, EventArgs e)
    {
		var botao = (Button)sender;
		
		botao.BackgroundColor = Color.FromArgb("#228B22");

		await Task.Delay(400);
		botao.Background = Color.FromArgb("#512BD4");
    }

    
}