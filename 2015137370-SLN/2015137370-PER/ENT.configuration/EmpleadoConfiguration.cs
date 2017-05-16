using _2015137370_ENT;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015137370_PER.ENT.configuration
{
    public class EmpleadoConfiguration : EntityTypeConfiguration<Empleado>
    {

        
        public EmpleadoConfiguration()
        {
            ToTable("Empleado");
            HasKey(cl => cl.EmpleadoID);

            /*


            Property(cl => cl.DNI).IsRequired();
            Property(cl => cl.LaborSocial).IsRequired();

            Map<Tripulacion>(m => m.Requires("Discriminator").HasValue("Tripulacion"));
            Map<Administrativo>(m => m.Requires("Discriminator").HasValue("Administrativo"));*/
        } 

    }
}
