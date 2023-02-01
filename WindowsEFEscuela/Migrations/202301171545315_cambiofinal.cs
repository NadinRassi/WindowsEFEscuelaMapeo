namespace WindowsEFEscuela.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cambiofinal : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Materias", newName: "Materia");
            AlterColumn("dbo.Materia", "Nombre", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.Materia", "Programa", c => c.String(nullable: false, maxLength: 50, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Materia", "Programa", c => c.String(maxLength: 50, unicode: false));
            AlterColumn("dbo.Materia", "Nombre", c => c.String(maxLength: 50, unicode: false));
            RenameTable(name: "dbo.Materia", newName: "Materias");
        }
    }
}
