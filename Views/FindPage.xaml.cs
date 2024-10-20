using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Views;

public partial class FindPage : ContentPage
{
    public FindPage()
    {
        InitializeComponent();
        Title = "List Movies";
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();

        var movieTemplate = new DataTemplate(typeof(TextCell)); // creating template to display ListView via TextCells
        movieTemplate.SetBinding(TextCell.TextProperty, "Title"); // binds TextCell.TextProperty to Title
        movieTemplate.SetBinding(TextCell.DetailProperty, "Rating");

        listMovies.ItemTemplate = movieTemplate; // use the movieTemplate for showing how each item in ListView will be displayed
        listMovies.ItemsSource = App.MovieList.GetMovies(); // bind ListView to movies stored in repository and able those store movies to be displayed
    }
}