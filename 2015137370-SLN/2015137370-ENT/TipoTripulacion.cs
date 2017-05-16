using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015137370_ENT
{
    public class TipoTripulacion
    {

        public int TipoTripulacionID { get; set; }
        public string Descripción { get; set; }
        public int TripulacionID { get; set; }
        public Tripulacion Tripulacion { get; set; }

    }
}
