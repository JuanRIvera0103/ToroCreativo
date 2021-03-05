using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ToroCreativo.Models.Entities
{
    public class Categorias
    {
        [Key]
        public int idCategoria { get; set; }
        [Required]
        public string Nombre { get; set; }
        public string Estado { get; set; }
    }
}
