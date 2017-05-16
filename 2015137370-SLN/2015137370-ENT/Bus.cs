using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015137370_ENT
{
    public class Bus
    {
        public Tripulacion Tripulacion { get; set; }

        public Bus()
        {
            Encomiendas = new List<Encomienda>();

        }

        public Bus(Tripulacion tripulacion)
        {
            Tripulacion = tripulacion;
            Tripulaciones1 = new Tripulacion();
        }

        public string Placa { get; set; }
        public int cantidad { get; set; }
        public string color { get; set; }
        public int BusID { get; set; }
        public Transporte Transporte1 { get; set; }
        public List<Encomienda> Encomiendas { get; set; }
        public Tripulacion Tripulaciones1 { get; set; }

    }
}
