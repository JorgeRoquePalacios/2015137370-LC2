using _2015137370_ENT;
using _2015137370_ENT.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015137370_PER.Repositories
{
    class UnityOfWork : IUnityOfWork
    {/*
        private readonly DBContext _Context;
        private static UnityOfWork _Instance;
        private static readonly object _Lock = new object();*/

        
        

        IAdministrativoRepository IUnityOfWork.Administrativo
        {
            get { throw new NotImplementedException(); }
        }

        IBusRepository IUnityOfWork.IBus
        {
            get { throw new NotImplementedException(); }
        }

        IClienteRepository IUnityOfWork.ICliente
        {
            get { throw new NotImplementedException(); }
        }

        IEmpleadoRepository IUnityOfWork.IEmpleado
        {
            get { throw new NotImplementedException(); }
        }

        ILugarViajeRepository IUnityOfWork.Ilugarviaje
        {
            get { throw new NotImplementedException(); }
        }

        IEncomiendaRepository IUnityOfWork.IEncomienda
        {
            get { throw new NotImplementedException(); }
        }

        IServiceProvider IUnityOfWork.IServicio
        {
            get { throw new NotImplementedException(); }
        }

        ITipoComprobanteRepository IUnityOfWork.ItipoComprobante
        {
            get { throw new NotImplementedException(); }
        }

        ITipoLugarRepository IUnityOfWork.ItIpoLugar
        {
            get { throw new NotImplementedException(); }
        }

        ITipoPagoRepository IUnityOfWork.ItIpoPago
        {
            get { throw new NotImplementedException(); }
        }

        ITipoTripulacionRepository IUnityOfWork.ItipoTripulacion
        {
            get { throw new NotImplementedException(); }
        }

        ITipoViajeRepository IUnityOfWork.ItipoViaje
        {
            get { throw new NotImplementedException(); }
        }

        ITransporteRepository IUnityOfWork.Itransporte
        {
            get { throw new NotImplementedException(); }
        }

        ITripulacionRepository IUnityOfWork.Itripulacion
        {
            get { throw new NotImplementedException(); }
        }

        IVentaRepository IUnityOfWork.Iventa
        {
            get { throw new NotImplementedException(); }
        } 


        
        private UnityOfWork()
        {
            _Context = new DBContext();

            Administrativos= new AdministrativoRepository(_Context);
            Buses = new BusRepository(_Context);
            Clientes = new ClienteRepository(_Context);
            Empleados = new EmpleadoRepository(_Context);
            Encomiendas = new EncomiendaRepository(_Context);
            LugarViajes = new LugarViajeRepository(_Context);
            Servicios = new ServicioRepository(_Context);
            TipoComprobantes = new TipoComprobanteRepository(_Context);
            TipoLugares = new TipoLugarRepository(_Context);
            TipoPagos = new TipoPagoRepository(_Context);
            TipoTripulaciones = new TipoTripulacionRepository(_Context);
            TipoViajes = new TipoViajeRepository(_Context);
            Transportes = new TransporteRepository(_Context);
            Tripulaciones = new TripulacionRepository(_Context);
            Ventas = new VentaRepository(_Context);


        }


        public IAdministrativoRepository Administrativos { get; private set; }
        public IBusRepository Buses { get; private set; }
        public IClienteRepository Clientes { get; private set; }
        public IEmpleadoRepository Empleados { get; private set; }
        public IEncomiendaRepository Encomiendas { get; private set; }
        public ILugarViajeRepository LugarViajes { get; private set; }
        public IServicioRepository Servicios { get; private set; }
        public ITipoComprobanteRepository TipoComprobantes { get; private set; }
        public ITipoLugarRepository TipoLugares { get; private set; }
        public ITipoPagoRepository TipoPagos { get; private set; }
        public ITipoTripulacionRepository TipoTripulaciones { get; private set; }
        public ITipoViajeRepository TipoViajes { get; private set; }
        public ITransporteRepository Transportes { get; private set; }
        public ITripulacionRepository Tripulaciones { get; private set; }
        public IVentaRepository Ventas { get; private set; }

        
        /*
        public static UnityOfWork Instance
        {
            get
            {
                lock (_Lock)
                {
                if(_Instance == null)
                    _Instance = new UnityOfWork();
                return _Instance;
            }
        }
        }*/





        int IUnityOfWork.SaveChange()
        {
            throw new NotImplementedException();
        }

        void IDisposable.Dispose()
        {
            throw new NotImplementedException();
        }



        public DBContext _Context { get; set; }
    
public static object _Instance { get; set; }}
}
