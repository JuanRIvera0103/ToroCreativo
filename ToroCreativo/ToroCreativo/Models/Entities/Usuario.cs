using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ToroCreativo.Models.Entities
{
    public class Usuario
    {
        [Key]
        public int IdUsuario { get; set; }
        [Required]
        public string Correo { get; set; }
        
        [Required]
        public string Contraseña { get; set; }

        public string Estado { get; set; }
        [Required]
        public int Rol{ get; set; }
    }
}
