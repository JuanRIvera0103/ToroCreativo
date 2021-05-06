using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ToroCreativo.ViewModels.Usuario
{
    public class PerfilViewModel
    {
        [Required(ErrorMessage = "El nombre es requerido")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Utilice caracteres solamente")]
        [StringLength(25, ErrorMessage = "El {0} debe tener al menos {2} y maximo {1} caracteres.", MinimumLength = 2)]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El apellido es requerido")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Utilice caracteres solamente")]
        [StringLength(25, ErrorMessage = "El {0} debe tener al menos {2} y maximo {1} caracteres.", MinimumLength = 2)]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "El Telefono es requerido")]
        [RegularExpression(@"^-?[0-9][0-9,\.]+$", ErrorMessage = "Utilice caracteres solamente")]
        [StringLength(25, ErrorMessage = "El {0} debe tener al menos {2} y maximo {1} caracteres.", MinimumLength = 2)]
        public string Telefono { get; set; }

        [Required(ErrorMessage = "La dirección es requerida")] 
        [StringLength(25, ErrorMessage = "El {0} debe tener al menos {2} y maximo {1} caracteres.", MinimumLength = 2)]
        public string Direccion { get; set; }

        [Required(ErrorMessage = "La cedula es requerida")]
        [RegularExpression(@"^-?[0-9][0-9,\.]+$", ErrorMessage = "Utilice caracteres solamente")]
        [StringLength(25, ErrorMessage = "El {0} debe tener al menos {2} y maximo {1} caracteres.", MinimumLength = 2)]
        public string Cedula { get; set; }
        [Required]
        public int IdCliente { get; set; }
    }
}
