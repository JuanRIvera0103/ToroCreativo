using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToroCreativo.Clases
{
    public class CarritoDetalle
    {
        public int IdProducto { get; set; }
        public int IdCaracteristica { get; set; }
        public string Color { get; set; }
        public string Nombre { get; set; }
        public string Medida { get; set; }
        public double IVA { get; set; }
        public double Subtotal { get; set; }
        public double Precio { get; set; }
        public int Cantidad { get; set; }
    }
}
