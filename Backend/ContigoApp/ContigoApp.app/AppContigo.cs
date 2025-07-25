using AutoMapper;
using cendiatra.modulo.modelo.ModeloFacturacion;
using cendiatra.modulo.modelo.ModelosAtencion;
using cendiatra.modulo.modelo.ModelosAuditoria;
using cendiatra.modulo.utilidades.App;
using cendiatra.modulo.utilidades.Comunicacion;
using cendiatra.modulo.utilidades.DatosUsuario;
using ContigoApp.bd;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContigoApp.app
{
    public class AppContigo : AppBase<IUnidadDeTrabajo>, IAppContigo
    {
        private readonly ILogger<AppContigo> _logger;

        public AppContigo(IUnidadDeTrabajo udt, IComunicador comunicador, ILogger<AppContigo> log) : base(udt, comunicador)
        {
            var mapperConfiguracion = new MapperConfiguration(m =>
            {
                //m.CreateMap<CrearAtencion, Atencion>()
                //.ForMember(dest => dest.Acompanante, opt => opt.MapFrom(src => src.Acompanante))
                //.ForMember(dest => dest.ArlId, opt => opt.MapFrom(src => src.ArlId))
                //.ForMember(dest => dest.Cargo, opt => opt.MapFrom(src => src.Cargo))
                //.ForMember(dest => dest.ParentescoId, opt => opt.MapFrom(src => src.ParentescoId))
                //.ForMember(dest => dest.Creado, opt => opt.MapFrom(src => UtilidadFecha.ObtenerFechaHoraColombiana()))
                //.ForMember(dest => dest.Discapacidad, opt => opt.MapFrom(src => src.Discapacidad))
                //.ForMember(dest => dest.EpsId, opt => opt.MapFrom(src => src.EpsId))
                //.ForMember(dest => dest.FacturacionAtenciones, opt => opt.MapFrom(src => new CrearFacturacion[] { src.Facturacion }))
                //.ForMember(dest => dest.FirmaUrl, opt => opt.MapFrom(src => src.FirmaURL))
                //.ForMember(dest => dest.FondoPensionesId, opt => opt.MapFrom(src => src.FondoPensionesId))
                //.ForMember(dest => dest.FotoUrl, opt => opt.MapFrom(src => src.FotoURL))
                //.ForMember(dest => dest.HuellaUrl, opt => opt.MapFrom(src => src.HuellaURL))
                //.ForMember(dest => dest.OrdenId, opt => opt.MapFrom(src => src.OrdenId))
                //.ForMember(dest => dest.TarifarioId, opt => opt.MapFrom(src => src.TarifarioId))
                //.ForMember(dest => dest.EstadoAtencionId, opt => opt.MapFrom(src => Environment.GetEnvironmentVariable("estadoAtencionActiva")))
                //.ForMember(dest => dest.ServiciosAtenciones, opt => opt.MapFrom(src => src.Servicios.Select(s => new ServiciosAtencion
                //{
                //    EstadoServicioAtencionId = int.Parse(Environment.GetEnvironmentVariable("estadoServicioPendientePorAtender")),
                //    Creado = UtilidadFecha.ObtenerFechaHoraColombiana(),
                //    ServicioId = s
                //})))
                //.ForMember(dest => dest.TelAcompanante, opt => opt.MapFrom(src => src.TelefonoAcompanante))
                //.ForMember(dest => dest.TipoExamenId, opt => opt.MapFrom(src => src.TipoExamenId))
                //.ForMember(dest => dest.AcompananteAtencion, opt => opt.MapFrom((src, dest, destMember, context) =>
                //{
                //    var acompanante = context.Mapper.Map<AcompananteAtencion>(src.InformacionAcompanante);
                //    if (acompanante != null) acompanante.Creado = UtilidadFecha.ObtenerFechaHoraColombiana();

                //    return acompanante;
                //}))
                //.ReverseMap();
            });
            _mapper = mapperConfiguracion.CreateMapper();
            _logger = log;
        }

        public async Task<int> CrearDignostico()
        {
            return 0;
        }
    }
}
