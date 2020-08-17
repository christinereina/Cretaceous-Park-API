// using Microsoft.EntityFrameworkCore;

// namespace CretaceousPark.Models
// {
//   public class CretaceousParkContext : DbContext
//   {
//     public CretaceousParkContext (DbContextOptions<CretaceousParkContext> options)
//         : base(options)
//       {
//       }
//   public DbSet<Animal> Animals { get; set; }

//       protected override void OnModelCreating(ModelBuilder builder)
//     {
//       builder.Entity<Animal>()
//       .HasData(
//           new Animal { AnimalId = 1, Name ="Matilda", Species = "Woolly Mammoth", Age = 72, Gender = "Female" },
//           new Animal { AnimalId = 2, Name ="Christine", Species = "Dinosaur", Age = 3, Gender = "Female" },
//           new Animal { AnimalId = 3, Name ="Luna", Species = "Dinosaur", Age = 10, Gender = "Male" },
//           new Animal { AnimalId = 4, Name ="Penta", Species = "Shark", Age = 1, Gender = "Male" },
//           new Animal { AnimalId = 5, Name ="Snookie", Species = "Fish Food", Age = 8, Gender = "Male" }
//             );
//     }  

//   }
// }

// repo code

using Microsoft.EntityFrameworkCore;

namespace CretaceousPark.Models
{
  public class CretaceousParkContext : DbContext
  {
    public CretaceousParkContext(DbContextOptions<CretaceousParkContext> options)
        : base(options)
    {
    }

    public DbSet<Animal> Animals { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Animal>()
          .HasData(
              new Animal { AnimalId = 1, Name = "Matilda", Species = "Woolly Mammoth", Age = 7, Gender = "Female" },
              new Animal { AnimalId = 2, Name = "Rexie", Species = "Dinosaur", Age = 10, Gender = "Female" },
              new Animal { AnimalId = 3, Name = "Matilda", Species = "Dinosaur", Age = 2, Gender = "Female" },
              new Animal { AnimalId = 4, Name = "Pip", Species = "Shark", Age = 4, Gender = "Male" },
              new Animal { AnimalId = 5, Name = "Bartholomew", Species = "Dinosaur", Age = 22, Gender = "Male" }
          );
    }
  }
}

