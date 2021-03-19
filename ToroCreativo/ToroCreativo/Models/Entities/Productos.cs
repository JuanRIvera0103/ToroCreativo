using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ToroCreativo.Models.Entities
{
    public class Productos
    {
        [Key]
        public int idProductos { get; set; }
        
        [Column(TypeName="nvarchar(30)")]
        [Required]
        public string Nombre { get; set; }
        [Column(TypeName ="text(100)")]
        [Required]
        public string Descripcion { get; set; }
        [Column(TypeName = "nvarchar(20)")]
        [Required]
        public string Estado { get; set; }
        [Column("Categoria_idCategorias")]
        [Required]
        public int Categoria { get; set; }
    }
}
