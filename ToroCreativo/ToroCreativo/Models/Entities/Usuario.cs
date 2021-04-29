using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace ToroCreativo.Models.Entities
{
    public class Usuario:IdentityUser
    {
        public string Estado { get; set; }
        
    }
}
