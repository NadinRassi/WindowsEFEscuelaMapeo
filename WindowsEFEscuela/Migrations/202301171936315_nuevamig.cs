namespace WindowsEFEscuela.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class nuevamig : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Alumno", "ProfesorId", c => c.Int(nullable: false));
            CreateIndex("dbo.Alumno", "ProfesorId");
            AddForeignKey("dbo.Alumno", "ProfesorId", "dbo.Docente", "ProfesorId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Alumno", "ProfesorId", "dbo.Docente");
            DropIndex("dbo.Alumno", new[] { "ProfesorId" });
            DropColumn("dbo.Alumno", "ProfesorId");
        }
    }
}
