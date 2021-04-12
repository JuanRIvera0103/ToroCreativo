using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ToroCreativo.Models.Entities
{
    public class Tamaño
    {
        [Key]
        public int idTamaño { get; set; }
        [Column("Tamaño", TypeName = "nvarchar(30)")]
        [Required]
        public string Medida { get; set; }
        [Column("Categoria_idCategoria")]
        [Required]
        public int Categoria { get; set; }
    }
}
