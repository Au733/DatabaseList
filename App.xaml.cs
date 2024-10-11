using MovieApp.Models;

namespace MovieApp;

public partial class App : Application
{
    public static List<Movie> MovieList; // data model collection for storing movies
    
    public App()
    {
        InitializeComponent();
        
        MovieList = new List<Movie>(); // initializing MovieList

        MainPage = new AppShell();
    }
}