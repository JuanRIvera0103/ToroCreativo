using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ToroCreativo.ViewModels.Usuario
{
    public class CambioContraseñaViewModel
    {
        


        [Required(ErrorMessage = "La contraseña es requerida")]
        [DisplayName("Contraseña antigua")]
        [DataType(DataType.Password)]
        [StringLength(16, ErrorMessage = "El {0} debe tener al menos {2} y maximo {1} caracteres.", MinimumLength = 8)]
        public string PasswordAntigua { get; set; }


        [Required(ErrorMessage = "La contraseña es requerida")]
        [DisplayName("Confirmar Contraseña antigua")]
        [DataType(DataType.Password)]
        [StringLength(16, ErrorMessage = "El {0} debe tener al menos {2} y maximo {1} caracteres.", MinimumLength = 8)]
        [Compare("PasswordAntigua", ErrorMessage = "La contraseña antigua no coinciden")]
        public string ConfirmarPasswordAntigua { get; set; }


        [Required(ErrorMessage = "La contraseña es requerida")]
        [DisplayName("Contraseña nueva")]
        [DataType(DataType.Password)]
        [StringLength(16, ErrorMessage = "El {0} debe tener al menos {2} y maximo {1} caracteres.", MinimumLength = 8)]
        public string PasswordNueva { get; set; }


        [Required(ErrorMessage = "La contraseña es requerida")]
        [DisplayName("Confirmar Contraseña nueva")]
        [DataType(DataType.Password)]
        [StringLength(16, ErrorMessage = "El {0} debe tener al menos {2} y maximo {1} caracteres.", MinimumLength = 8)]
        [Compare("PasswordNueva", ErrorMessage = "La contraseña nueva no coinciden")]
        public string ConfirmarPasswordNueva { get; set; }

    }
}
