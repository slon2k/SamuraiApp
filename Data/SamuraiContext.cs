﻿using Microsoft.EntityFrameworkCore;
using Domain;

namespace Data
{
    public class SamuraiContext : DbContext
    {
   
        public DbSet<Samurai> Samurais { get; set; }
        public DbSet<Quote> Quotes { get; set; }
        public DbSet<Clan> Clans { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = SamuraiAppData");
            //base.OnConfiguring(optionsBuilder);
        }

    }
}
