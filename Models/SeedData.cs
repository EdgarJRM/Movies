using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new MvcMovieContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<MvcMovieContext>>()))
        {
            // Look for any movies.
            if (context.Movie.Any())
            {
                return;   // DB has been seeded
            }
            context.Movie.AddRange(
                new Movie
                {
                    Title = "When Harry Met Sally",
                    ReleaseDate = DateTime.Parse("1989-2-12"),
                    Genre = "Romantic Comedy",
                    Rating = "R",
                    Price = 7.99M
                },
                new Movie
                {
                    Title = "Ghostbusters ",
                    ReleaseDate = DateTime.Parse("1984-3-13"),
                    Genre = "Comedy",
                    Rating = "R",
                    Price = 8.99M
                },
                new Movie
                {
                    Title = "Ghostbusters 2",
                    ReleaseDate = DateTime.Parse("1986-2-23"),
                    Genre = "Comedy",
                    Rating = "R",
                    Price = 9.99M
                },
                new Movie
                {
                    Title = "Rio Bravo",
                    ReleaseDate = DateTime.Parse("1959-4-15"),
                    Genre = "Western",
                    Rating = "R",
                    Price = 3.99M
                },
                new Movie
                {
                    Title = "Inception",
                    ReleaseDate = DateTime.Parse("2010-07-16"),
                    Genre = "Ciencia Ficción",
                    Rating = "R",
                    Price = 9.99M
                },
                new Movie
                {
                    Title = "Interstellar",
                    ReleaseDate = DateTime.Parse("2014-11-07"),
                    Genre = "Ciencia Ficción",
                    Rating = "R",
                    Price = 12.99M
                },
                new Movie
                {
                    Title = "El Padrino",
                    ReleaseDate = DateTime.Parse("1972-03-24"),
                    Genre = "Crimen",
                    Rating = "R",
                    Price = 8.99M
                }
            );
            context.SaveChanges();
        }
    }
}