﻿namespace Pendu;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
		MainPage = new NavigationPage(new MainPage()); // Définition de la page principale
	}

	
	
}