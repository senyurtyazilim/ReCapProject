﻿using Core.Entities.Concrete;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class ReCapProjectContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Data Source=.;
                 Initial Catalog=C:\USERS\XXX\DOCUMENTS\RECAPPROJECT.MDF;
                 Integrated Security=True;Connect Timeout=30;" +
                "Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;" +
                "MultiSubnetFailover=False");
        }

        public DbSet<Brand> Brands { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Rental> Rentals { get; set; }
        public DbSet<CarImage> CarImages { get; set; }

        public DbSet<UserForJwt> UserForJwts { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }

    }
}
