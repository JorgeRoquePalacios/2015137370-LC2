using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015137370_ENT
{
    public class Servicio
    {

        public string Tipo { get; set; }
        public int ServicioID { get; set; }
        public string DescripcionServicio { get; set; }
        public int cantidad { get; set; }
        public int VentaID { get; set; }
        public Venta Venta { get; set; }

    }
}
