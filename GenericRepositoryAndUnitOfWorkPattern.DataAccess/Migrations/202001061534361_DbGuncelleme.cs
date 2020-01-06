namespace GenericRepositoryAndUnitOfWorkPattern.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DbGuncelleme : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Personeller", "SilinmeTarihi", c => c.DateTime());
            AlterColumn("dbo.Projeler", "SilinmeTarihi", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Projeler", "SilinmeTarihi", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Personeller", "SilinmeTarihi", c => c.DateTime(nullable: false));
        }
    }
}
