namespace GenericRepositoryAndUnitOfWorkPattern.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EntityDuzenleme : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Personeller", "SilinmeTarihi");
            DropColumn("dbo.Personeller", "Aktif");
            DropColumn("dbo.Projeler", "SilinmeTarihi");
            DropColumn("dbo.Projeler", "Aktif");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Projeler", "Aktif", c => c.Boolean(nullable: false));
            AddColumn("dbo.Projeler", "SilinmeTarihi", c => c.DateTime());
            AddColumn("dbo.Personeller", "Aktif", c => c.Boolean(nullable: false));
            AddColumn("dbo.Personeller", "SilinmeTarihi", c => c.DateTime());
        }
    }
}
