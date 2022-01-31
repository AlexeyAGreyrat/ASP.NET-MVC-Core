using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Lesson8.Data;
using System;
using System.Linq;
using Lesson8.Models;

namespace Lesson8.SeedData
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new OfficeContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<OfficeContext>>()))
            {
                if (context.Office.Any())
                {
                    return;   // DB has been seeded
                }

                context.Office.AddRange(
                    new Office
                    {
                        Title = "Office1",
                        ReleaseWork = DateTime.UtcNow,
                        location = "Moscow",
                        Type = "Тип",
                        Time = "8:00 - 18:00"
                    },

                    new Office
                    {
                        Title = "Office2",
                        ReleaseWork = DateTime.UtcNow,
                        location = "Moscow",
                        Type = "Тип",
                        Time = "8:00 - 18:00"
                    },

                    new Office
                    {
                        Title = "Office3",
                        ReleaseWork = DateTime.UtcNow,
                        location = "Moscow",
                        Type = "Тип",
                        Time = "8:00 - 18:00"
                    },

                    new Office
                    {
                        Title = "Office4",
                        ReleaseWork = DateTime.UtcNow,
                        location = "Moscow",
                        Type = "Тип",
                        Time = "8:00 - 18:00"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
