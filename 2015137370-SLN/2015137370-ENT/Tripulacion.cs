using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015137370_ENT
{
    public class Tripulacion : Empleado
    {


        public int TripulacionID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public Bus Bus1 { get; set; }

        public TipoTripulacion TipoTripulacion { get; set; }

        public Tripulacion()
        {
            TipoTripulacion = new TipoTripulacion();
            TipoTripulaciones = new List<TipoTripulacion>();
        }

        public List<TipoTripulacion> TipoTripulaciones { get; set; }

    }
}
