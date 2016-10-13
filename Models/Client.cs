using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Banco_de_Sangre.Models
{
    public class Client
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "El nombre es requerido")]
        public string Name { get; set; }
        [Required(ErrorMessage = "El apellido es requerido")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "El correo es requerido")]
        public string Email { get; set; }
        [Required(ErrorMessage = "El tipo de sangre es requerido")]
        public Bloods BloodType { get; set; }
        public string Phone { get; set; }
        [Required(ErrorMessage = "El factor RH es requerido")]
        public string RhFactor { get; set; }
        [Required(ErrorMessage = "La contrasenia es requerida")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public enum Bloods
        {
            A,
            B,
            AB,
            O
        }

        public enum Factors
        {
            Positivo,
            Negativo
        }
    }
    public class ClientDBContext : DbContext
    {
       public DbSet<Client> Client { get; set; }
    }

    
}