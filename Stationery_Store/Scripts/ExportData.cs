using Microsoft.EntityFrameworkCore;
using Stationery_Store.Entities;
using System;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace Stationery_Store.Scripts
{
    public class DataExporter
    {
        public static async Task ExportDataAsync()
        {
            // Create a temporary context with SQLite
            var optionsBuilder = new DbContextOptionsBuilder<Context>();
            string dataFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data");
            string dbPath = Path.Combine(dataFolder, "appdata.db");
            optionsBuilder.UseSqlite($"Data Source={dbPath}");

            using (var context = new Context(optionsBuilder.Options))
            {
                // Export all data
                var exportData = new
                {
                    Categories = await context.Categories.ToListAsync(),
                    Products = await context.Products.ToListAsync(),
                    Orders = await context.Orders.ToListAsync(),
                    OrderItems = await context.Order_Items.ToListAsync(),
                    Users = await context.Users.ToListAsync()
                };

                // Save to JSON file
                string exportPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "export.json");
                string json = JsonSerializer.Serialize(exportData, new JsonSerializerOptions { WriteIndented = true });
                await File.WriteAllTextAsync(exportPath, json);
            }
        }
    }
} 