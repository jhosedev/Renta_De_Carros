using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRental.Api.Models

{

   public class AppDbContext : DbContext 
   {
      public DbSet<Usuario> Usuario {get; set;}
      public DbSet<Auto> Auto {get; set;}
      public Dbset<Alquiler> Alquiler {get; set;}

      protected override void OnModelCreating (ModelBuilder modelBuilder) 
      {

         modelBuilder.Entity<Auto>()
                  .Property(c=> c.Precio)
                  .HasPrecision(10, 2);
         base.OnModelCreating(modelBuilder);
      }
   }
}