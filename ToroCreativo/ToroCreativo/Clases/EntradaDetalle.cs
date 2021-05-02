using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToroCreativo.Clases
{
    public class EntradaDetalle
    {
        public int idEntrada { get; set; }
        public int CantidadInicial { get; set; }
        public int CantidadActual { get; set; }
        public DateTime F_Inicio { get; set; }
        public int Caracteristica { get; set; }
        public int idProducto { get; set; }
        public string Estado { get; set; }
    }
}
