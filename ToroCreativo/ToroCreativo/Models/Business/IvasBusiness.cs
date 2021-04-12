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
    public class IvasBusiness:IIvasBusiness
    {
        private readonly DbContextToroCreativo _context;

        public IvasBusiness(DbContextToroCreativo context)
        {
            _context = context;
        }

        public async Task<List<Iva>> ObteneIvasProducto(int? id)
        {
            return await _context.ivas.Where(p => p.idProducto == id).OrderByDescending(p => p.idIva).ToListAsync();
        }

        public async Task GuardarIva(Iva ivas)
        {
            try
            {
                var ultimoiva = _context.ivas.OrderByDescending(p => p.idIva).FirstOrDefault();
                if (ultimoiva != null)
                {
                    ultimoiva.F_Fin = DateTime.Now.ToString("dd/MM/yyyy");
                    _context.Update(ultimoiva);
                }

                ivas.F_Inicio = DateTime.Now.ToString("dd/MM/yyyy");
                _context.Add(ivas);

                await _context.SaveChangesAsync();
            }
            catch (Exception)
            {

                throw new Exception();
            }
        }
    }
}
