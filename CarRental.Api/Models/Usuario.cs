using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRental.Api.Models

{

   public class Usuario {

      public int Id {get; set;}
      
      public string  NombreDeUsuario {get; set;} = string.Entity;
      
      public string Email {get; set;} = string.Entity;

      public IColletion<Alquiler> Alquiler {get; set;}

   }
}