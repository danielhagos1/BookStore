using BookStore.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new BookContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<BookContext>>()))
            {
                // Look for any books.
                if (context.Book.Any())
                {
                    return;   // DB has been seeded
                }

                context.Book.AddRange(
                    new Book
                    {
                        Title = "When Harry Met Sally",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Category = "Romantic",
                        Price = 7.99M,
                        Rating = "R",
                        Author = "Daniel"

                    },

                    new Book
                    {
                        Title = "Ghostbusters ",
                        ReleaseDate = DateTime.Parse("1984-3-13"),
                        Category = "Comedy",
                        Price = 8.99M,
                        Rating = "R",
                        Author = "Daniel"
                    },

                    new Book
                    {
                        Title = "Ghostbusters 2",
                        ReleaseDate = DateTime.Parse("1986-2-23"),
                        Category = "Comedy",
                        Price = 9.99M,
                        Rating = "R",
                        Author = "Daniel"
                    },

                    new Book
                    {
                        Title = "Rio Bravo",
                        ReleaseDate = DateTime.Parse("1959-4-15"),
                        Category = "Western",
                        Price = 3.99M,
                        Rating = "R",
                        Author = "Daniel"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}

