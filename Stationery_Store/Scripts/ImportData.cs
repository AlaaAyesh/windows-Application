using Microsoft.EntityFrameworkCore;
using Stationery_Store.Entities;
using System;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace Stationery_Store.Scripts
{
    public class DataImporter
    {
        public static async Task ImportDataAsync()
        {
            // Create a context with SQL Server
            var optionsBuilder = new DbContextOptionsBuilder<Context>();
            string connectionString = "Server=localhost;Database=StationeryStore;Trusted_Connection=True;TrustServerCertificate=True;";
            optionsBuilder.UseSqlServer(connectionString);

            using (var context = new Context(optionsBuilder.Options))
            {
                // Read the JSON file
                string exportPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "export.json");
                string json = await File.ReadAllTextAsync(exportPath);
                var importData = JsonSerializer.Deserialize<dynamic>(json);

                // Import data in the correct order
                if (importData.Categories != null)
                {
                    await context.Categories.AddRangeAsync(importData.Categories);
                    await context.SaveChangesAsync();
                }

                if (importData.Products != null)
                {
                    await context.Products.AddRangeAsync(importData.Products);
                    await context.SaveChangesAsync();
                }

                if (importData.Users != null)
                {
                    await context.Users.AddRangeAsync(importData.Users);
                    await context.SaveChangesAsync();
                }

                if (importData.Orders != null)
                {
                    await context.Orders.AddRangeAsync(importData.Orders);
                    await context.SaveChangesAsync();
                }

                if (importData.OrderItems != null)
                {
                    await context.Order_Items.AddRangeAsync(importData.OrderItems);
                    await context.SaveChangesAsync();
                }
            }
        }
    }
} 