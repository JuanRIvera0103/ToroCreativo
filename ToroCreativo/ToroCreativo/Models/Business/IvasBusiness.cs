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
        public async Task<List<IvaDetalle>> ObteneIvasProducto(int? id)
        {
            var ivas = await _context.ivas.Where(p => p.idProducto == id).ToListAsync();
            List<IvaDetalle> listaIvas = new List<IvaDetalle>();
            DateTime fechaActual = DateTime.Now;
            foreach (var iva in ivas)
            {
                var ivaDetalle = new IvaDetalle
                {
                    idIva = iva.idIva,
                    IVA = iva.IVA,
                    F_Inicio = iva.F_Inicio,
                    F_Fin = iva.F_Fin,
                    idProducto = iva.idProducto,
                    Estado = ""
                };

                if (ivaDetalle.F_Fin == null)
                {
                    TimeSpan diferencia = fechaActual - ivaDetalle.F_Inicio;
                    var diferenciaMinutos = diferencia.TotalMinutes;

                    if (diferenciaMinutos < 5)
                        ivaDetalle.Estado = "Valido";
                }
                else
                    ivaDetalle.Estado = "Invalido";

                listaIvas.Add(ivaDetalle);
            }
            return listaIvas;
        }

        public async Task<int> GuardarEditarIva(Iva ivas)
        {
            try
            {
                int guadarEditar = 1;
                if (ivas.idIva == 0)
                    guadarEditar = 0;

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

                return guadarEditar;
            }
            catch (Exception)
            {

                throw new Exception();
            }
        }

    }
}
