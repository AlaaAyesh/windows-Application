using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stationery_Store.Entities
{
    public class Context:DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }

        public Context()
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> Order_Items { get; set; }
        public DbSet<User> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            
            // SQL Server connection string for WinApp database
            string connectionString = "Server=.;Database=WinApp;Trusted_Connection=True;MultipleActiveResultSets=True;Encrypt=False;Connect Timeout=30;";
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                        .HasIndex(u => u.UserName)
                        .IsUnique()
                        .HasDatabaseName("IX_User_UserName");

            modelBuilder.Entity<User>()
                        .Property(u => u.UserName)
                        .HasMaxLength(450);

            modelBuilder.Entity<Category>().HasData(
                new Category { ID = 1, Name = "أقلام", Description = "أقلام جامدة اوي" },
                new Category { ID = 2, Name = "كشاكيل", Description = "كشاكشيل جامدة اوي" }
                );

            modelBuilder.Entity<Product>().HasData(
            new Product { ID = 1, Name= "قلم رصاص",CategoryId = 1,Description="قلم رصاص جامد جدا",Price=10F,Quantity=100},
            new Product { ID = 2, Name = "كراسة", CategoryId = 2, Description = "كراسة مربعات 80 ص", Price = 15F, Quantity = 120 });


            modelBuilder.Entity<User>().HasData(
                new User {ID=1,NationalID="12345678912345",Password="123456",Phone="01061748098",UserName="Ahmed",UserRole=Role.Admin },
                new User {ID=2,NationalID="12345678912345",Password="123456",Phone="01061748098",UserName="Khaled",UserRole=Role.User }
                );

            modelBuilder.Entity<Product>()
                        .HasOne(p => p.Category)
                        .WithMany(c => c.Products)
                        .HasForeignKey(p => p.CategoryId)
                        .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<OrderItem>()
                        .HasOne(o => o.Product)
                        .WithMany(p => p.OrderItems)
                        .HasForeignKey(o => o.ProductId)
                        .OnDelete(DeleteBehavior.SetNull);  // ProductId = null لو المنتج اتحذف


        }
    }
}
