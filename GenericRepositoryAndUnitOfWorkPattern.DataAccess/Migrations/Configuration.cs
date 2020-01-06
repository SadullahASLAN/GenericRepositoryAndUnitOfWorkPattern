namespace GenericRepositoryAndUnitOfWorkPattern.DataAccess.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<GenericRepositoryAndUnitOfWorkPattern.DataAccess.GenericRepositoryAndUnitOfWorkPatternDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(GenericRepositoryAndUnitOfWorkPattern.DataAccess.GenericRepositoryAndUnitOfWorkPatternDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
