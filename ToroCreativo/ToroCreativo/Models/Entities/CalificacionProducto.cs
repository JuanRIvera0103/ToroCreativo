using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ToroCreativo.Models.Entities
{
    public class CalificacionProducto
    {
        [Key]
        public int IdCalificacion { get; set; } = 0;
        [Column("IdUsuario", TypeName = "varchar(255)")]
        public string IdUsuario { get; set; }
        public int IdProducto { get; set; }
        [Required]
        public int Calificacion { get; set; }

    }
}
