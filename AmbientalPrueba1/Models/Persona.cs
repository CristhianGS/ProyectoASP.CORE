using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmbientalPrueba1.Models
{
    public class Persona
    {
        public int Id { get; set; }

        [Required(ErrorMessage =@"El ""Nombre"" es obligatorio")]
        public string Nombre { get; set; }

        [System.ComponentModel.DataAnnotations.Required(ErrorMessage =@"El ""Apellido"" es obligatorio")]
        public string Apellido { get; set; }
        
        public Celular Celular { get; set; }
    }
}
