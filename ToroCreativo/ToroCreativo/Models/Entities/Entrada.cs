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
        [Required]
        public int Cantidad { get; set; }
        [Column(TypeName = "nvarchar(20)")]
        [DisplayName("Fecha Inicial")]
        public string F_Inicio { get; set; }

        [Column("Caracteristica_idCaracteristica")]
        public int Caracteristica { get; set; }
        [Column("Producto_idProductos")]
        public int idProducto { get; set; }
    }
}
