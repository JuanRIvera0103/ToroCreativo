using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToroCreativo.Models.Abstract;
using ToroCreativo.Models.DAL;
using ToroCreativo.Models.Entities;

namespace ToroCreativo.Models.Business
{
    public class CategoriasBusiness:ICategoriasBusiness
    {
        private readonly DbContextToroCreativo _context;

        public CategoriasBusiness(DbContextToroCreativo context)
        {
            _context = context;
        }

        public async Task<List<Categorias>> ObtenerCategorias()
        {
            return await _context.categorias.ToListAsync();
        }

        public async Task<Categorias> ObtenerCategoriaPorId(int? id)
        {
            Categorias categorias;
            categorias = null;

            if (id == null)
                return categorias;
            else
            {
                categorias = await _context.categorias.FirstOrDefaultAsync(e => e.idCategoria == id );
                return categorias;
            }
        }

        public async Task GuardarEditarCategorias(Categorias categorias)
        {
            try
            {               
                if (categorias.idCategoria == 0)
                    _context.Add(categorias);
                else
                    _context.Update(categorias);

                await _context.SaveChangesAsync();
            }
            catch (Exception)
            {

                throw new Exception();
            }            
        }
        public async Task CambiarEstadoCategoria(Categorias categorias)
        {            
            try
            {
                if (categorias.Estado.Equals("Habilitado"))
                    categorias.Estado = "Deshabilitado";
                else
                    categorias.Estado = "Habilitado";

                _context.categorias.Update(categorias);
                await _context.SaveChangesAsync();            
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }
    }
}
