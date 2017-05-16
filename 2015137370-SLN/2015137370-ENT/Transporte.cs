using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015137370_ENT
{
    public class Transporte : Servicio
    {


        public Bus Bus { get; set; }
        public Cliente Cliente { get; set; }
        public TipoViaje TipoViaje { get; set; }
        public LugarViaje LugarViaje { get; set; }
        public int TransporteID { get; set; }
        public int LugarViajeID { get; set; }
        public int TipoViajeID { get; set; }
        public int ClienteID { get; set; }




        private Transporte()
        {
            Cliente = new Cliente();
            TipoViaje = new TipoViaje();
            LugarViaje = new LugarViaje();
            Clientess = new List<Cliente>();
            TipoViajes = new List<TipoViaje>();
            LugarViajes = new List<LugarViaje>();

        }



        public Transporte(Bus bus)
        {
            Bus = bus;
            Cliente = new Cliente();
            TipoViaje = new TipoViaje();
            LugarViaje = new LugarViaje();
            Bus2 = new Bus();

        }

        public List<Cliente> Clientess { get; set; }
        public List<TipoViaje> TipoViajes { get; set; }
        public List<LugarViaje> LugarViajes { get; set; }
        public Bus Bus2 { get; set; }


    }
}
