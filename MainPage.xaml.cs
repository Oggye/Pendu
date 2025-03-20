namespace Pendu;

public partial class MainPage : ContentPage
{

	public MainPage()
	{	NavigationPage.SetHasBackButton(this, false); // Désactive le bouton retour
		InitializeComponent();
	}

	private async void OnCounterClicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new JeuPage()); // Lance une nouvelle partie
	}
}

