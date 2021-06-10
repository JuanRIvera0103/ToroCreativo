using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToroCreativo.Models.Entities;

namespace ToroCreativo.Models.DAL
{
    public class DbContextToroCreativo:IdentityDbContext
    {
        public DbContextToroCreativo(DbContextOptions<DbContextToroCreativo> options):base(options)
        {

        }
        public DbSet<Categorias> categorias { get; set; }
        public DbSet<Productos> productos { get; set; }
        public DbSet<Generos> generos { get; set; }
        public DbSet<Ilustracion> Ilustracions { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }       
        public DbSet<Cliente> Clientes { get; set; }        
        public DbSet<Caracteristica> caracteristicas { get; set; }
        public DbSet<Precio> precios { get; set; }
        public DbSet<Tamaño> tamaños { get; set; }
        public DbSet<Iva> ivas { get; set; }
        public DbSet<Entrada> entradas { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<DetallePedido> DetallePedidos { get; set; }
        public DbSet<ImagenIlustracion> ImagenIlustraciones { get; set; }
        public DbSet<ImagenProducto> ImagenProductos { get; set; }
        public DbSet<Notificacion> Notificaciones { get; set; }
        public DbSet<Comentario> Comentarios { get; set; }
        public DbSet<CalificacionProducto> CalificacionProductos { get; set; }
    }
}
