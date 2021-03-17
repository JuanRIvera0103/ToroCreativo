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
    public class GenerosBusiness:IGenerosBusiness 
    {
        private readonly DbContextToroCreativo _context;

        public GenerosBusiness(DbContextToroCreativo context)
        {
            _context = context;
        }

        public async Task<List<Generos>> ObtenerGeneros()
        {
            return await _context.generos.ToListAsync();
        }

        public async Task<Generos> ObtenerGeneroPorId(int? id)
        {
            Generos generos;
            generos = null;
            
            if (id == null)
                return generos;
            else
            {
                generos = await _context.generos.FirstOrDefaultAsync(e => e.idGenero == id);
                return generos;
            }
        }

        public async Task GuardarEditarGeneros(Generos generos)
        {
            try
            {
                if (generos.idGenero == 0)
                    _context.Add(generos);
                else
                    _context.Update(generos);

                await _context.SaveChangesAsync();
            }
            catch (Exception)
            {

                throw new Exception();
            }
        }
        public async Task CambiarEstadoGenero(Generos generos)
        {
            try
            {
                if (generos.Estado.Equals("Habilitado"))
                    generos.Estado = "Deshabilitado";
                else
                    generos.Estado = "Habilitado";

                _context.generos.Update(generos);
                await _context.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }
    }
}
