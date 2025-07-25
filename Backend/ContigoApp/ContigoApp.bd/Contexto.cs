using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContigoApp.bd
{
    public class Contexto : DbContext
    {
        public Contexto()
        {

        }
        public Contexto(DbContextOptions<Contexto> opciones) : base(opciones)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //_ = new MapAtencion(modelBuilder.Entity<Atencion>());
            //_ = new MapComprobanteAtencion(modelBuilder.Entity<ComprobanteAtencion>());
            //_ = new MapFacturacionServicio(modelBuilder.Entity<FacturacionServicio>());
            //_ = new MapDetalleAtencionAliado(modelBuilder.Entity<DetalleAtencionAliado>());
            //_ = new MapAcompananteAtencion(modelBuilder.Entity<AcompananteAtencion>());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                _ = optionsBuilder.UseSqlServer(
                @"Data Source=tcp:desarrollo-handtag.database.windows.net;User ID=desarrollo-handtag;Password=ILikeThis123*;Initial Catalog=cendiatra.atencion;Persist Security Info=True;");
            }
        }
    }
}
