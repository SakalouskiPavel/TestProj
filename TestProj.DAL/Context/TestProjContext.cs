using System.Data.Entity;
using TestProj.Common.Models.DALModels.Users;
using TestProj.DAL.Configurations.Users;
using TestProj.DAL.Migrations;

namespace TestProj.DAL.Context
{
    public class TestProjContext : DbContext
    {
        public TestProjContext() : base("TestProjDb")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<TestProjContext, Configuration>());
        }

        public IDbSet<AccountDbModel> Accounts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new AccountDbConfiguration());
        }
    }
}