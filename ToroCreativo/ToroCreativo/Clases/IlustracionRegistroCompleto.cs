using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ToroCreativo.Clases
{
    public class IlustracionRegistroCompleto
    {
        public int IdIlustracion { get; set; }
        [Required(ErrorMessage = "El nombre es requerido")]
        [StringLength(50)]
        [RegularExpression("^[A-Z][a-zA-ZñÑáéíóúÁÉÍÓÚ ]*$", ErrorMessage = "El nombre debe de comenzar con mayúscula y solo debe de contener letras")]
        public string Nombre { get; set; }
        [DisplayName("Genero")]
        [Required(ErrorMessage = "El género es requerido")]
        public int IdGenero { get; set; }                
        [DisplayName("Descripción")]
        [Required(ErrorMessage = "La descripción es requerida")]
        [StringLength(500)]       
        public string Descripcion { get; set; }
        public string Estado { get; set; }

        //Imagen
        public string ImageName { get; set; }
        [NotMapped]
        [DisplayName("Imagen Principal de la ilustración")]
        [Required(ErrorMessage = "La imagen principal de la ilustración es requerida")]
        [RegularExpression("^.*.(jpg|png|jpeg)$", ErrorMessage = "La imagen solo permite formatos .jpg .png o .jpeg")]
        public IFormFile ImageFile { get; set; }
    }
}
