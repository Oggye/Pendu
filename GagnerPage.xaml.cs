
namespace Pendu
{
    public partial class GagnerPage : ContentPage
    {
        public GagnerPage(string mots)
        {   NavigationPage.SetHasBackButton(this, false); // Désactive le bouton retour
            InitializeComponent();
            MotsLabel.Text = "Le mot était : " + mots; // Affiche le mot à deviner après victoire
        }

        private async void BoutonRejouer(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new JeuPage());  // Relance une nouvelle partie
        }

        private async void BoutonQuitter(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage()); // Retourne à la page principale
        }
    }
}



