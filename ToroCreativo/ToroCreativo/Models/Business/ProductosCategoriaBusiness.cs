using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToroCreativo.Models.DAL;

namespace ToroCreativo.Models.Business
{
    public class ProductosCategoriaBusiness
    {
        private readonly DbContextToroCreativo _context;

        public ProductosCategoriaBusiness(DbContextToroCreativo context)
        {
            _context = context;
        }
       
    }
}
