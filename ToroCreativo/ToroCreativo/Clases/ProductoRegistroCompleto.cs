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
    public class ProductoRegistroCompleto
    {
        //producto
        public int idProductos { get; set; }
        [Required(ErrorMessage = "EL nombre es requerida")]
        //[StringLength(16, ErrorMessage = "El {0} debe tener al menos {2} y maximo {1} caracteres.", MinimumLength = 8)]
        public string Nombre { get; set; }
        [Required]
        public string Descripcion { get; set; }
        [Required]
        public int Categoria { get; set; }    
        public string Estado { get; set; }

        //Característica
        [Required]
        public string Color { get; set; }
        [Required]
        public int Medida { get; set; }

        //Precio   
        public double Valor { get; set; }

        //IVA
        [DisplayName("% Iva")]
        [Required]
        public double IVA { get; set; }

        //Imagen
        public string ImageName { get; set; }
        [NotMapped]
        [DisplayName("Archivo cargado")]
        public IFormFile ImageFile { get; set; }
    }
}
