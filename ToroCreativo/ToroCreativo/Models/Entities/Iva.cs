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
        [DisplayName("Porcentaje Iva")]
        [Required(ErrorMessage = "El porcentaje de IVA es requerida")]
        [Range(0, 100, ErrorMessage = "El IVA debe de estar entre los porcentajes de 0 al 100")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "El IVA solo debe de contener números enteros positivos")]
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
