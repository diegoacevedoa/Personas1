using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using Personas1.Data.Context;
using Personas1.Data.Mapping;
using Personas1.Service.Implementacion;
using Personas1.Service.Interface;

namespace Personas1.WebApi
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
            //Inyección de dependencias de los servicios creados para el proyecto
            services.AddTransient<IPersona1Service, Persona1Service>();
            services.AddTransient<IEnumsService, EnumsService>();
            services.AddAutoMapper(typeof(Mapeos));
            services.AddCors(options =>
            {
                options.AddPolicy("Personas1.CORS", builder => builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
            });
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Personas1.WebApi", Version = "v1" });
            });

            services.AddDbContext<Personas1Context>(options => options.UseSqlServer(Configuration.GetConnectionString("ConexionDB")));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Personas1.WebApi v1"));
            }

            app.UseCors("Personas1.CORS");

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
