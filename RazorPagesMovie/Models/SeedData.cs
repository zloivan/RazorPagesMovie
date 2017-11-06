using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace RazorPagesMovie.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MovieContext(
                serviceProvider.GetRequiredService<DbContextOptions<MovieContext>>()))
            {
                if (context.Movies.Any())
                {
                    return;
                }

                context.Movies.AddRange
                    (
                    new Movie
                    {
                        Title = "Breaking bad",
                        Genre = "Criminal",
                        ReleaseDate = DateTime.Parse("12.02.2007"),
                        Price = 7.99M,
                        Rating="R"
                        
                    },
                    new Movie
                    {
                        Title = "Prison Break",
                        Genre = "Criminal",
                        ReleaseDate = DateTime.Parse("12.10.2005"),
                        Price = 7.99M,
                        Rating = "B"
                    },
                    new Movie
                    {
                        Title = "MD House",
                        Genre = "Detective",
                        ReleaseDate = DateTime.Parse("03.02.2003"),
                        Price = 7.99M,
                        Rating = "A"
                    },
                    new Movie
                    {
                        Title = "Scrubs",
                        Genre = "Comedy",
                        ReleaseDate = DateTime.Parse("12.02.2010"),
                        Price = 5.99M,
                        Rating = "S"

                    }


                    );
                context.SaveChanges();
            }
        }
    }
}
