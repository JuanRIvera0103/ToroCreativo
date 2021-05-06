using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ToroCreativo.Models.Entities
{
    public class Cliente
    {
        [Key]
        public int IdCliente{ get; set; }
        [DisplayName("Nombre")]
        [Column("NombreCliente", TypeName = "nvarchar(50)")]
        [Required]
        public string Nombre { get; set; }
        [DisplayName("Apellido")]
        [Column("ApellidoCliente", TypeName = "nvarchar(50)")]
        [Required]
        public string Apellido{get; set;}
        [Column("IdUsuario", TypeName = "varchar(255)")]
        [Required]
        
        public string IdUsuario { get; set; }
        [Column("EstadoCliente", TypeName = "nvarchar(13)")]
        [Required]
        public string Estado { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string Direccion { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(20)")]
        public string Cedula { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(20)")]
        public string Telefono { get; set; }
    }
}
