using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ToroCreativo.Models.Entities
{
    public class DetallePedido
    {
        [Key]
        public int IdDetallePedido { get; set; }
        [Required]
        public int IdPedido { get; set; }
        [Required]
        public int IdCaracteristica { get; set; }
        [Required]
        public int Cantidad { get; set; }
        [Required]
        public double Subtotal { get; set; }
        [Required]
        public double TotalIva { get; set; }
        [Required]
        public double Total { get; set; }

    }
}
