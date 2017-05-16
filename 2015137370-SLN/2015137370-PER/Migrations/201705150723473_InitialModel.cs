namespace _2015137370_PER.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Empleadoes",
                c => new
                    {
                        EmpleadoID = c.Int(nullable: false, identity: true),
                        DNI = c.String(),
                        LaborSocial = c.String(),
                        AdministrativoID = c.Int(),
                        Nombre = c.String(),
                        Apellido = c.String(),
                        Descripción = c.String(),
                        VentaID = c.Int(),
                        TripulacionID = c.Int(),
                        Nombre1 = c.String(),
                        Apellido1 = c.String(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                        Venta_VentaID = c.Int(),
                        Bus1_BusID = c.Int(),
                        TipoTripulacion_TipoTripulacionID = c.Int(),
                        Venta_VentaID1 = c.Int(),
                    })
                .PrimaryKey(t => t.EmpleadoID)
                .ForeignKey("dbo.Ventas", t => t.Venta_VentaID)
                .ForeignKey("dbo.Buses", t => t.Bus1_BusID)
                .ForeignKey("dbo.TipoTripulacions", t => t.TipoTripulacion_TipoTripulacionID)
                .ForeignKey("dbo.Ventas", t => t.Venta_VentaID1)
                .Index(t => t.Venta_VentaID)
                .Index(t => t.Bus1_BusID)
                .Index(t => t.TipoTripulacion_TipoTripulacionID)
                .Index(t => t.Venta_VentaID1);
            
            CreateTable(
                "dbo.Ventas",
                c => new
                    {
                        VentaID = c.Int(nullable: false, identity: true),
                        ClienteID = c.Int(nullable: false),
                        AdministrativoID = c.Int(nullable: false),
                        TipoComprobanteID = c.Int(nullable: false),
                        TipoPagoID = c.Int(nullable: false),
                        ServicioID = c.Int(nullable: false),
                        costo = c.Double(nullable: false),
                        Observacion = c.String(),
                        Administrativo_EmpleadoID = c.Int(),
                        Cliente_ClienteID = c.Int(),
                        Servicio_ServicioID = c.Int(),
                        TipoComprobante_TipoComprobanteID = c.Int(),
                        TipoPago_TipoPagoID = c.Int(),
                    })
                .PrimaryKey(t => t.VentaID)
                .ForeignKey("dbo.Empleadoes", t => t.Administrativo_EmpleadoID)
                .ForeignKey("dbo.Clientes", t => t.Cliente_ClienteID)
                .ForeignKey("dbo.Servicios", t => t.Servicio_ServicioID)
                .ForeignKey("dbo.TipoComprobantes", t => t.TipoComprobante_TipoComprobanteID)
                .ForeignKey("dbo.TipoPagoes", t => t.TipoPago_TipoPagoID)
                .Index(t => t.Administrativo_EmpleadoID)
                .Index(t => t.Cliente_ClienteID)
                .Index(t => t.Servicio_ServicioID)
                .Index(t => t.TipoComprobante_TipoComprobanteID)
                .Index(t => t.TipoPago_TipoPagoID);
            
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        ClienteID = c.Int(nullable: false, identity: true),
                        Nombres = c.String(),
                        Apellidos = c.String(),
                        DNI = c.String(),
                        VentaID = c.Int(nullable: false),
                        TransporteID = c.Int(nullable: false),
                        Transporte_ServicioID = c.Int(),
                        Transporte_ServicioID1 = c.Int(),
                        Venta_VentaID = c.Int(),
                        Venta_VentaID1 = c.Int(),
                    })
                .PrimaryKey(t => t.ClienteID)
                .ForeignKey("dbo.Servicios", t => t.Transporte_ServicioID)
                .ForeignKey("dbo.Servicios", t => t.Transporte_ServicioID1)
                .ForeignKey("dbo.Ventas", t => t.Venta_VentaID)
                .ForeignKey("dbo.Ventas", t => t.Venta_VentaID1)
                .Index(t => t.Transporte_ServicioID)
                .Index(t => t.Transporte_ServicioID1)
                .Index(t => t.Venta_VentaID)
                .Index(t => t.Venta_VentaID1);
            
            CreateTable(
                "dbo.Servicios",
                c => new
                    {
                        ServicioID = c.Int(nullable: false, identity: true),
                        Tipo = c.String(),
                        DescripcionServicio = c.String(),
                        cantidad = c.Int(nullable: false),
                        VentaID = c.Int(nullable: false),
                        TransporteID = c.Int(),
                        LugarViajeID = c.Int(),
                        TipoViajeID = c.Int(),
                        ClienteID = c.Int(),
                        EncomiendaID = c.Int(),
                        LugarViajeID1 = c.Int(),
                        Beneficiario = c.String(),
                        Tarea = c.String(),
                        BusID = c.Int(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                        Bus_BusID = c.Int(),
                        Bust_BusID = c.Int(),
                        LugarViaje_LugarViajeID = c.Int(),
                        Bus_BusID1 = c.Int(),
                        Bus_BusID2 = c.Int(),
                        Bus2_BusID = c.Int(),
                        Cliente_ClienteID = c.Int(),
                        LugarViaje_LugarViajeID1 = c.Int(),
                        TipoViaje_TipoViajeID = c.Int(),
                        Venta_VentaID = c.Int(),
                        Venta_VentaID1 = c.Int(),
                    })
                .PrimaryKey(t => t.ServicioID)
                .ForeignKey("dbo.Buses", t => t.Bus_BusID)
                .ForeignKey("dbo.Buses", t => t.Bust_BusID)
                .ForeignKey("dbo.LugarViajes", t => t.LugarViaje_LugarViajeID)
                .ForeignKey("dbo.Buses", t => t.Bus_BusID1)
                .ForeignKey("dbo.Buses", t => t.Bus_BusID2)
                .ForeignKey("dbo.Buses", t => t.Bus2_BusID)
                .ForeignKey("dbo.Clientes", t => t.Cliente_ClienteID)
                .ForeignKey("dbo.LugarViajes", t => t.LugarViaje_LugarViajeID1)
                .ForeignKey("dbo.TipoViajes", t => t.TipoViaje_TipoViajeID)
                .ForeignKey("dbo.Ventas", t => t.Venta_VentaID)
                .ForeignKey("dbo.Ventas", t => t.Venta_VentaID1)
                .Index(t => t.Bus_BusID)
                .Index(t => t.Bust_BusID)
                .Index(t => t.LugarViaje_LugarViajeID)
                .Index(t => t.Bus_BusID1)
                .Index(t => t.Bus_BusID2)
                .Index(t => t.Bus2_BusID)
                .Index(t => t.Cliente_ClienteID)
                .Index(t => t.LugarViaje_LugarViajeID1)
                .Index(t => t.TipoViaje_TipoViajeID)
                .Index(t => t.Venta_VentaID)
                .Index(t => t.Venta_VentaID1);
            
            CreateTable(
                "dbo.Buses",
                c => new
                    {
                        BusID = c.Int(nullable: false, identity: true),
                        Placa = c.String(),
                        cantidad = c.Int(nullable: false),
                        color = c.String(),
                        Transporte1_ServicioID = c.Int(),
                        Tripulacion_EmpleadoID = c.Int(),
                        Tripulaciones1_EmpleadoID = c.Int(),
                    })
                .PrimaryKey(t => t.BusID)
                .ForeignKey("dbo.Servicios", t => t.Transporte1_ServicioID)
                .ForeignKey("dbo.Empleadoes", t => t.Tripulacion_EmpleadoID)
                .ForeignKey("dbo.Empleadoes", t => t.Tripulaciones1_EmpleadoID)
                .Index(t => t.Transporte1_ServicioID)
                .Index(t => t.Tripulacion_EmpleadoID)
                .Index(t => t.Tripulaciones1_EmpleadoID);
            
            CreateTable(
                "dbo.LugarViajes",
                c => new
                    {
                        LugarViajeID = c.Int(nullable: false, identity: true),
                        TipoLugarID = c.Int(nullable: false),
                        Descripcion = c.String(),
                        TiempoEstimado = c.String(),
                        TransporteID = c.Int(nullable: false),
                        EncomiendaID = c.Int(nullable: false),
                        Encomienda_ServicioID = c.Int(),
                        TipoLugar_TipoLugarID = c.Int(),
                        Transporte_ServicioID = c.Int(),
                        Encomienda_ServicioID1 = c.Int(),
                        Transporte_ServicioID1 = c.Int(),
                    })
                .PrimaryKey(t => t.LugarViajeID)
                .ForeignKey("dbo.Servicios", t => t.Encomienda_ServicioID)
                .ForeignKey("dbo.TipoLugars", t => t.TipoLugar_TipoLugarID)
                .ForeignKey("dbo.Servicios", t => t.Transporte_ServicioID)
                .ForeignKey("dbo.Servicios", t => t.Encomienda_ServicioID1)
                .ForeignKey("dbo.Servicios", t => t.Transporte_ServicioID1)
                .Index(t => t.Encomienda_ServicioID)
                .Index(t => t.TipoLugar_TipoLugarID)
                .Index(t => t.Transporte_ServicioID)
                .Index(t => t.Encomienda_ServicioID1)
                .Index(t => t.Transporte_ServicioID1);
            
            CreateTable(
                "dbo.TipoLugars",
                c => new
                    {
                        TipoLugarID = c.Int(nullable: false, identity: true),
                        CostoAdicional = c.Double(nullable: false),
                        LugarViajeID = c.Int(nullable: false),
                        LugarViaje_LugarViajeID = c.Int(),
                        LugarViaje_LugarViajeID1 = c.Int(),
                    })
                .PrimaryKey(t => t.TipoLugarID)
                .ForeignKey("dbo.LugarViajes", t => t.LugarViaje_LugarViajeID)
                .ForeignKey("dbo.LugarViajes", t => t.LugarViaje_LugarViajeID1)
                .Index(t => t.LugarViaje_LugarViajeID)
                .Index(t => t.LugarViaje_LugarViajeID1);
            
            CreateTable(
                "dbo.TipoTripulacions",
                c => new
                    {
                        TipoTripulacionID = c.Int(nullable: false, identity: true),
                        Descripción = c.String(),
                        TripulacionID = c.Int(nullable: false),
                        Tripulacion_EmpleadoID = c.Int(),
                        Tripulacion_EmpleadoID1 = c.Int(),
                    })
                .PrimaryKey(t => t.TipoTripulacionID)
                .ForeignKey("dbo.Empleadoes", t => t.Tripulacion_EmpleadoID)
                .ForeignKey("dbo.Empleadoes", t => t.Tripulacion_EmpleadoID1)
                .Index(t => t.Tripulacion_EmpleadoID)
                .Index(t => t.Tripulacion_EmpleadoID1);
            
            CreateTable(
                "dbo.TipoViajes",
                c => new
                    {
                        TipoViajeID = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(),
                        Beneficio = c.String(),
                        TransporteID = c.Int(nullable: false),
                        Transporte_ServicioID = c.Int(),
                        Transporte_ServicioID1 = c.Int(),
                    })
                .PrimaryKey(t => t.TipoViajeID)
                .ForeignKey("dbo.Servicios", t => t.Transporte_ServicioID)
                .ForeignKey("dbo.Servicios", t => t.Transporte_ServicioID1)
                .Index(t => t.Transporte_ServicioID)
                .Index(t => t.Transporte_ServicioID1);
            
            CreateTable(
                "dbo.TipoComprobantes",
                c => new
                    {
                        TipoComprobanteID = c.Int(nullable: false, identity: true),
                        Total = c.Double(nullable: false),
                        Fecha = c.DateTime(nullable: false),
                        Hora = c.DateTime(nullable: false),
                        VentaID = c.Int(nullable: false),
                        Venta_VentaID = c.Int(),
                        Venta_VentaID1 = c.Int(),
                    })
                .PrimaryKey(t => t.TipoComprobanteID)
                .ForeignKey("dbo.Ventas", t => t.Venta_VentaID)
                .ForeignKey("dbo.Ventas", t => t.Venta_VentaID1)
                .Index(t => t.Venta_VentaID)
                .Index(t => t.Venta_VentaID1);
            
            CreateTable(
                "dbo.TipoPagoes",
                c => new
                    {
                        TipoPagoID = c.Int(nullable: false, identity: true),
                        NombreTipoPago = c.String(),
                        VentaID = c.Int(nullable: false),
                        Venta_VentaID = c.Int(),
                        Venta_VentaID1 = c.Int(),
                    })
                .PrimaryKey(t => t.TipoPagoID)
                .ForeignKey("dbo.Ventas", t => t.Venta_VentaID)
                .ForeignKey("dbo.Ventas", t => t.Venta_VentaID1)
                .Index(t => t.Venta_VentaID)
                .Index(t => t.Venta_VentaID1);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Empleadoes", "Venta_VentaID1", "dbo.Ventas");
            DropForeignKey("dbo.TipoPagoes", "Venta_VentaID1", "dbo.Ventas");
            DropForeignKey("dbo.Ventas", "TipoPago_TipoPagoID", "dbo.TipoPagoes");
            DropForeignKey("dbo.TipoPagoes", "Venta_VentaID", "dbo.Ventas");
            DropForeignKey("dbo.TipoComprobantes", "Venta_VentaID1", "dbo.Ventas");
            DropForeignKey("dbo.Ventas", "TipoComprobante_TipoComprobanteID", "dbo.TipoComprobantes");
            DropForeignKey("dbo.TipoComprobantes", "Venta_VentaID", "dbo.Ventas");
            DropForeignKey("dbo.Servicios", "Venta_VentaID1", "dbo.Ventas");
            DropForeignKey("dbo.Ventas", "Servicio_ServicioID", "dbo.Servicios");
            DropForeignKey("dbo.Servicios", "Venta_VentaID", "dbo.Ventas");
            DropForeignKey("dbo.Clientes", "Venta_VentaID1", "dbo.Ventas");
            DropForeignKey("dbo.Ventas", "Cliente_ClienteID", "dbo.Clientes");
            DropForeignKey("dbo.Clientes", "Venta_VentaID", "dbo.Ventas");
            DropForeignKey("dbo.Clientes", "Transporte_ServicioID1", "dbo.Servicios");
            DropForeignKey("dbo.TipoViajes", "Transporte_ServicioID1", "dbo.Servicios");
            DropForeignKey("dbo.Servicios", "TipoViaje_TipoViajeID", "dbo.TipoViajes");
            DropForeignKey("dbo.TipoViajes", "Transporte_ServicioID", "dbo.Servicios");
            DropForeignKey("dbo.LugarViajes", "Transporte_ServicioID1", "dbo.Servicios");
            DropForeignKey("dbo.Servicios", "LugarViaje_LugarViajeID1", "dbo.LugarViajes");
            DropForeignKey("dbo.Clientes", "Transporte_ServicioID", "dbo.Servicios");
            DropForeignKey("dbo.Servicios", "Cliente_ClienteID", "dbo.Clientes");
            DropForeignKey("dbo.Servicios", "Bus2_BusID", "dbo.Buses");
            DropForeignKey("dbo.Servicios", "Bus_BusID2", "dbo.Buses");
            DropForeignKey("dbo.Buses", "Tripulaciones1_EmpleadoID", "dbo.Empleadoes");
            DropForeignKey("dbo.Buses", "Tripulacion_EmpleadoID", "dbo.Empleadoes");
            DropForeignKey("dbo.TipoTripulacions", "Tripulacion_EmpleadoID1", "dbo.Empleadoes");
            DropForeignKey("dbo.Empleadoes", "TipoTripulacion_TipoTripulacionID", "dbo.TipoTripulacions");
            DropForeignKey("dbo.TipoTripulacions", "Tripulacion_EmpleadoID", "dbo.Empleadoes");
            DropForeignKey("dbo.Empleadoes", "Bus1_BusID", "dbo.Buses");
            DropForeignKey("dbo.Buses", "Transporte1_ServicioID", "dbo.Servicios");
            DropForeignKey("dbo.Servicios", "Bus_BusID1", "dbo.Buses");
            DropForeignKey("dbo.LugarViajes", "Encomienda_ServicioID1", "dbo.Servicios");
            DropForeignKey("dbo.Servicios", "LugarViaje_LugarViajeID", "dbo.LugarViajes");
            DropForeignKey("dbo.LugarViajes", "Transporte_ServicioID", "dbo.Servicios");
            DropForeignKey("dbo.TipoLugars", "LugarViaje_LugarViajeID1", "dbo.LugarViajes");
            DropForeignKey("dbo.LugarViajes", "TipoLugar_TipoLugarID", "dbo.TipoLugars");
            DropForeignKey("dbo.TipoLugars", "LugarViaje_LugarViajeID", "dbo.LugarViajes");
            DropForeignKey("dbo.LugarViajes", "Encomienda_ServicioID", "dbo.Servicios");
            DropForeignKey("dbo.Servicios", "Bust_BusID", "dbo.Buses");
            DropForeignKey("dbo.Servicios", "Bus_BusID", "dbo.Buses");
            DropForeignKey("dbo.Empleadoes", "Venta_VentaID", "dbo.Ventas");
            DropForeignKey("dbo.Ventas", "Administrativo_EmpleadoID", "dbo.Empleadoes");
            DropIndex("dbo.TipoPagoes", new[] { "Venta_VentaID1" });
            DropIndex("dbo.TipoPagoes", new[] { "Venta_VentaID" });
            DropIndex("dbo.TipoComprobantes", new[] { "Venta_VentaID1" });
            DropIndex("dbo.TipoComprobantes", new[] { "Venta_VentaID" });
            DropIndex("dbo.TipoViajes", new[] { "Transporte_ServicioID1" });
            DropIndex("dbo.TipoViajes", new[] { "Transporte_ServicioID" });
            DropIndex("dbo.TipoTripulacions", new[] { "Tripulacion_EmpleadoID1" });
            DropIndex("dbo.TipoTripulacions", new[] { "Tripulacion_EmpleadoID" });
            DropIndex("dbo.TipoLugars", new[] { "LugarViaje_LugarViajeID1" });
            DropIndex("dbo.TipoLugars", new[] { "LugarViaje_LugarViajeID" });
            DropIndex("dbo.LugarViajes", new[] { "Transporte_ServicioID1" });
            DropIndex("dbo.LugarViajes", new[] { "Encomienda_ServicioID1" });
            DropIndex("dbo.LugarViajes", new[] { "Transporte_ServicioID" });
            DropIndex("dbo.LugarViajes", new[] { "TipoLugar_TipoLugarID" });
            DropIndex("dbo.LugarViajes", new[] { "Encomienda_ServicioID" });
            DropIndex("dbo.Buses", new[] { "Tripulaciones1_EmpleadoID" });
            DropIndex("dbo.Buses", new[] { "Tripulacion_EmpleadoID" });
            DropIndex("dbo.Buses", new[] { "Transporte1_ServicioID" });
            DropIndex("dbo.Servicios", new[] { "Venta_VentaID1" });
            DropIndex("dbo.Servicios", new[] { "Venta_VentaID" });
            DropIndex("dbo.Servicios", new[] { "TipoViaje_TipoViajeID" });
            DropIndex("dbo.Servicios", new[] { "LugarViaje_LugarViajeID1" });
            DropIndex("dbo.Servicios", new[] { "Cliente_ClienteID" });
            DropIndex("dbo.Servicios", new[] { "Bus2_BusID" });
            DropIndex("dbo.Servicios", new[] { "Bus_BusID2" });
            DropIndex("dbo.Servicios", new[] { "Bus_BusID1" });
            DropIndex("dbo.Servicios", new[] { "LugarViaje_LugarViajeID" });
            DropIndex("dbo.Servicios", new[] { "Bust_BusID" });
            DropIndex("dbo.Servicios", new[] { "Bus_BusID" });
            DropIndex("dbo.Clientes", new[] { "Venta_VentaID1" });
            DropIndex("dbo.Clientes", new[] { "Venta_VentaID" });
            DropIndex("dbo.Clientes", new[] { "Transporte_ServicioID1" });
            DropIndex("dbo.Clientes", new[] { "Transporte_ServicioID" });
            DropIndex("dbo.Ventas", new[] { "TipoPago_TipoPagoID" });
            DropIndex("dbo.Ventas", new[] { "TipoComprobante_TipoComprobanteID" });
            DropIndex("dbo.Ventas", new[] { "Servicio_ServicioID" });
            DropIndex("dbo.Ventas", new[] { "Cliente_ClienteID" });
            DropIndex("dbo.Ventas", new[] { "Administrativo_EmpleadoID" });
            DropIndex("dbo.Empleadoes", new[] { "Venta_VentaID1" });
            DropIndex("dbo.Empleadoes", new[] { "TipoTripulacion_TipoTripulacionID" });
            DropIndex("dbo.Empleadoes", new[] { "Bus1_BusID" });
            DropIndex("dbo.Empleadoes", new[] { "Venta_VentaID" });
            DropTable("dbo.TipoPagoes");
            DropTable("dbo.TipoComprobantes");
            DropTable("dbo.TipoViajes");
            DropTable("dbo.TipoTripulacions");
            DropTable("dbo.TipoLugars");
            DropTable("dbo.LugarViajes");
            DropTable("dbo.Buses");
            DropTable("dbo.Servicios");
            DropTable("dbo.Clientes");
            DropTable("dbo.Ventas");
            DropTable("dbo.Empleadoes");
        }
    }
}
