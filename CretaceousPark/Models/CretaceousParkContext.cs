using Microsoft.EntityFrameworkCore;

namespace CretaceousPark.Models
{
  public class CretaceousParkContext : DbContext
  {
    public CretaceousParkContext (DbContextOptions<CretaceousParkContext> options)
        : base(options)
      {
      }
  public DbSet<Animal> Animals { get; set; }

      protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Animal>()
      .HasData(
          new Animal { AnimalId = 1, Name ="Matilda", Species = "Woolly Mammoth", Age = 72, Gender = "Female" },
          new Animal { AnimalId = 2, Name ="Christine", Species = "Dinosaur", Age = 3, Gender = "Female" },
          new Animal { AnimalId = 3, Name ="Luna", Species = "Dinosaur", Age = 10, Gender = "Male" },
          new Animal { AnimalId = 4, Name ="Penta", Species = "Shark", Age = 1, Gender = "Male" },
          new Animal { AnimalId = 5, Name ="Snookie", Species = "Fish Food", Age = 8, Gender = "Male" }
            );
    }  

  }
}

