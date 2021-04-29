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
    public class Pedido
    {
        [Key]
        public int IdPedido { get; set; }
        [DisplayName("Nombre")]
        [Column("NombreCliente", TypeName = "nvarchar(50)")]
        [Required]
        public string Nombre { get; set; }
        [DisplayName("Apellido")]
        [Column("ApellidoCliente", TypeName = "nvarchar(50)")]
        [Required]
        public string Apellido { get; set; }
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
        public DateTime FechaPedido { get; set; }
        public DateTime FechaVenta { get; set; }
      
        public double Subtotal { get; set; }
        
        public double TotalIva { get; set; }
        
        public double Total { get; set; }
        [Column("NombreImagen", TypeName = "nvarchar(200)")]
        [DisplayName("Imagen")]
        public string ImageName { get; set; }
        [NotMapped]
        [DisplayName("Archivo cargado")]
        public IFormFile ImageFile { get; set; }

    }
}
