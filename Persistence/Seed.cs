using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;

namespace Persistence
{
    public class Seed
    {
        public static async Task SeedData(DataContext context)
        {
            if (context.Activities.Any())
            {
                return;
            }

            var activities = new List<Activity>
            {
                new Activity
                {
                    Title = "Zakończone wydarzenie 1",
                    Date = DateTime.UtcNow.AddMonths(-2),
                    Description = "Wydarzenie sprzed 2 miesięcy",
                    Category = "Alkohol",
                    City = "Warszawa",
                    Venue = "Pub",
                },

                new Activity
                {
                    Title = "Zakończone wydarzenie 2",
                    Date = DateTime.UtcNow.AddMonths(-1),
                    Description = "Wydarzenie sprzed miesiąca",
                    Category = "Kultura",
                    City = "Warszawa",
                    Venue = "Kino",
                },

                new Activity
                {
                    Title = "Nadchodzące wydarzenie 1",
                    Date = DateTime.UtcNow.AddMonths(1),
                    Description = "Wydarzenie za miesiąc",
                    Category = "Kultura",
                    City = "Kraków",
                    Venue = "Teatr",
                },

                new Activity
                {
                    Title = "Nadchodzące wydarzenie 2",
                    Date = DateTime.UtcNow.AddMonths(2),
                    Description = "Wydarzenie za 2 miesiące",
                    Category = "Kultura",
                    City = "Rzeszów",
                    Venue = "Stadion",
                },

                new Activity
                {
                    Title = "Nadchodzące wydarzenie 3",
                    Date = DateTime.UtcNow.AddMonths(3),
                    Description = "Wydarzenie za 3 miesiące",
                    Category = "Podróż",
                    City = "Poznań",
                    Venue = "Wyspa Malta",
                },

                new Activity
                {
                    Title = "Nadchodzące wydarzenie 4",
                    Date = DateTime.UtcNow.AddMonths(4),
                    Description = "Wydarzenie za 4 miesiące",
                    Category = "Muzyka",
                    City = "Poznań",
                    Venue = "Klub Bajka",
                },

                new Activity
                {
                    Title = "Nadchodzące wydarzenie 5",
                    Date = DateTime.UtcNow.AddMonths(5),
                    Description = "Wydarzenie za 5 miesięcy",
                    Category = "Jedzenie",
                    City = "Poznań",
                    Venue = "Bar",
                },

                new Activity
                {
                    Title = "Nadchodzące wydarzenie 6",
                    Date = DateTime.UtcNow.AddMonths(6),
                    Description = "Wydarzenie za 6 miesięcy",
                    Category = "Film",
                    City = "Poznań",
                    Venue = "Kino Zorza",
                }
            };

            await context.Activities.AddRangeAsync(activities);
            await context.SaveChangesAsync();
        }
    }
}