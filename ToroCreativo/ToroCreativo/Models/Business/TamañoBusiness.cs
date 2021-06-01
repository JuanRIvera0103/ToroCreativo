using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToroCreativo.Clases;
using ToroCreativo.Models.Abstract;
using ToroCreativo.Models.DAL;
using ToroCreativo.Models.Entities;

namespace ToroCreativo.Models.Business
{
    public class TamañoBusiness:ITamañoBusiness
    {
        private readonly DbContextToroCreativo _context;

        public TamañoBusiness(DbContextToroCreativo context)
        {
            _context = context;
        }     
        public async Task<List<Tamaño>> ObtenerTamañosSelectProducto()
        {
            var tamaños = await _context.tamaños.ToListAsync();
            return tamaños;
        }
        public async Task<IEnumerable<TamañoDetalle>> ObtenerTamaños()
        {
            await using (_context)
            {
                IEnumerable<TamañoDetalle> listaTamaño =
                    (from tamaño in _context.tamaños
                     join categorias in _context.categorias
                     on tamaño.Categoria equals categorias.idCategoria
                     select new TamañoDetalle
                     {
                         idTamaño = tamaño.idTamaño,
                         Medida = tamaño.Medida,
                         Categoria = categorias.Nombre

                     }).ToList();
                return listaTamaño;
            }
        }
        public async Task<IEnumerable<Tamaño>> ObtenerTamañosSelectPorCategoria(int? id)
        {
            return await _context.tamaños.Where(t => t.Categoria == id).ToListAsync();
        }
        public async Task<Tamaño> ObtenerTamañoPorId(int? id)
        {
            Tamaño tamaño;
            tamaño = null;

            if(id == null)           
                return tamaño;
            else
            {
                tamaño = await _context.tamaños.FindAsync(id);
                return tamaño;
            }
        }

        public async Task GuardarEditarTamaño(Tamaño tamaño)
        {
            try
            {
                if (tamaño.idTamaño == 0)                                
                    _context.Add(tamaño);                
                else
                    _context.Update(tamaño);

                await _context.SaveChangesAsync();
            }
            catch (Exception)
            {

                throw new Exception();
            }
        }
        public async Task<IEnumerable<Tamaño>> ObtenerTamañosCaracteristica(int? id)
        {
            await using (_context)
            {
                IEnumerable<Tamaño> listaTamaño =
                    (from caracteristica in _context.caracteristicas
                     join producto in _context.productos
                     on caracteristica.idProducto equals producto.idProductos
                     join categorias in _context.categorias
                     on producto.Categoria equals categorias.idCategoria
                     join tamaño in _context.tamaños
                     on categorias.idCategoria equals tamaño.Categoria
                     where caracteristica.idCaracteristicas == id
                     select new Tamaño
                     {
                         idTamaño = tamaño.idTamaño,
                         Medida = tamaño.Medida,                         

                     }).ToList();
                return listaTamaño;
            }
        }

    }
}
