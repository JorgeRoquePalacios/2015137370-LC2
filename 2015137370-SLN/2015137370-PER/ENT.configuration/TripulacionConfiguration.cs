using _2015137370_ENT;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015137370_PER.ENT.configuration
{
    public class TripulacionConfiguration : EntityTypeConfiguration<Tripulacion>
    {

        
        public TripulacionConfiguration()
        {
            ToTable("Tripulacion");
            HasKey(cl => cl.TripulacionID);
            /*
            HasMany(cl => cl.TipoTripulaciones)
               .WithRequired(r => r.Tripulacion)
               .HasForeignKey(r => r.TripulacionID);
            */
        } 

    }
}
