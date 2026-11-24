using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRental.Api.Models

{

   public class Alquiler {

      public int Id {get; set;}
      
      public int UsuarioId {get; set;} = string.Entity;
      
      public Usuario Usuario {get; set;} = string.Entity;

      public int AutoId {get; set;}
      
      public Auto Auto {get; set;}

      public DateTime FechaDeInicio {get; set;}

      public DateTime FechaDeFin {get; set;}

   }
}