namespace Garage2._0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ParkedVehicles",
                c => new
                    {
                        RegistrationNumber = c.String(nullable: false, maxLength: 128),
                        Type = c.Int(nullable: false),
                        Color = c.String(),
                        Brand = c.String(),
                        Wheels = c.Int(nullable: false),
                        Timestamp = c.String(),
                    })
                .PrimaryKey(t => t.RegistrationNumber);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ParkedVehicles");
        }
    }
}
