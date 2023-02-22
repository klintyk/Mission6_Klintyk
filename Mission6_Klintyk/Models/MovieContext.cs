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
        public DbSet<CategoryResponse> Categories {get; set;}
        protected override void OnModelCreating(ModelBuilder mb)
        {
            //add data to the category table
            mb.Entity<CategoryResponse>().HasData(
                new CategoryResponse { CategoryId = 1, Category = "Action/Adventure" },
                new CategoryResponse { CategoryId = 2, Category = "Comedy" },
                new CategoryResponse { CategoryId = 3, Category = "Thriller" },
                new CategoryResponse { CategoryId = 4, Category = "Romance" },
                new CategoryResponse { CategoryId = 5, Category = "Western" });
            //add data to movie table
            mb.Entity<Movie>().HasData(
                new Movie
                {
                    FilmID = 1,
                    CategoryId = 1,
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
                     CategoryId = 2,
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
                      CategoryId = 1,
                      Title = "Shanghai Knights",
                      Year = 2003,
                      Director = "David Dobkin",
                      Rating = "PG-13",
                      Edited = false,
                      Lent_to = "Carter Jenses",
                      Notes = ""
                  },
                  new Movie
                  {
                      FilmID = 4,
                      CategoryId = 5,
                      Title = "The Revnant",
                      Year = 2015,
                      Director = "Alejandro G.Iñárritu",
                      Rating = "R",
                      Edited = false,
                      Lent_to = "",
                      Notes = ""
                  }
                );
        }

        internal void Update()
        {
            throw new NotImplementedException();
        }
    }
}
