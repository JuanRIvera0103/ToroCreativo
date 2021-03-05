using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToroCreativo.Models.Entities;

namespace ToroCreativo.Models.DAL
{
    public class DbContextToroCreativo:DbContext 
    {
        public DbContextToroCreativo(DbContextOptions<DbContextToroCreativo> options):base(options)
        {

        }
        public DbSet<Categorias> categorias { get; set; }
    }
}
