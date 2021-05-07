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
    public class CaracteristicaBusiness:ICaracteristicaBusiness
    {
        private readonly DbContextToroCreativo _context;

        public CaracteristicaBusiness(DbContextToroCreativo context)
        {
            _context = context;
        }

        public async Task<Caracteristica> ObtenerCaracteristicaPorId(int? id)
        {
            return await _context.caracteristicas.FindAsync(id);
        }
        public async Task<IEnumerable<CaracteristicaDetalle>> ObtenerCaracteristicaDetallePorId(int? id)
        {
            await using (_context)
            {
                IEnumerable<CaracteristicaDetalle> caracteristicas =
                    (from caracteristica in _context.caracteristicas
                     join tamaño in _context.tamaños
                     on caracteristica.Medida equals tamaño.idTamaño
                     where caracteristica.idCaracteristicas == id
                     select new CaracteristicaDetalle
                     {
                         idCaracteristicas = caracteristica.idCaracteristicas,
                         Color = caracteristica.Color,
                         Medida = tamaño.Medida,
                         Estado = caracteristica.Estado,
                         idProducto = caracteristica.idProducto
                     }).ToList();
                return caracteristicas;
            }
        }
        public async Task<IEnumerable<CaracteristicaDetalle>> ObtenerCaracteristicasProducto(int? id)
        {
            var entradas = await _context.entradas.Where(p => p.idProducto == id).ToListAsync();
            await using (_context)
            {
                IEnumerable<CaracteristicaDetalle> caracteristicas =
                    (from caracteristica in _context.caracteristicas
                     join tamaño in _context.tamaños
                     on caracteristica.Medida equals tamaño.idTamaño
                     where caracteristica.idProducto == id
                     select new CaracteristicaDetalle
                     {
                         idCaracteristicas = caracteristica.idCaracteristicas,
                         Color = caracteristica.Color,
                         Medida = tamaño.Medida,
                         Estado = caracteristica.Estado,
                         idProducto = caracteristica.idProducto,
                         Cantidad = 0                                                  
                     }).ToList();
                foreach (var caracteristica in caracteristicas)
                {
                    foreach (var entrada in entradas)
                    {
                        if (entrada.Caracteristica == caracteristica.idCaracteristicas)
                        {
                            caracteristica.Cantidad = caracteristica.Cantidad + entrada.CantidadActual;
                        }
                    }
                }
                return caracteristicas;
            }
        }
        public async Task<List<Caracteristica>> ObtenerCaracteristicasProductoDistinct(int? id)
        {
            
         

            var caracteristicas = await _context.caracteristicas.Where(p => p.idProducto == id)
                .Select(o => new { o.Color }).Distinct().ToListAsync();
            List<Caracteristica> listaCaracteristica = new List<Caracteristica>();
            foreach (var item in caracteristicas)
            {
                var caracteristica = new Caracteristica
                {
                    Color = item.Color
                };
                listaCaracteristica.Add(caracteristica);
            }
           
            return listaCaracteristica;
        }
        public async Task<List<Tamaño>> ObtenerTamañosProductoDistinct(int? id)
        {
            var tamaños = await _context.caracteristicas.Where(p => p.idProducto == id)
                            .Select(o => new { o.Medida }).Distinct().ToListAsync();
            List<Tamaño> listaTamaños = new List<Tamaño>();
            foreach (var item in tamaños)
            {
                var tamaño = await _context.tamaños.FindAsync(item.Medida);
                listaTamaños.Add(tamaño);
            }
            return listaTamaños;
        }

        public async Task<int> GuardarEditarCaracteristica(Caracteristica caracteristica)
        {
            try
            {
                int guadarEditar = 1;
                if (caracteristica.idCaracteristicas == 0)
                    guadarEditar = 0;

                if (caracteristica.idCaracteristicas == 0)
                {
                    caracteristica.Estado = "Habilitado";
                    _context.Add(caracteristica);
                }
                else
                    _context.Update(caracteristica);

                await _context.SaveChangesAsync();

                return guadarEditar;
                
            }
            catch (Exception)
            {

                throw new Exception();
            }
        }

        public async Task CambiarEstadoCaracteristica(Caracteristica caracteristica)
        {
            try
            {
                if (caracteristica.Estado.Equals("Habilitado"))
                    caracteristica.Estado = "Deshabilitado";
                else
                    caracteristica.Estado = "Habilitado";

                _context.caracteristicas.Update(caracteristica);
                await _context.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }

        public async Task<IEnumerable<Caracteristica>> ObtenerCaracteristicasSelectPorProducto(int? id)
        {
            return await _context.caracteristicas.Where(c => c.idProducto == id).ToListAsync();
        }
        public int VerificarCaracteristicaEnPedidos(int? id)
        {
            IEnumerable<Caracteristica> listaCaracteristicas =
                    (from caracteristicas in _context.caracteristicas
                     join detallepedido in _context.DetallePedidos
                     on caracteristicas.idCaracteristicas equals detallepedido.IdCaracteristica
                     join pedidos in _context.Pedidos
                     on detallepedido.IdPedido equals pedidos.IdPedido
                     where caracteristicas.idCaracteristicas == id
                     where pedidos.Estado == "Pendiente" || pedidos.Estado == "Aceptado"
                     select new Caracteristica
                     {
                         idCaracteristicas = caracteristicas.idCaracteristicas
                     }).ToList();

            var contador = listaCaracteristicas.Count();
            return (contador);

        }
    }
}
