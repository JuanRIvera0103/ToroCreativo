using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ToroCreativo.Models.Entities
{
    public class Generos
    {
        [Key]
        public int Idgenero { get; set; }
        [Required]
        public string Nombre { get; set; }
        public string Estado  { get; set; }
    }
}
