using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToroCreativo.Clases
{
    public class DetallePedidoTabla
    {
        public string Producto { get; set; }
        public int IdCaractersiticas { get; set; }
        public int Cantidad { get; set; }        
        public double Subtotal { get; set; }        
        public double TotalIva { get; set; }        
        public double Total { get; set; }
    }
}
