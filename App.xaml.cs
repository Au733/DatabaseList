using MovieApp.Models;

namespace MovieApp;

public partial class App : Application
{
    public static Repository MovieList; // data model collection for storing movies
    
    public App()
    {
        InitializeComponent();
        
        MovieList = new Repository(); // initializing MovieList

        MainPage = new AppShell();
    }
}