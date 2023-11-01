using GestaodeVoluntarios.UI.Areas.Identity.Data;
using GestaodeVoluntarios.UI.Extensions;
using GestaodeVoluntarios.UI.Infra.Contexto;
using GestaodeVoluntarios.UI.Infra.Interfaces;
using GestaodeVoluntarios.UI.Infra.Repositorio;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace GestaodeVoluntarios.UI
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
            services.AddDbContext<ContextoVoluntarios>(o => o.UseSqlServer(this.Configuration.GetConnectionString("DefaultConnection")));

            services.AddTransient<IMasculinoCadastroRepositorio, MasculinoCadastroRepositorio>();
            services.AddTransient<IFemininoCadastroRepositorio, FemininoCadastroRepositorio>();
            services.AddTransient<IEstudoRepositorio, EstudoRepositorio>();
            services.AddTransient<IVoluntarioEstudoRepositorio, VoluntariosEstudoRepositorio>();


            services.AddControllersWithViews();

            services.AddDbContext<AspNetCoreIdentityContext>(options =>
                   options.UseSqlServer(this.Configuration.GetConnectionString("DefaultConnection")));

            

            services.AddDefaultIdentity<IdentityUser>()
                .AddDefaultUI()
                .AddRoles<IdentityRole>()
                .AddEntityFrameworkStores<AspNetCoreIdentityContext>();

            services.AddAuthorization(options =>
            {
                options.AddPolicy("PodeExcluir", policy => policy.RequireClaim("PodeExcluir"));
                options.AddPolicy("PodeLer", policy => policy.Requirements.Add(new PermissaoNecessaria("Podeler")));
                options.AddPolicy("PodeEscrever", policy => policy.Requirements.Add(new PermissaoNecessaria("PodeEscrever")));
            });

            services.AddSingleton<IAuthorizationHandler, PermissaoNecessariaHandler>();
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
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();


            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");

                //tem q add essa linha para uso das paginas do identity
                endpoints.MapRazorPages();
            });
        }
    }
}
