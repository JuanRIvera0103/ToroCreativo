using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ToroCreativo.Models.Entities
{
    public class Categorias
    {
        [Key]
        public int idCategoria { get; set; }   
        [Required(ErrorMessage = "El nombre es requerido")]
        [StringLength(30)]
        [RegularExpression("^[A-Z][a-zA-ZñÑáéíóúÁÉÍÓÚ_ ]*$", ErrorMessage = "El nombre debe de comenzar con mayúscula, aparte de tener una letra más y solo debe de contener letras")]
        public string Nombre { get; set; }
        public string Estado { get; set; }
    }
}
