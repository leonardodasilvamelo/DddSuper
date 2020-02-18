using AutoMapper;
using DddSuper.Aplication.Interfaces;
using DddSuper.Aplication.Mapping;
using DddSuper.Aplication.Services;
using DddSuper.Domain.Interfaces.Repositories;
using DddSuper.Domain.Interfaces.Services;
using DddSuper.Domain.Services;
using DddSuper.Infra.Data.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using System.IO;

namespace DddSuper.Controller
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
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new ContaCorrenteProfile());
                mc.AddProfile(new LancamentoAppProfile());
            });

            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new OpenApiInfo { Title = "DDDSuper", Version = "V1" , Contact = new OpenApiContact {Name ="Leonardo Melo", Email= "leonardomelo.ti@gmail.com" } });
            });



            //Aplication
            services.AddScoped<ILancamentosApp, LancamentosApp>();

            //Service
            services.AddScoped<IContaCorrenteService, ContaCorrenteService>();
            services.AddScoped<ILancamentosService, LancamentosService>();

            //Repository
            services.AddScoped<IContaCorrenteRepository, ContaCorrenteRepository>();
            services.AddScoped<ILancamentosRepository, LancamentosRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.RoutePrefix = "swagger";
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Demo JWT Api");
            });

            app.UseHttpsRedirection();
            app.UseMvc();

        
        }
    }
}
