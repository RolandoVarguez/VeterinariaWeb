namespace Veterinaria.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CrearImagen : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Pets", "Imagen", c => c.Binary());
            DropColumn("dbo.Pets", "ImgUrl");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Pets", "ImgUrl", c => c.String());
            DropColumn("dbo.Pets", "Imagen");
        }
    }
}
