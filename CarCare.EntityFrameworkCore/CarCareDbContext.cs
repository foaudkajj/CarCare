using CarCare.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarCare.EntityFrameworkCore
{
    public class CarCareDbContext : DbContext
    {
        public CarCareDbContext(DbContextOptions<CarCareDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CarMaintainceAndCategory>()
    .HasKey(bc => new { bc.CarMaintainceId, bc.MaintainceCategoryId });
            modelBuilder.Entity<CarMaintainceAndCategory>()
                .HasOne(bc => bc.MaintainceCategory)
                .WithMany(b => b.MaintainceAndCategories)
                .HasForeignKey(bc => bc.MaintainceCategoryId);
            modelBuilder.Entity<CarMaintainceAndCategory>()
                .HasOne(bc => bc.CarMaintaince)
                .WithMany(c => c.MaintainceAndCategories)
                .HasForeignKey(bc => bc.CarMaintainceId);
        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<CarModel> CarModels { get; set; }
        public DbSet<CarOwner> CarOwners { get; set; }
        public DbSet<CarMaintaince> CarMaintainces { get; set; }
        public DbSet<MaintainceCategory> MaintainceCategories { get; set; }
        public DbSet<CarMaintainceAndCategory>MaintainceAndCategories { get; set; }
        public DbSet<MaintainceSubCategory> MaintainceSubCategories { get; set; }

    }
}
