
namespace Pendu
{
    public partial class PerduPage : ContentPage
    {
        public PerduPage(string mots)
        {   NavigationPage.SetHasBackButton(this, false);
            InitializeComponent();
            MotsLabel.Text = $"Le mot était : {mots}"; // Affiche le mot après une défaite
        }

        private async void BoutonRejouer(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new JeuPage()); // Relance le jeu
        }

        private async void BoutonQuitter(object sender, EventArgs e)
        {
           await Navigation.PushAsync(new MainPage()); // Retour à l'accueil
        }
    }
}


