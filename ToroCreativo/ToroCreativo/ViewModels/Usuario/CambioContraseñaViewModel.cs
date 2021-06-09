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
        [StringLength(16, ErrorMessage = "La contraseña debe tener entre {2} y {1} caracteres.", MinimumLength = 8)]
        public string PasswordAntigua { get; set; }

        [Required(ErrorMessage = "La contraseña es requerida")]
        [DisplayName("Contraseña nueva")]
        [DataType(DataType.Password)]
        [StringLength(16, ErrorMessage = "La contraseña debe tener entre {2} y {1} caracteres.", MinimumLength = 8)]
        public string PasswordNueva { get; set; }


        [Required(ErrorMessage = "La contraseña es requerida")]
        [DisplayName("Confirmar contraseña nueva")]
        [DataType(DataType.Password)]
        [StringLength(16, ErrorMessage = "La contraseña debe tener entre {2} y {1} caracteres.", MinimumLength = 8)]
        [Compare("PasswordNueva", ErrorMessage = "La contraseña nueva no coinciden")]
        public string ConfirmarPasswordNueva { get; set; }

    }
}
