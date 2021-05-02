using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToroCreativo.Clases
{
    public class CaracteristicaDetalle
    {
        public int idCaracteristicas { get; set; }
        public string Color { get; set; }
        public string Estado { get; set; }
        public int idProducto { get; set; }
        public string Medida { get; set; }
        public int Cantidad { get; set; }
    }
}
