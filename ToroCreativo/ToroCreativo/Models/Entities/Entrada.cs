using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ToroCreativo.Models.Entities
{
    public class Entrada
    {
        [Key]
        public int idEntrada { get; set; }        
        [DisplayName("Cantidad")]
        [Required(ErrorMessage = "La cantidad es requerida")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "La cantidad solo debe de contener números enteros positivos")]
        public int CantidadInicial { get; set; }
        [DisplayName("Cantidad Actual")]
        public int CantidadActual { get; set; }
        [DisplayName("Fecha Inicial")]
        public DateTime F_Inicio { get; set; }

        [Column("Caracteristica_idCaracteristica")]
        public int Caracteristica { get; set; }
        [Column("Producto_idProductos")]
        public int idProducto { get; set; }
    }
}
