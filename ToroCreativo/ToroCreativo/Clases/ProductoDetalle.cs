using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace ToroCreativo.Clases
{
    public class ProductoDetalle
    {
        public int idProductos { get; set; }
        public string Nombre { get; set; }
        [DisplayName("Descripción")]
        public string Descripcion { get; set; }
        public string Estado { get; set; }
        [DisplayName("Categoría")]
        public string Categoria { get; set; }
        public double Precio { get; set; }
    }
}
