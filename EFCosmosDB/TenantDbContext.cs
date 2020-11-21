using EFCosmosDB.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace EFCosmosDB
{
    public class TenantDbContext : DbContext
    {
        public DbSet<Tenant> Tenants { get; set; }
        public DbSet<Consortium> Consortiums { get; set; }
        public DbSet<Origin> Origins { get; set; }
        public DbSet<Planet> Planets { get; set; }
        public DbSet<Ship> Ships { get; set; }

        public TenantDbContext(DbContextOptions<TenantDbContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Tenant>()
                .ToContainer("Tenants")
                     .HasKey(k => k.Key)
                //.Property<String>(p=>p.Name)   
                ;

            modelBuilder
              .Entity<Consortium>()
              .ToContainer("Consortiums")
              .HasKey(k => k.Id)
              ;

            modelBuilder
          .Entity<Origin>()
          .ToContainer("Origins")
            .HasKey(k => k.Id)
          ;

            modelBuilder
          .Entity<Planet>()
          .ToContainer("Planets")

  .HasKey(k => k.Id);

            modelBuilder
          .Entity<Ship>()
          .ToContainer("Ships")
            .HasKey(k => k.Id)
          ;
        }
    }
}
