using _2015137370_ENT;
using _2015137370_PER.ENT.configuration;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015137370_PER
{
    public class DBContext : DbContext
    {

        public DbSet<Transporte> Transporte { get; set; }
        public DbSet<Administrativo> Administrativo { get; set; }
        public DbSet<Bus> Bus { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Empleado> Empleado { get; set; }
        public DbSet<Encomienda> Encomienda { get; set; }
        public DbSet<LugarViaje> LugarViaje { get; set; }
        public DbSet<Servicio> Servicio { get; set; }
        public DbSet<TipoComprobante> TipoComprobante { get; set; }
        public DbSet<TipoLugar> TipoLugar { get; set; }
        public DbSet<TipoTripulacion> TipoTripulacion { get; set; }
        public DbSet<TipoViaje> TipoViaje { get; set; }
        public DbSet<Tripulacion> Tripulacion { get; set; }
        public DbSet<Venta> Venta { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new TransporteConfiguration());
            modelBuilder.Configurations.Add(new AdministrativoConfiguration());
            modelBuilder.Configurations.Add(new BusConfiguration());
            modelBuilder.Configurations.Add(new ClienteConfiguration());
            modelBuilder.Configurations.Add(new EmpleadoConfiguration());
            modelBuilder.Configurations.Add(new EncomiendaConfiguration());
            modelBuilder.Configurations.Add(new LugarViajeConfiguration());
            modelBuilder.Configurations.Add(new ServicioConfiguration());
            modelBuilder.Configurations.Add(new TipoComprobanteConfiguration());
            modelBuilder.Configurations.Add(new TipoLugarConfiguration());
            modelBuilder.Configurations.Add(new TipoPagoConfiguration());
            modelBuilder.Configurations.Add(new TipoTripulacionConfiguration());
            modelBuilder.Configurations.Add(new TipoViajeConfiguration());
            modelBuilder.Configurations.Add(new TripulacionConfiguration());
            modelBuilder.Configurations.Add(new VentaConfiguration());

            base.OnModelCreating(modelBuilder);

        }



    }
}
