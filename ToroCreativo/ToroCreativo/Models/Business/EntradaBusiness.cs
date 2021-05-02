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
    public class EntradaBusiness : IEntradaBusiness
    {
        private readonly DbContextToroCreativo _context;

        public EntradaBusiness(DbContextToroCreativo context)
        {
            _context = context;
        }

        public async Task<Entrada> ObtenerEntradaPorId(int? id)
        {
            return await _context.entradas.FindAsync(id);
        }
        public async Task<List<EntradaDetalle>> ObtenerEntradaProducto(int? id)
        {
            var entradas = await _context.entradas.Where(p => p.idProducto == id).ToListAsync();            
            List<EntradaDetalle> listaEntradas = new List<EntradaDetalle>();
            DateTime fechaActual = DateTime.Now;
            foreach (var entrada in entradas)
            {
                var entradaDetalle = new EntradaDetalle
                {
                    idEntrada = entrada.idEntrada,
                    CantidadInicial = entrada.CantidadInicial,
                    CantidadActual = entrada.CantidadActual,
                    F_Inicio = entrada.F_Inicio,
                    Caracteristica = entrada.Caracteristica,
                    idProducto = entrada.idProducto,
                    Estado = ""
                };

                TimeSpan diferencia = fechaActual - entradaDetalle.F_Inicio;
                var diferenciaMinutos = diferencia.TotalMinutes;

                if (diferenciaMinutos < 5)
                    entradaDetalle.Estado = "Valido";
                else
                    entradaDetalle.Estado = "Invalido";

                listaEntradas.Add(entradaDetalle);
            }
            return listaEntradas;
        }

        public async Task<int> GuardarEditarEntrada(Entrada entrada)
        {
            try
            {
                int guadarEditar = 1;
                if (entrada.idEntrada == 0)
                    guadarEditar = 0;

                if (entrada.idEntrada == 0)
                {
                    entrada.F_Inicio = DateTime.Now;
                    _context.Add(entrada);
                }
                else
                {
                    _context.Update(entrada);
                }

                await _context.SaveChangesAsync();

                return guadarEditar;
            }
            catch (Exception)
            {

                throw new Exception();
            }
        }
    }
}
