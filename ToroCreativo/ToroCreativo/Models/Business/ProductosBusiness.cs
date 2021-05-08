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
                     join precios in _context.precios 
                     on productos.idProductos equals precios.idProducto                     
                     join ivas in _context.ivas
                     on productos.idProductos equals ivas.idProducto
                     where ivas.F_Fin == null && precios.F_Fin == null

                     select new ProductoDetalle
                     {
                         idProductos = productos.idProductos,
                         Nombre = productos.Nombre,
                         Descripcion = productos.Descripcion,
                         Estado = productos.Estado,
                         Categoria = categorias.Nombre,
                         Precio = ((ivas.IVA / 100) * precios.Valor) + precios.Valor
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
        public async Task<ProductoRegistroCompleto> ObtenerProductoPorIdIndex(int? id)
        {
            Productos productos;
            productos = null;

            ProductoRegistroCompleto productoRegistro = null;
            if (id == null)
                return productoRegistro;
            else
            {
                productos = await _context.productos.FirstOrDefaultAsync(e => e.idProductos == id);

                productoRegistro = new ProductoRegistroCompleto
                {
                    idProductos = productos.idProductos,
                    Nombre = productos.Nombre,
                    Descripcion = productos.Descripcion,
                    Categoria = productos.Categoria,
                    Estado = productos.Estado
                };

                return productoRegistro;
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

        public async Task<int> GuardarEditarProductos(ProductoRegistroCompleto productoRegistro)
        {
            try
            {                
                int guardareditar = 1;
                if (productoRegistro.idProductos == 0)
                    guardareditar = 0;

                if (productoRegistro.idProductos == 0)
                {
                    var producto = new Productos
                    {
                        idProductos = productoRegistro.idProductos,
                        Nombre = productoRegistro.Nombre,
                        Descripcion = productoRegistro.Descripcion,
                        Categoria = productoRegistro.Categoria,
                        Estado = "Habilitado"
                    };
                    _context.productos.Add(producto);
                    await _context.SaveChangesAsync(); 

                    var caracteristica = new Caracteristica
                    {
                        idCaracteristicas = 0,
                        Color = productoRegistro.Color,
                        Medida = productoRegistro.Medida,
                        Estado = "Habilitado",
                        idProducto = producto.idProductos
                    };
                    _context.caracteristicas.Add(caracteristica);

                    var iva = new Iva
                    {
                        idIva = 0,
                        IVA = productoRegistro.IVA,
                        F_Inicio = DateTime.Now,
                        F_Fin = null,
                        idProducto = producto.idProductos                       
                    };
                    _context.ivas.Add(iva);

                    var precio = new Precio
                    {
                        idPrecios = 0,
                        Valor = productoRegistro.Valor,
                        F_Inicio = DateTime.Now,
                        F_Fin = null,
                        idProducto = producto.idProductos
                    };
                    _context.precios.Add(precio);

                    var imagen = new ImagenProducto
                    {
                        IdImagenProducto = 0,
                        ImageName = productoRegistro.ImageName,
                        ImageFile = productoRegistro.ImageFile,
                        Estado = "Principal",
                        IdProducto = producto.idProductos
                    };
                    _context.ImagenProductos.Add(imagen);
                }
                else
                {
                    var producto = new Productos
                    {
                        idProductos = productoRegistro.idProductos,
                        Nombre = productoRegistro.Nombre,
                        Descripcion = productoRegistro.Descripcion,
                        Categoria = productoRegistro.Categoria,
                        Estado = productoRegistro.Estado
                    };

                    _context.productos.Update(producto);
                }             
                                                  
                await _context.SaveChangesAsync();

                return guardareditar;
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

        public int VerificarProductosEnPedidos(int? id)
        {            
            IEnumerable<ProductoDetalle> listaProductoDetalle =
                    (from productos in _context.productos
                     join caracteristicas in _context.caracteristicas
                     on productos.idProductos equals caracteristicas.idProducto
                     join detallepedido in _context.DetallePedidos
                     on caracteristicas.idCaracteristicas equals detallepedido.IdCaracteristica
                     join pedidos in _context.Pedidos
                     on detallepedido.IdPedido equals pedidos.IdPedido
                     where productos.idProductos == id
                     where pedidos.Estado == "Pendiente" || pedidos.Estado == "Aceptado"
                     select new ProductoDetalle
                     {
                         idProductos = productos.idProductos
                     }).ToList();

            var contador = listaProductoDetalle.Count();
            return (contador);

        }
        public int VerificarProductoRepetido(string nombre)
        {
            return  _context.productos.Where(p => p.Nombre == nombre).Count();
        }
    }
}