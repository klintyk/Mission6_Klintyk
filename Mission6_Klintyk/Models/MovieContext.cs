using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Mission6_Klintyk.Models
{
    public class MovieContext : DbContext
    {
        //Constructor
        public MovieContext(DbContextOptions<MovieContext> options) : base(options)
        {

        }
        public DbSet<Movie> Responses { get; set; }
        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Movie>().HasData(
                new Movie
                {
                    FilmID = 1,
                    Category = "Action/Adventure",
                    Title = "Black Panther",
                    Year = 2018,
                    Director = "Ryan Coogler",
                    Rating = "PG-13",
                    Edited= false,
                    Lent_to = "Oliva Olred",
                    Notes = ""
                },
                 new Movie
                 {
                     FilmID = 2,
                     Category = "Comedy",
                     Title = "Blended",
                     Year = 2014,
                     Director = "Frank Coraci",
                     Rating = "PG-13",
                     Edited = true,
                     Lent_to = "",
                     Notes = ""
                 },
                  new Movie
                  {
                      FilmID = 3,
                      Category = "Action/Adventure",
                      Title = "Shanghai Knights",
                      Year = 2003,
                      Director = "David Dobkin",
                      Rating = "PG-13",
                      Edited = false,
                      Lent_to = "Carter Jenses",
                      Notes = ""
                  }
                );
        }
    }
}
