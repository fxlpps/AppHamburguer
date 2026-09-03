using AndroidX.Navigation.Fragment;

namespace AppHamburguer;

public partial class AppFlyoutPage : ContentPage
{
	public AppFlyoutPage()
	{
		InitializeComponent();

		//Define que a página inicial aberta dentro do Detail é a Mainpage (Home
		Detail = new NavigationPage(new MainPage());

	}

	private void gasetaClicked(object sender, EventArgs e)
	{
		Detail = new NavigationPage(new CalculoPage());
		IsPresented = false;
	}
    private void OnautonomiaClicked(object sender, EventArgs e)
	{
		Detail = new NavigationPage(new CalculoAutonomia());
		IsPresented = false;
	}
}