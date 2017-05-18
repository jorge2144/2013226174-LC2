namespace CajeroAutomatico.Persistence.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ATM",
                c => new
                    {
                        ATMId = c.Int(nullable: false, identity: true),
                        RanuraDepositoId = c.Int(nullable: false),
                        PantallaId = c.Int(nullable: false),
                        TecladoId = c.Int(nullable: false),
                        BaseDeDatosId = c.Int(nullable: false),
                        DispensadorEfectivoId = c.Int(nullable: false),
                        RetiroId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ATMId);
            
            CreateTable(
                "dbo.BaseDeDatos",
                c => new
                    {
                        BaseDeDatosId = c.Int(nullable: false),
                        CuentaId = c.Int(nullable: false),
                        RetiroId = c.Int(nullable: false),
                        ATMId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.BaseDeDatosId)
                .ForeignKey("dbo.ATM", t => t.BaseDeDatosId)
                .Index(t => t.BaseDeDatosId);
            
            CreateTable(
                "dbo.Cuenta",
                c => new
                    {
                        CuentaId = c.Int(nullable: false),
                        NumCuenta = c.Int(nullable: false),
                        Pin = c.Int(nullable: false),
                        Monto = c.Double(nullable: false),
                        BaseDeDatosId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CuentaId)
                .ForeignKey("dbo.BaseDeDatos", t => t.CuentaId)
                .Index(t => t.CuentaId);
            
            CreateTable(
                "dbo.Retiro",
                c => new
                    {
                        RetiroId = c.Int(nullable: false),
                        DispensadorEfectivoId = c.Int(nullable: false),
                        PantallaId = c.Int(nullable: false),
                        ATMId = c.Int(nullable: false),
                        BaseDeDatosId = c.Int(nullable: false),
                        TecladoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.RetiroId)
                .ForeignKey("dbo.Dispensador efectivo", t => t.RetiroId)
                .ForeignKey("dbo.Pantalla", t => t.RetiroId)
                .ForeignKey("dbo.Teclado", t => t.RetiroId)
                .ForeignKey("dbo.BaseDeDatos", t => t.RetiroId)
                .ForeignKey("dbo.ATM", t => t.RetiroId)
                .Index(t => t.RetiroId);
            
            CreateTable(
                "dbo.Dispensador efectivo",
                c => new
                    {
                        DispensadorEfectivoId = c.Int(nullable: false),
                        ATMId = c.Int(nullable: false),
                        RetiroId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.DispensadorEfectivoId)
                .ForeignKey("dbo.ATM", t => t.DispensadorEfectivoId)
                .Index(t => t.DispensadorEfectivoId);
            
            CreateTable(
                "dbo.Pantalla",
                c => new
                    {
                        PantallaId = c.Int(nullable: false),
                        RetiroId = c.Int(nullable: false),
                        ATMId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PantallaId)
                .ForeignKey("dbo.ATM", t => t.PantallaId)
                .Index(t => t.PantallaId);
            
            CreateTable(
                "dbo.Teclado",
                c => new
                    {
                        TecladoId = c.Int(nullable: false),
                        Pin = c.Int(nullable: false),
                        NumeroCuenta = c.Int(nullable: false),
                        RetiroId = c.Int(nullable: false),
                        ATMId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TecladoId)
                .ForeignKey("dbo.ATM", t => t.TecladoId)
                .Index(t => t.TecladoId);
            
            CreateTable(
                "dbo.Ranura Deposito",
                c => new
                    {
                        RanuraDepositoId = c.Int(nullable: false),
                        ATMId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.RanuraDepositoId)
                .ForeignKey("dbo.ATM", t => t.RanuraDepositoId)
                .Index(t => t.RanuraDepositoId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Teclado", "TecladoId", "dbo.ATM");
            DropForeignKey("dbo.Retiro", "RetiroId", "dbo.ATM");
            DropForeignKey("dbo.Ranura Deposito", "RanuraDepositoId", "dbo.ATM");
            DropForeignKey("dbo.Pantalla", "PantallaId", "dbo.ATM");
            DropForeignKey("dbo.Dispensador efectivo", "DispensadorEfectivoId", "dbo.ATM");
            DropForeignKey("dbo.BaseDeDatos", "BaseDeDatosId", "dbo.ATM");
            DropForeignKey("dbo.Retiro", "RetiroId", "dbo.BaseDeDatos");
            DropForeignKey("dbo.Retiro", "RetiroId", "dbo.Teclado");
            DropForeignKey("dbo.Retiro", "RetiroId", "dbo.Pantalla");
            DropForeignKey("dbo.Retiro", "RetiroId", "dbo.Dispensador efectivo");
            DropForeignKey("dbo.Cuenta", "CuentaId", "dbo.BaseDeDatos");
            DropIndex("dbo.Ranura Deposito", new[] { "RanuraDepositoId" });
            DropIndex("dbo.Teclado", new[] { "TecladoId" });
            DropIndex("dbo.Pantalla", new[] { "PantallaId" });
            DropIndex("dbo.Dispensador efectivo", new[] { "DispensadorEfectivoId" });
            DropIndex("dbo.Retiro", new[] { "RetiroId" });
            DropIndex("dbo.Cuenta", new[] { "CuentaId" });
            DropIndex("dbo.BaseDeDatos", new[] { "BaseDeDatosId" });
            DropTable("dbo.Ranura Deposito");
            DropTable("dbo.Teclado");
            DropTable("dbo.Pantalla");
            DropTable("dbo.Dispensador efectivo");
            DropTable("dbo.Retiro");
            DropTable("dbo.Cuenta");
            DropTable("dbo.BaseDeDatos");
            DropTable("dbo.ATM");
        }
    }
}
