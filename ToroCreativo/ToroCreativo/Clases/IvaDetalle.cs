using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToroCreativo.Clases
{
    public class IvaDetalle
    {
        public int idIva { get; set; }
        public double IVA { get; set; }
        public DateTime F_Inicio { get; set; }
        public DateTime? F_Fin { get; set; }
        public int idProducto { get; set; }
        public string Estado { get; set; }
    }
}
