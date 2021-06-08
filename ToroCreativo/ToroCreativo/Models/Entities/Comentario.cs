using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ToroCreativo.Models.Entities
{
    public class Comentario
    {
        [Key]
        public int IdComentario { get; set; } = 0;
        [Column("IdUsuario", TypeName = "varchar(255)")]
        [Required]
        public string IdUsuario { get; set; }
        [Required]
        public int IdIlustracion { get; set; }
        [Required]
        public string Texto { get; set; }
        [Required]
        public string Fecha { get; set; }

    }
}
