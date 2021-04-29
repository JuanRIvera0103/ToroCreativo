using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ToroCreativo.Models.Entities
{
    public class ImagenIlustracion
    {
        [Key]
        public int IdImagenIlustracion { get; set; }
        [Required]
        public int IdIlustracion { get; set; }
        [Required]
        [Column("NombreImagen", TypeName = "nvarchar(200)")]
        [DisplayName("Imagen")]
        public string ImageName { get; set; }
        [NotMapped]
        [DisplayName("Archivo cargado")]
        public IFormFile ImageFile { get; set; }
    }
}
