using _2015137370_ENT;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015137370_PER.ENT.configuration
{
    public class VentaConfiguration : EntityTypeConfiguration<Venta>
    {


        
        public VentaConfiguration()
        {
            ToTable("Venta");
            HasKey(cl => cl.VentaID);

            /*
            HasMany(cl => cl.Administrativos)
               .WithRequired(r => r.Venta)
               .HasForeignKey(r => r.VentaID);


            HasMany(cl => cl.TipoComprobantes)
              .WithRequired(r => r.Venta)
              .HasForeignKey(r => r.VentaID);

            HasMany(cl => cl.TipoPagos)
              .WithRequired(r => r.Venta)
              .HasForeignKey(r => r.VentaID);

            HasMany(cl => cl.Servicios)
              .WithRequired(r => r.Venta)
              .HasForeignKey(r => r.VentaID);

            HasMany(cl => cl.Clientes)
              .WithRequired(r => r.Venta)
              .HasForeignKey(r => r.VentaID);



            */


        } 


    }
}
