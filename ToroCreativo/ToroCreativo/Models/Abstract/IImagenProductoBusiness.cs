﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToroCreativo.Models.Entities;

namespace ToroCreativo.Models.Abstract
{
    public interface IImagenProductoBusiness
    {
        Task GuardarEditarImagenProducto(ImagenProducto imagenProducto);
        Task EliminarImagenProducto(int id);
        Task<ImagenProducto> ObtenerImagenProductoPorId(int? id);
        Task<ImagenProducto> ObtenerImagenProductoPorProducto(int? id);
        Task<List<ImagenProducto>> ObtenerImagenes();
    }
}