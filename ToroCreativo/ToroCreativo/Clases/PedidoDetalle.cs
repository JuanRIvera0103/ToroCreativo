using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToroCreativo.Clases
{
    public class PedidoDetalle
    {
        public int IdPedido { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Cedula { get; set; }        
        public string Telefono { get; set; }
        public string Estado { get; set; }
        public string FechaPedido { get; set; }
        public string FechaVenta { get; set; }
        public string Subtotal { get; set; }
        public string TotalIva { get; set; }
        public string Total { get; set; }
        public string Correo { get; set; }
        public string ImageName { get; set; }
    }
}
