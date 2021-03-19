using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToroCreativo.Models.Entities;

namespace ToroCreativo.Clases
{
    public class CategoriaProductoVista
    {
        public Categorias categorias { get; set; } 
        public ProductoDetalle productos { get; set; }
    }
}
