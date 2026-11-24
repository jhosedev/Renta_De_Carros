using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRental.Api.Models

{

   public class Auto{

      public int Id {get; set;}
      
      public string Marca {get; set;} = string.Entity;
      
      public string Modelo {get; set;} = string.Entity;

      public decimal Precio {get; set;}

      public int Año {get; set;}

      public IColletion<Alquiler> Alquiler {get; set;}

   }
}