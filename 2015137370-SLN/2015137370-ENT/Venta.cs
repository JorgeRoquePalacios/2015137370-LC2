using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015137370_ENT
{
    public class Venta
    {


        public int VentaID { get; set; }
        public int ClienteID { get; set; }
        public int AdministrativoID { get; set; }
        public int TipoComprobanteID { get; set; }
        public int TipoPagoID { get; set; }
        public int ServicioID { get; set; }
        public double costo { get; set; }
        public string Observacion { get; set; }
        public Administrativo Administrativo { get; set; }
        public Cliente Cliente { get; set; }
        public TipoComprobante TipoComprobante { get; set; }
        public TipoPago TipoPago { get; set; }
        public Servicio Servicio { get; set; }

        public Venta()
        {
            Administrativo = new Administrativo();
            Cliente = new Cliente();
            TipoComprobante = new TipoComprobante();
            TipoPago = new TipoPago();
            Servicio = new Servicio();
            TipoComprobantes = new List<TipoComprobante>();
            Administrativos = new List<Administrativo>();
            TipoPagos = new List<TipoPago>();
            Servicios = new List<Servicio>();
            Clientes = new List<Cliente>();
        }


        public List<Administrativo> Administrativos { get; set; }
        public List<TipoComprobante> TipoComprobantes { get; set; }
        public List<TipoPago> TipoPagos { get; set; }
        public List<Servicio> Servicios { get; set; }
        public List<Cliente> Clientes { get; set; }


    }
}
