using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ToroCreativo.Models.Entities
{
    public class Caracteristica
    {
        [Key]
        public int idCaracteristicas { get; set; }
        [Column(TypeName = "nvarchar(7)")]
        [Required]
        public string Color { get; set; }
        [Column(TypeName = "nvarchar(20)")]
        public string Estado { get; set; }
        [Column("Productos_idProductos")]
        [Required]
        public int idProducto { get; set; }
        [Column("Tamaño_idUnidades_medidas")]
        [Required]
        public int Medida { get; set; }
    }
}
