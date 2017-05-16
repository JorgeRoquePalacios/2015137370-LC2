using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015137370_ENT
{
    public class Encomienda : Servicio
    {

        public LugarViaje LugarViaje { get; set; }
        public Bus Bus { get; set; }


        private Encomienda()
        {
            LugarViaje = new LugarViaje();
            LugarViajess = new List<LugarViaje>();

        }

        public Encomienda(Bus bus)
        {
            LugarViaje = new LugarViaje();
            Bus = bus;
        }


        public int EncomiendaID { get; set; }
        public int LugarViajeID { get; set; }
        public string Beneficiario { get; set; }
        public string Tarea { get; set; }
        public int BusID { get; set; }
        public Bus Bust { get; set; }

        public List<LugarViaje> LugarViajess { get; set; }

    }
}
