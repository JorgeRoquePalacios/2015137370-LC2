using _2015137370_ENT;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015137370_PER.ENT.configuration
{
    public class TransporteConfiguration : EntityTypeConfiguration<Transporte>
    {

        
        public TransporteConfiguration()
        {
            ToTable("Transporte");
            HasKey(cl => cl.TransporteID);

            /*
            HasMany(cl => cl.Clientess)
               .WithRequired(r => r.Transporte)
               .HasForeignKey(r => r.TransporteID);

            HasMany(cl => cl.TipoViajes)
               .WithRequired(r => r.Transporte)
               .HasForeignKey(r => r.TransporteID);

            HasMany(cl => cl.LugarViajes)
              .WithRequired(r => r.Transporte)
              .HasForeignKey(r => r.TransporteID);

            HasRequired(r => r.Bus2)
            .WithRequiredPrincipal(r => r.Transporte1);

            */
        } 

    }
}
