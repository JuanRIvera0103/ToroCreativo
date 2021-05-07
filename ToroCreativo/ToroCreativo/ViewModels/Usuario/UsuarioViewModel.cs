using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ToroCreativo.ViewModels.Usuario
{
    public class UsuarioViewModel
    {
        public string Id { get; set; }

        [Required(ErrorMessage = "El email es requerido")]
        [EmailAddress(ErrorMessage = "Email invalido")]
        public string Email { get; set; }


        [Required(ErrorMessage = "La contraseña es requerida")]
        [DisplayName("Contraseña")]
        [DataType(DataType.Password)]
        [StringLength(16, ErrorMessage = "El {0} debe tener al menos {2} y maximo {1} caracteres.", MinimumLength = 8)]
        public string Password { get; set; }


        [Required(ErrorMessage = "La contraseña es requerida")]
        [DisplayName("Confirmar Contraseña")]
        [DataType(DataType.Password)]
        [StringLength(16, ErrorMessage = "El {0} debe tener al menos {2} y maximo {1} caracteres.", MinimumLength = 8)]
        [Compare("Password", ErrorMessage = "Las contraseñas no coinciden")]
        public string ConfirmarPassword { get; set; }
        public List<string> Rol { get; set; }
        [Required(ErrorMessage = "El rol es requerida")]
        public string RolSeleccionado { get; set; }
        public string Estado { get; set; }

    }
}
