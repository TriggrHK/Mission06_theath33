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

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<FilmData>().HasData(
                new FilmData
                {
                    FilmId = 1,
                    Category = "Musical",
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
                    Category = "Fantasy",
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
                    Category = "Family",
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