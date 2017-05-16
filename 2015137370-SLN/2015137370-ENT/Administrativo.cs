using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015137370_ENT
{
    public class Administrativo : Empleado
    {
        public int AdministrativoID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Descripción { get; set; }
        public int VentaID { get; set; }
        public Venta Venta { get; set; }
    }
}
