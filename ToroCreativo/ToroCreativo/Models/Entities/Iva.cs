using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ToroCreativo.Models.Entities
{
    public class Iva
    {
        [Key]
        public int idIva { get; set; }
        [Column("Precio")]
        [DisplayName("Precio (Sin IVA)")]
        [Required]
        public double IVA { get; set; }
        [DisplayName("Fecha Inicial")]

        public DateTime F_Inicio { get; set; }
        [DisplayName("Fecha Final")]

        public DateTime? F_Fin { get; set; }
        [Column("Productos_idProductos")]
        [Required]
        public int idProducto { get; set; }
    }
}
