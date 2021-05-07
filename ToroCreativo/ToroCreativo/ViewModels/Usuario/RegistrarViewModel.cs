using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ToroCreativo.ViewModels.Usuario
{
    public class RegistrarViewModel
    {
        [Required(ErrorMessage = "El correo es requerido")]
        [EmailAddress(ErrorMessage = "El Email invalido")]
        public string Email { get; set; }


        [Required(ErrorMessage = "La contraseña es requerida")]
        [DisplayName("Contraseña")]
        [DataType(DataType.Password)]
        [StringLength(16, ErrorMessage = "La {0} debe tener minimo {2} y máximo {1} caracteres.", MinimumLength = 8)]
        public string Password { get; set; }


        [Required(ErrorMessage = "Confirmar la contraseña es requerido")]
        [DisplayName("Confirmar Contraseña")]
        [DataType(DataType.Password)]
        [StringLength(16, ErrorMessage = "El {0} debe tener minimo {2} y máximo {1} caracteres.", MinimumLength = 8)]
        [Compare("Password", ErrorMessage = "Las contraseñas no coinciden")]
        public string ConfirmarPassword { get; set; }

        public string RolSeleccionado { get; set; }
    }
}
