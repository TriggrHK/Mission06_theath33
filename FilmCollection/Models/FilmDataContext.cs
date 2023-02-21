using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace FilmCollection.Models
{
    public class FilmDataContext : DbContext
    {
        public FilmDataContext (DbContextOptions<FilmDataContext> options) : base(options)
        {

        }

        public DbSet<FilmData> Responses { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Category>().HasData(
                new Category { CategoryId = 1, CategoryName = "Musical" },
                new Category { CategoryId = 2, CategoryName = "Fantasy" },
                new Category { CategoryId = 3, CategoryName = "Family" },
                new Category { CategoryId = 4, CategoryName = "Action" },
                new Category { CategoryId = 5, CategoryName = "Other" }
            );
            //add some data to be seeded into the database
            mb.Entity<FilmData>().HasData(
                new FilmData
                {
                    FilmId = 1,
                    CategoryId = 1,
                    Title = "The Greatest Showman",
                    Year = 2017,
                    Director = "Michael Gracey",
                    Rating = "PG",
                    Edited = "no",
                    Notes = "Mom's favorite movie"
                },
                new FilmData
                {
                    FilmId = 2,
                    CategoryId = 2,
                    Title = "Harry Potter: The Deathly Hallows Pt. 2",
                    Year = 2011,
                    Director = "David Yates",
                    Rating = "PG-13",
                    Edited = "yes",
                    Lent_To = "Older Brother"
                },
                new FilmData
                {
                    FilmId = 3,
                    CategoryId = 3,
                    Title = "Kung Fu Panda",
                    Year = 2008,
                    Director = "John Stevenson, Mark Osborne",
                    Rating = "PG",
                    Edited = "no"
                }
            );
        }
    }
}