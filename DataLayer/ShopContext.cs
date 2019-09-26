using DataLayer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace DataLayer
{
    public class ShopContext : DbContext
    {
        public ShopContext(DbContextOptions<ShopContext> options)
            : base(options) { }

        public DbSet<Phone> Phones { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Photo> Photos { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderLine> OrderLines { get; set; }
        public DbSet<User> Users { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Company>().HasKey(k => k.CompanyID);
            modelBuilder.Entity<Phone>().HasKey(k => k.PhoneID);
            modelBuilder.Entity<Photo>().HasKey(k => k.PhotoID);
            modelBuilder.Entity<OrderLine>().HasKey(k => new { k.PhoneID, k.OrderID });
            modelBuilder.Entity<Order>().HasKey(k => k.OrderID);
            modelBuilder.Entity<User>().HasKey(k => k.UserID);

            //modelBuilder.Entity<Order>()
            //    .Property(p => p.OrderDate)
            //    .HasDefaultValue(DateTime.Now);

            //modelBuilder.Entity<Phone>()
            //    .Property(p => p.Price)
            //    .HasColumnType("decimal(30,2)");

            modelBuilder.Entity<Photo>()
                .HasOne(x => x.Phone)
                .WithOne(x => x.Photo)
                .HasForeignKey<Photo>(x => x.PhoneID);

            modelBuilder.Entity<Phone>()
                .HasOne(x => x.Company)
                .WithMany(x => x.Phone)
                .HasForeignKey(x => x.CompanyID);

            modelBuilder.Entity<OrderLine>()
                .HasOne(x => x.Phone)
                .WithMany(x => x.OrderLine)
                .HasForeignKey(x => x.PhoneID);

            modelBuilder.Entity<OrderLine>()
                .HasOne(x => x.Order)
                .WithMany(x => x.OrderLine)
                .HasForeignKey(x => x.OrderID);

            modelBuilder.Entity<Order>()
                .HasOne(x => x.Users)
                .WithMany(x => x.Order)
                .HasForeignKey(x => x.UserID);

            modelBuilder.Entity<Company>().HasData(
                new Company { CompanyID = 1, CompanyName = "OnePlus" });

            modelBuilder.Entity<Phone>().HasData(
                new Phone { CompanyID = 1, PhoneID = 1, PhoneName = "One", Price = 399.99M },
                new Phone { CompanyID = 1, PhoneID = 2, PhoneName = "2", Price = 499.99M },
                new Phone { CompanyID = 1, PhoneID = 3, PhoneName = "X", Price = 599.99M },
                new Phone { CompanyID = 1, PhoneID = 4, PhoneName = "3", Price = 699.99M },
                new Phone { CompanyID = 1, PhoneID = 5, PhoneName = "3T", Price = 799.99M },
                new Phone { CompanyID = 1, PhoneID = 6, PhoneName = "5", Price = 899.99M },
                new Phone { CompanyID = 1, PhoneID = 7, PhoneName = "5T", Price = 999.99M },
                new Phone { CompanyID = 1, PhoneID = 8, PhoneName = "6", Price = 1299.99M },
                new Phone { CompanyID = 1, PhoneID = 9, PhoneName = "6T", Price = 1399.99M },
                new Phone { CompanyID = 1, PhoneID = 10, PhoneName = "7", Price = 1899.99M },
                new Phone { CompanyID = 1, PhoneID = 11, PhoneName = "7 Pro", Price = 1999.99M }
                );
        }

    }
}
