using SQLite;


namespace MovieApp.Models;

public class Repository
{

    private readonly SQLiteConnection _database; //internal private database variable
    
    public Repository () 
    {
        var dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
            "movies.db"); //creating path to folder where data files are stored / database path

        _database = new SQLiteConnection(dbPath); //create connection to database
        _database.CreateTable<Movie>(); //create table
    }

    public List<Movie> GetMovies() //method to get movies list
    {
        return _database.Table<Movie>().ToList();
        //return _database.Query<Movie>("Select * from Movie where ID > 2"); //Querying database for specific data
    }

    public void SaveMovie(Movie movie) //method to insert movie into database table
    {
        _database.Insert(movie);
    }
    

}