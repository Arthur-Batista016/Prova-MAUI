using OpenWeather.ViewModels;

namespace OpenWeather.Views;

public partial class AppView : ContentPage
{
	public AppView()
	{
		InitializeComponent();
		BindingContext = new AppViewModel();
	}
}