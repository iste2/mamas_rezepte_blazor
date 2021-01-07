using MamasRezepte.Shared.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
        public DbSet<Click> Clicks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder
            //    .UseSqlite("Data Source=Database.db");
            var hConnectionStringBuilder = new StringBuilder();

            if (Environment.GetEnvironmentVariable("DATABASE_URL") != null)
            {
                Uri hUrl;
                bool hIsUrl = Uri.TryCreate(Environment.GetEnvironmentVariable("DATABASE_URL"), UriKind.Absolute, out hUrl);
                if(hIsUrl)
                {
                    hConnectionStringBuilder.Append(String.Format("Host={0};", hUrl.Host));
                    hConnectionStringBuilder.Append(String.Format("Username={0};", hUrl.UserInfo.Split(':')[0]));
                    hConnectionStringBuilder.Append(String.Format("Password={0};", hUrl.UserInfo.Split(':')[1]));
                    hConnectionStringBuilder.Append(String.Format("Database={0};", hUrl.LocalPath.Substring(1)));
                    
                }
            } else
            {
                hConnectionStringBuilder.Append(String.Format("Host={0};", "localhost"));
                hConnectionStringBuilder.Append(String.Format("Database={0};", "MamasRezepte"));
                hConnectionStringBuilder.Append(String.Format("Username={0};", "postgres"));
                hConnectionStringBuilder.Append(String.Format("Password={0};", "admin"));
            }
            
            optionsBuilder.UseNpgsql(hConnectionStringBuilder.ToString());


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
            modelBuilder.Entity<Click>().ToTable("Clicks");

            // SeedDatabase(modelBuilder);

        }

        public void SeedDatabase(ModelBuilder _ModelBuilder)
        {
            int hId = -1;
            _ModelBuilder.Entity<Category>().HasData(
                new Category() { Id = hId, Name = "Fleisch und Geflügel" },
                new Category() { Id = hId, Name = "Fisch und Meeresfrüchte" },
                new Category() { Id = hId, Name = "Suppen und Eintöpfe" },
                new Category() { Id = hId, Name = "Salate und Snacks" },
                new Category() { Id = hId, Name = "Dessert und Süßspeisen" },
                new Category() { Id = hId, Name = "Kuchen und Gebäck" }
            );

            hId = -1;
            _ModelBuilder.Entity<DurationCategory>().HasData(
                new DurationCategory() { Id = hId, Name = "weniger als 30 min." },
                new DurationCategory() { Id = hId, Name = "30 - 60 min." },
                new DurationCategory() { Id = hId, Name = "mehr als 60 min." }
            );
        }

    }
}
