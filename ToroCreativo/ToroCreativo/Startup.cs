using EmailService;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToroCreativo.Clases;
using ToroCreativo.Models.Abstract;
using ToroCreativo.Models.Business;
using ToroCreativo.Models.DAL;
using ToroCreativo.Models.Entities;

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
            services.AddSession(options => { options.IdleTimeout = TimeSpan.FromMinutes(5); });
            services.AddControllersWithViews();

            var conexion = Configuration["ConnectionStrings:conexion_mySql"];
            services.AddDbContext<DbContextToroCreativo>(options => options.UseMySql(conexion));
            var emailConfig = Configuration
                .GetSection("EmailConfiguration")
                .Get<EmailConfiguration>();
            services.AddSingleton(emailConfig);
            services.AddAutoMapper(typeof(Startup));
            services.AddScoped<IEmailSender, EmailSender>();
            services.AddScoped<IUsuarioBusiness, UsuarioBusiness>();
            services.AddScoped<ICategoriasBusiness, CategoriasBusiness>();
            services.AddScoped<IProductosBusiness, ProductosBusiness>();
            services.AddScoped<IGenerosBusiness, GenerosBusiness>();
            services.AddScoped<IIlustracionBusiness, IlustracionBusiness>();
            services.AddScoped<IClientesBusiness, ClienteBusiness>();
            services.AddScoped<ICaracteristicaBusiness, CaracteristicaBusiness>();
            services.AddScoped<IPrecioBusiness, PrecioBusiness>();
            services.AddScoped<ITama??oBusiness, Tama??oBusiness>();
            services.AddScoped<IIvasBusiness, IvasBusiness>();
            services.AddScoped<IEntradaBusiness, EntradaBusiness>();
            services.AddScoped<IPedidoBusiness, PedidoBusiness>();
            services.AddScoped<IDetallePedidoBusiness, DetallePedidoBusiness>();
            services.AddScoped<IImagenIlustracionBusiness, ImagenIlustracionBusiness>();
            services.AddScoped<IImagenProductoBusiness, ImagenProductoBusiness>();
            services.AddScoped<INotificacionesBusiness, NotificacionesBusiness>();
            services.AddScoped<IComentarioBusiness, ComentarioBusiness>();
            services.AddScoped<ICalificacionBusiness, CalificacionBusiness>();
            services.AddRazorPages().AddRazorRuntimeCompilation();

            services.AddIdentity<Usuario, IdentityRole>().AddEntityFrameworkStores<DbContextToroCreativo>().AddDefaultTokenProviders().AddTokenProvider<EmailConfirmationTokenProvider<Usuario>>("confirmacionemail"); ; 
            
            services.Configure<DataProtectionTokenProviderOptions>(opt =>
                opt.TokenLifespan = TimeSpan.FromHours(2));
            services.Configure<EmailConfirmationTokenProviderOptions>(opt =>
                opt.TokenLifespan = TimeSpan.FromDays(3));
            services.Configure<IdentityOptions>(options =>
            {
                options.Password.RequireDigit = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireUppercase = false;
                options.Password.RequiredLength = 4;
                options.User.RequireUniqueEmail = true;
                options.SignIn.RequireConfirmedEmail = true;
                options.Tokens.EmailConfirmationTokenProvider = "confirmacionemail";
            });

            services.ConfigureApplicationCookie(options =>
            {
                options.AccessDeniedPath = new PathString("/Usuarios/Login");
                options.LoginPath = new PathString("/Usuarios/Login");
                options.Cookie.Name = "Cookie";
                options.Cookie.HttpOnly = true;
                options.ExpireTimeSpan = TimeSpan.FromMinutes(60);
                options.ReturnUrlParameter = CookieAuthenticationDefaults.ReturnUrlParameter;
                options.SlidingExpiration = true;


            });
            

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
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseSession();
            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();
            
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });

            Rotativa.AspNetCore.RotativaConfiguration.Setup(env.WebRootPath, "../Rotativa");
        }
    }
}
