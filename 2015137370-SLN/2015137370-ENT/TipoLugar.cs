using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015137370_ENT
{
    public class TipoLugar
    {

        public int TipoLugarID { get; set; }
        public double CostoAdicional { get; set; }
        public int LugarViajeID { get; set; }
        public LugarViaje LugarViaje { get; set; }

    }
}
