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
    public class IvasBusiness : IIvasBusiness
    {
        private readonly DbContextToroCreativo _context;

        public IvasBusiness(DbContextToroCreativo context)
        {
            _context = context;
        }
        public async Task<Iva> ObtenerIvaPorId(int? id)
        {
            return await _context.ivas.FindAsync(id);
        }
        public async Task<List<Iva>> ObteneIvasProducto(int? id)
        {
            return await _context.ivas.Where(p => p.idProducto == id).OrderByDescending(p => p.idIva).ToListAsync();
        }

        public async Task GuardarEditarIva(Iva ivas)
        {
            try
            {
                if (ivas.idIva == 0)
                {
                    var ultimoiva = _context.ivas.Where(i => i.idProducto == ivas.idProducto)
                        .OrderByDescending(p => p.idIva).FirstOrDefault();
                    if (ultimoiva != null)
                    {
                        ultimoiva.F_Fin = DateTime.Now;
                        _context.Update(ultimoiva);
                    }

                    ivas.F_Inicio = DateTime.Now;
                    _context.Add(ivas);
                }
                else
                {
                    _context.Update(ivas);
                }

                await _context.SaveChangesAsync();
            }
            catch (Exception)
            {

                throw new Exception();
            }
        }

    }
}
