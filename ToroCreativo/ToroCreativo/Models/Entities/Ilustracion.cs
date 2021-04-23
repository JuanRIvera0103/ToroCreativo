using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ToroCreativo.Models.Entities
{
    public class Ilustracion
    {
        [Key]
        public int IdIlustracion { get; set; }
        [DisplayName("Nombre")]
        [Column("NombreIlustracion", TypeName = "nvarchar(50)")]
        [Required]
        public string Nombre { get; set; }
        [Required]
        public int IdGenero { get; set; }
        [Column("EstadoIlustracion", TypeName = "nvarchar(20)")]
        [Required]
        public string Estado { get; set; }
        [Column("Descripcion", TypeName = "nvarchar(500)")]
        [Required]
        public string Descripcion { get; set; }
       
    }
}
