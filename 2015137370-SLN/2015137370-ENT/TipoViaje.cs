using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015137370_ENT
{
    public class TipoViaje
    {

        public int TipoViajeID { get; set; }
        public string Descripcion { get; set; }
        public string Beneficio { get; set; }
        public int TransporteID { get; set; }
        public Transporte Transporte { get; set; }

    }
}
