using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015137370_ENT
{
    public class Cliente
    {
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public int ClienteID { get; set; }
        public string DNI { get; set; }
        public int VentaID { get; set; }
        public Venta Venta { get; set; }
        public int TransporteID { get; set; }
        public Transporte Transporte { get; set; }
    }
}
