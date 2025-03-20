# Pendu
# Jeu du Pendu


## **Description**
Ce projet est une implémentation du célèbre jeu du Pendu développé en C# avec .NET MAUI. L'application permet aux joueurs de deviner un mot lettre par lettre, avec un nombre limité d'erreurs autorisées (10). Le mot à deviner est récupéré aléatoirement à partir d'une API de blagues.


## **Technologies utilisées**
- Langage de programmation: C# (.NET 9.0)
- Framework: .NET MAUI (Multi-platform App UI)
- Bibliothèques externes:

* Newtonsoft.Json (v13.0.3) - pour le parsing JSON
* Microsoft.Maui.Controls
* Microsoft.Extensions.Logging.Debug (v9.0.0)

- API: Blagues API (https://www.blagues-api.fr) - pour récupérer des mots aléatoires


## **Logiciels requis**

- Visual Studio 2022 (version 17.0 ou supérieure) ou Visual Studio Code avec la charge de travail ".NET MAUI"
- SDK .NET 9.0
- Android SDK (pour le développement Android)
- Xcode (pour le développement iOS/macOS, uniquement sur Mac)
- Windows (pour le développement sur Windows)


## **Fonctionnalités**

- Interface utilisateur intuitive avec navigation entre pages
- Récupération de mots aléatoires à partir d'une API externe
- Système de vies (10 tentatives maximum)
- Visualisation graphique ASCII du pendu qui évolue avec les erreurs
- Affichage des lettres incorrectes déjà essayées
- de victoire et de défaite ????
- Possibilité de rejouer ou de quitter à la fin d'une partie


## **Structure du projet**
Le projet est organisé selon l'architecture MVVM (Model-View-ViewModel) simplifiée, typique des applications .NET MAUI :


# Pages principales:

Le projet suit une architecture modulaire basée sur les pages MAUI.

- **MainPage.xaml / MainPage.xaml.cs** : Page principale du jeu

- **JeuPage.xaml / JeuPage.xaml.cs** : Contient la logique du jeu (gestion des entrées, mise à jour des vies, vérification des lettres)

- **GagnerPage.xaml / GagnerPage.xaml.cs** : Affichage de la victoire

- **PerduPage.xaml / PerduPage.xaml.cs** : Affichage de la défaite

- **App.xaml / App.xaml.cs** : Configuration de l'application


# Classes importantes:

- App: Point d'entrée de l'application
- AppShell: Structure de navigation de l'application
- MauiProgram: Configuration de l'application MAUI



## **Installation et exécution**

# Prérequis

- Visual Studio 2022 ou Visual Studio Code avec la charge de travail .NET MAUI
- Compte développeur pour l'API Blagues (pour obtenir une clé API)

# Étapes d'installation

Visual Studio :
- Cloner le dépôt ou télécharger les fichiers source
- Ouvrir la solution Pendu.sln dans Visual Studio
- Restaurer les packages NuGet (clic droit sur la solution > Restaurer les packages NuGet)
- Sélectionner la plateforme cible (Android, iOS, Windows) dans la barre d'outils
- Compiler et exécuter l'application (F5)

Visual Studio Code :
- Cloner le dépôt ou télécharger les fichiers source
- Ouvrir la solution Pendu.sln dans Visual Studio Code
- Dans votre teminale aller jusqu'au dossier Pendu
- Faite un dotnet add package Newtonsoft.Json
- Ensuite, faite dotnet build
- Pour afficher l'interface taper :dotnet build -t:Run -f net9.0-windows10.0.19041.0



## **Configuration de l'API**

Le jeu utilise l'API Blagues pour récupérer des mots aléatoires. La clé API est déjà incluse dans le code, mais si elle expire, vous devrez la remplacer :

- Créer un compte sur https://www.blagues-api.fr
- Générer une nouvelle clé API
- Remplacer la clé dans la méthode Mots_aleatoire() de la classe JeuPage.xaml.cs



## **Règles du jeu**

- Un mot aléatoire est choisi au début de chaque partie
- Le joueur a 10 tentatives pour deviner le mot
- À chaque erreur, une partie du pendu est dessinée
- Le joueur gagne s'il devine toutes les lettres avant que le pendu ne soit complètement dessiné
- Le joueur perd s'il fait 10 erreurs et que le pendu est complètement dessiné



## **Contribution**

# Pour contribuer à ce projet:

1. Forker le projet
2. Créer une branche pour votre fonctionnalité (git checkout -b feature/amazing-feature)
3. Committer vos changements (git commit -m 'Add some amazing feature')
4. Pousser vers la branche (git push origin feature/amazing-feature)
5. Ouvrir une Pull Request
