﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToroCreativo.Clases;
using ToroCreativo.Models.Entities;

namespace ToroCreativo.Models.Abstract
{
    public interface IProductosBusiness
    {
        Task<IEnumerable<ProductoDetalle>> ObtenerProductos();
        Task<Productos> ObtenerProductoPorId(int? id);
        Task<IEnumerable<ProductoDetalle>> ObtenerProductosPorCategoria(int? id);
        Task<int> GuardarEditarProductos(ProductoRegistroCompleto productos);
        Task CambiarEstadoProductos(Productos productos);
        Task<IEnumerable<Productos>> ObtenerProductosCliente();
        Task<IEnumerable<Productos>> ObtenerProductosPorCategoriaCliente(int? id);
        Task<IEnumerable<Productos>> ObtenerProductosPorBusquedaCliente(string busqueda);
        int VerificarProductosEnPedidos(int? id);
        Task<ProductoRegistroCompleto> ObtenerProductoPorIdIndex(int? id);
        int VerificarProductoRepetido(string nombre);
        Task<List<CarritoDetalle>> ObtenerCarrito(ISession session);
    }
}
