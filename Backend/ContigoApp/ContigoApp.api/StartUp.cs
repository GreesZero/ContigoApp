using ContigoApp.app;
using ContigoApp.bd;
using cendiatra.modulo.utilidades.Comunicacion;
using cendiatra.modulo.utilidades.DatosUsuario;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;

[assembly: FunctionsStartup(typeof(cendiatra.atencion.api.StartUp))]

namespace cendiatra.atencion.api
{
    public class StartUp : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            builder.Services.AddTransient((s) =>
            {
                string conexion = Environment.GetEnvironmentVariable("sqldb_connection");
                var options = new DbContextOptionsBuilder<Contexto>();
                options.UseSqlServer(conexion);
                var contexto = new Contexto(options.Options);
                contexto.Database.EnsureCreated();
                return contexto;
            });
            builder.Services.AddTransient<IUnidadDeTrabajo, UnidadDeTrabajo>();
            builder.Services.AddTransient<IAppContigo, AppContigo>();
            builder.Services.AddScoped<IComunicador, Comunicador>();

            DatosUsuarioExtension.InyectarDatosUsuario(builder);

            JsonConvert.DefaultSettings = () => new JsonSerializerSettings
            {
                Formatting = Formatting.Indented,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                ContractResolver = new CamelCasePropertyNamesContractResolver()
            };
        }
    }
}
