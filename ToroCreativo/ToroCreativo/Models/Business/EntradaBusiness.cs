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
    public class EntradaBusiness:IEntradaBusiness
    {
        private readonly DbContextToroCreativo _context;

        public EntradaBusiness(DbContextToroCreativo context)
        {
            _context = context;
        }

        public async Task<List<Entrada>> ObtenerEntradaProducto(int? id)
        {
            return await _context.entradas.Where(p => p.idProducto == id).OrderByDescending(p => p.idEntrada).ToListAsync();
        }

        public async Task GuardarEntrada(Entrada entrada)
        {
            try
            {
                entrada.F_Inicio = DateTime.Now.ToString("dd/MM/yyyy");
                _context.Add(entrada);

                await _context.SaveChangesAsync();
            }
            catch (Exception)
            {

                throw new Exception();
            }
        }
    }
}
