using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015137370_ENT.IRepositories
{
    public interface IUnityOfWork : IDisposable
    {


        IAdministrativoRepository Administrativo { get; }
        IBusRepository IBus { get; }
        IClienteRepository ICliente { get; }
        IEmpleadoRepository IEmpleado { get; }
        ILugarViajeRepository Ilugarviaje { get; }
        IEncomiendaRepository IEncomienda { get; }
        IServiceProvider IServicio { get; }
        ITipoComprobanteRepository ItipoComprobante { get; }
        ITipoLugarRepository ItIpoLugar { get; }
        ITipoPagoRepository ItIpoPago { get; }
        ITipoTripulacionRepository ItipoTripulacion { get; }
        ITipoViajeRepository ItipoViaje { get; }
        ITransporteRepository Itransporte { get; }
        ITripulacionRepository Itripulacion { get; }
        IVentaRepository Iventa { get; }


        int SaveChange();



    }
}
