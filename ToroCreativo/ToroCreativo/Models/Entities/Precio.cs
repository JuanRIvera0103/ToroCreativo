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
        [DisplayName("Precio sin Iva")]
        [Required(ErrorMessage = "El precio es requerida")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "El precio solo debe de contener números enteros positivos")]
        public double Valor { get; set; }
        [DisplayName("Fecha Inicial")]

        public DateTime F_Inicio { get; set; }
        [DisplayName("Fecha Final")]

        public DateTime? F_Fin { get; set; }
        [Column("Productos_idProductos")]
        [Required]
        public int idProducto { get; set; }
    }
}
