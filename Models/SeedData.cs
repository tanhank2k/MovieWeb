using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MovieWeb.Data;
using System.Linq;


namespace MovieWeb.Models
{
    public static class SeedData
    {
        public static void Initalizer ( IServiceProvider serviceProvider){
            using (var context = new MovieContext(serviceProvider.GetRequiredService<DbContextOptions<MovieContext>>())){
                //Look for any movie
                if(context.Movies.Any()){
                    return;
                }

                context.Movies.AddRange(
                     new Movie
                    {
                        Name = "When Harry Met Sally",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Genre = "Romantic Comedy",
                        Price = 7.99M
                    },

                    new Movie
                    {
                        Name = "Ghostbusters ",
                        ReleaseDate = DateTime.Parse("1984-3-13"),
                        Genre = "Comedy",
                        Price = 8.99M
                    },

                    new Movie
                    {
                        Name = "Ghostbusters 2",
                        ReleaseDate = DateTime.Parse("1986-2-23"),
                        Genre = "Comedy",
                        Price = 9.99M
                    },

                    new Movie
                    {
                        Name = "Rio Bravo",
                        ReleaseDate = DateTime.Parse("1959-4-15"),
                        Genre = "Western",
                        Price = 3.99M
                    }
                );

                context.SaveChanges();
            }
        }
    }
}