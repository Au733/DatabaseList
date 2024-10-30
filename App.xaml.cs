using MovieApp.Models;

namespace MovieApp;

public partial class App : Application
{
    public static Repository MovieList; // storing movies in repository
    
    public App()
    {
        InitializeComponent();
        
        MovieList = new Repository(); // initializing MovieList

        MainPage = new AppShell();
    }
}