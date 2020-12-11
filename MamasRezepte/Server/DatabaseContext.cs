using MamasRezepte.Shared.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MamasRezepte.Server
{
    public class DatabaseContext : DbContext
    {

        public DbSet<Category> Categories { get; set; }
        public DbSet<DurationCategory> DurationCategories { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<RecipeImage> RecipeImages { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<RecipeToTagRelation> RecipeToTagRelations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseLazyLoadingProxies()
                .UseSqlite("Data Source=Database.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().ToTable("Categories");
            modelBuilder.Entity<DurationCategory>().ToTable("DurationCategories");
            modelBuilder.Entity<Ingredient>().ToTable("Ingredients");
            modelBuilder.Entity<Product>().ToTable("Products");
            modelBuilder.Entity<Recipe>().ToTable("Recipes");
            modelBuilder.Entity<RecipeImage>().ToTable("RecipeImages");
            modelBuilder.Entity<Tag>().ToTable("Tags");
            modelBuilder.Entity<RecipeToTagRelation>().ToTable("RecipeToTagRelations");

        }

    }
}
