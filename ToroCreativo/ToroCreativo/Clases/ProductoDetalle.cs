using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToroCreativo.Clases
{
    public class ProductoDetalle
    {
        public int idProductos { get; set; }
        public string Nombre { get; set; }   
        public string Descripcion { get; set; }
        public string Estado { get; set; }
        public string Categoria { get; set; }
        public double Precio { get; set; }
    }
}
