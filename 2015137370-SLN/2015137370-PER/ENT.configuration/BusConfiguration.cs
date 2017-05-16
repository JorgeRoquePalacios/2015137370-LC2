using _2015137370_ENT;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015137370_PER.ENT.configuration
{
    public class BusConfiguration : EntityTypeConfiguration<Bus>
    {
        
        public BusConfiguration()
        {
            ToTable("Bus");
            HasKey(cl => cl.BusID);

           /* HasMany(cl => cl.Encomiendas)
                   .WithRequired(r => r.Bust)
                   .HasForeignKey(r => r.BusID);


            HasRequired(r => r.Tripulaciones1)
            .WithRequiredPrincipal(r => r.Bus1); */

        }

    }
}
