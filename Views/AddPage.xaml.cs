using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieApp.Models;

namespace MovieApp.Views;

public partial class AddPage : ContentPage
{
    public AddPage()
    {
        InitializeComponent();
        Title = "Add New Movie";
    }

    private void AddMovie_OnClicked(object sender, EventArgs e)
    {
        var newMovie = new Movie(); // creating new instance of Movie class
        newMovie.Title = txtTitle.Text;
        newMovie.Rating = txtRating.Text;
        
        App.MovieList.Add(newMovie); // adding new movie data to data model collection

        txtTitle.Text = string.Empty;
        txtRating.Text = String.Empty;
    }
}