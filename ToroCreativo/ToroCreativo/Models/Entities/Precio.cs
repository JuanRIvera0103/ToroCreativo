using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ToroCreativo.Models.Entities
{
    public class Precio
    {
        [Key]
        public int idPrecios { get; set; }
        [Column("Precio")]
        [DisplayName("Precio (Sin IVA)")]
        [Required]
        public double Valor { get; set; }
        [Column(TypeName = "nvarchar(20)")]
        [DisplayName("Fecha Inicial")]

        public string F_Inicio { get; set; }
        [Column(TypeName = "nvarchar(20)")]
        [DisplayName("Fecha Final")]

        public string F_Fin { get; set; }
        [Column("Productos_idProductos")]
        [Required]
        public int idProducto { get; set; }
    }
}
