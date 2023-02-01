namespace WindowsEFEscuela.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cambio1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Aulas", "Codigo", c => c.String(nullable: false, maxLength: 1, fixedLength: true, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Aulas", "Codigo", c => c.String(maxLength: 1, fixedLength: true, unicode: false));
        }
    }
}
