using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToroCreativo.Models.Abstract;
using ToroCreativo.Models.Business;
using ToroCreativo.Models.DAL;

namespace ToroCreativo
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();

            var conexion = Configuration["ConnectionStrings:conexion_mySql"];
            services.AddDbContext<DbContextToroCreativo>(options => options.UseMySql(conexion));
            services.AddScoped<IUsuarioBusiness, UsuarioBusiness>();
            services.AddScoped<ICategoriasBusiness, CategoriasBusiness>();
            services.AddScoped<IProductosBusiness, ProductosBusiness>();
            services.AddScoped<IGenerosBusiness, GenerosBusiness>();
            services.AddScoped<IIlustracionBusiness, IlustracionBusiness>();
            services.AddScoped<IClientesBusiness, ClienteBusiness>();
            services.AddScoped<ICaracteristicaBusiness, CaracteristicaBusiness>();
            services.AddScoped<IPrecioBusiness, PrecioBusiness>();
            services.AddScoped<ITamañoBusiness, TamañoBusiness>();
            services.AddScoped<IIvasBusiness, IvasBusiness>();
            services.AddScoped<IEntradaBusiness, EntradaBusiness>();
            services.AddScoped<IPedidoBusiness, PedidoBusiness>();
            services.AddScoped<IDetallePedidoBusiness, DetallePedidoBusiness>();
            services.AddScoped<IImagenIlustracionBusiness, ImagenIlustracionBusiness>();
            services.AddScoped<IImagenProductoBusiness, ImagenProductoBusiness>();


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Inicio_Admin}/{action=Index}/{id?}");
            });
        }
    }
}
