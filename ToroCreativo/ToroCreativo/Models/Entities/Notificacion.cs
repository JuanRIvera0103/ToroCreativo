using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ToroCreativo.Models.Entities
{
    public class Notificacion
    {
        [Key]
        public int IdNotificacion { get; set; } = 0;
        [Column("IdUsuario", TypeName = "varchar(255)")]
        [Required]
        public string IdUsuario { get; set; }
        [Required]
        public bool Leido { get; set; } = false;
        [Required]
        public string Fecha { get; set; } = DateTime.Now.ToShortDateString();
        [Required]
        public string Tipo { get; set; }
        public int Direccion { get; set; }
    }
}
