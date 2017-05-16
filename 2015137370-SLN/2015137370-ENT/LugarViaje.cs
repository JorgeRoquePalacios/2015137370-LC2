using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015137370_ENT
{
    public class LugarViaje
    {

        public int LugarViajeID { get; set; }
        public int TipoLugarID { get; set; }
        public TipoLugar TipoLugar { get; set; }
        public string Descripcion { get; set; }
        public string TiempoEstimado { get; set; }
        public int TransporteID { get; set; }
        public Transporte Transporte { get; set; }
        public int EncomiendaID { get; set; }
        public Encomienda Encomienda { get; set; }


        public LugarViaje()
        {
            TipoLugar = new TipoLugar();
            TipoLugares = new List<TipoLugar>();

        }

        public List<TipoLugar> TipoLugares { get; set; }

    }
}
