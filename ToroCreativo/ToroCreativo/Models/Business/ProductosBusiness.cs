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
    public class ProductosBusiness:IProductosBusiness 
    {
        private readonly DbContextToroCreativo _context;

        public ProductosBusiness(DbContextToroCreativo context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Productos>> ObtenerProductosCliente()
        {
            return await _context.productos.Where(p => p.Estado == "Habilitado").ToListAsync();
        }
        public async Task<IEnumerable<Productos>> ObtenerProductosPorCategoriaCliente(int? id)
        {
            return await _context.productos.Where(p => p.Estado == "Habilitado").Where(p => p.Categoria == id).ToListAsync();
        }

        public async Task<IEnumerable<Productos>> ObtenerProductosPorBusquedaCliente(string busqueda)
        {
            return await _context.productos.Where(p => p.Estado == "Habilitado").Where(p => p.Nombre.Contains(busqueda)).ToListAsync();
        }

        public async Task<IEnumerable<ProductoDetalle>> ObtenerProductos()
        {
            await using (_context)
            {
                IEnumerable<ProductoDetalle> listaProductoDetalle =
                    (from productos in _context.productos
                     join categorias in _context.categorias
                     on productos.Categoria equals categorias.idCategoria
                     select new ProductoDetalle
                     {
                         idProductos = productos.idProductos,
                         Nombre = productos.Nombre,
                         Descripcion = productos.Descripcion,
                         Estado = productos.Estado,
                         Categoria = categorias.Nombre 
                     }).ToList();

                return (listaProductoDetalle);
            }
        }

        public async Task<Productos> ObtenerProductoPorId(int? id)
        {
            Productos productos;
            productos = null;

            if (id == null)
                return productos;
            else
            {
                productos = await _context.productos.FirstOrDefaultAsync(e => e.idProductos == id);
                return productos;
            }
        }

        public async Task<IEnumerable<ProductoDetalle>> ObtenerProductosPorCategoria(int? id)
        {

           await using (_context)
            {
                IEnumerable<ProductoDetalle> listaProductoDetalle =
                    (from productos in _context.productos
                     join categorias in _context.categorias
                     on productos.Categoria equals categorias.idCategoria
                     where productos.Categoria == id
                     select new ProductoDetalle
                     {
                         idProductos = productos.idProductos,
                         Nombre = productos.Nombre,
                         Descripcion = productos.Descripcion,
                         Estado = productos.Estado,
                         Categoria = categorias.Nombre
                     }).ToList();

                return (listaProductoDetalle);
            }
            
        }

        public async Task GuardarEditarProductos(Productos productos)
        {
            try
            {
                if (productos.idProductos == 0)
                {
                    productos.Estado = "Habilitado";
                    _context.Add(productos);
                }                    
                else
                    _context.Update(productos);

                await _context.SaveChangesAsync();
            }
            catch (Exception)
            {

                throw new Exception();
            }
        }
        public async Task CambiarEstadoProductos(Productos productos)
        {
            try
            {
                if (productos.Estado.Equals("Habilitado"))
                    productos.Estado = "Deshabilitado";
                else
                    productos.Estado = "Habilitado";

                _context.productos.Update(productos);
                await _context.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }
    }
}