namespace Garage2._0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class parkedvehicleRest : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.ParkedVehicles");
            AlterColumn("dbo.ParkedVehicles", "RegistrationNumber", c => c.String(nullable: false, maxLength: 6));
            AlterColumn("dbo.ParkedVehicles", "Color", c => c.String(maxLength: 20));
            AddPrimaryKey("dbo.ParkedVehicles", "RegistrationNumber");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.ParkedVehicles");
            AlterColumn("dbo.ParkedVehicles", "Color", c => c.String());
            AlterColumn("dbo.ParkedVehicles", "RegistrationNumber", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.ParkedVehicles", "RegistrationNumber");
        }
    }
}
