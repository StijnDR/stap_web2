namespace MvcStap.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Stages", "Titel", c => c.String());
            AddColumn("dbo.Stages", "OmschrijvingOpdracht", c => c.String());
            AddColumn("dbo.Stages", "SpecialisatieOpdracht", c => c.String());
            AddColumn("dbo.Stages", "Semester", c => c.String());
            AddColumn("dbo.Stages", "AantalStudentenOpdracht", c => c.String());
            AddColumn("dbo.Stages", "Stagementor", c => c.String());
            DropColumn("dbo.Stages", "Title");
            DropColumn("dbo.Stages", "ReleaseDate");
            DropColumn("dbo.Stages", "Genre");
            DropColumn("dbo.Stages", "Price");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Stages", "Price", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Stages", "Genre", c => c.String());
            AddColumn("dbo.Stages", "ReleaseDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Stages", "Title", c => c.String());
            DropColumn("dbo.Stages", "Stagementor");
            DropColumn("dbo.Stages", "AantalStudentenOpdracht");
            DropColumn("dbo.Stages", "Semester");
            DropColumn("dbo.Stages", "SpecialisatieOpdracht");
            DropColumn("dbo.Stages", "OmschrijvingOpdracht");
            DropColumn("dbo.Stages", "Titel");
        }
    }
}
