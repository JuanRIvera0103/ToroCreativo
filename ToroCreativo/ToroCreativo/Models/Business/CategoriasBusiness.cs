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
        public async Task<IEnumerable<Categorias>> ObtenerCategoriasSelect()
        {
            return await _context.categorias.ToArrayAsync();
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

        public async Task<int> GuardarEditarCategorias(Categorias categorias)
        {
            try
            {
                int guardareditar = 1;
                if (categorias.idCategoria == 0)
                    guardareditar = 0;

                if (categorias.idCategoria == 0)
                {
                    categorias.Estado = "Habilitado";
                    _context.Add(categorias);    
                }
                else
                    _context.Update(categorias);

                await _context.SaveChangesAsync();

                return guardareditar;   
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
        public async Task<int> VerificarProductosHabilitados(int? id)
        {            
            return await _context.productos.Where(p => p.Categoria == id).Where(p => p.Estado == "Habilitado").CountAsync();
        }
    }
}
