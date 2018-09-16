using System;
using System.Data.Entity.Migrations;
using TestProj.Common.Enums;
using TestProj.Common.Models.DALModels.Users;
using TestProj.DAL.Context;

namespace TestProj.DAL.Migrations
{
    public class Configuration :DbMigrationsConfiguration<TestProjContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TestProjContext context)
        {
            context.Accounts.Add(new AccountDbModel()
            {
                Id = 1,
                Email = "p.sokolovsky62@gmail.com",
                UserName = "admin",
                Password = "admin",
                Permissions = PermissionTypes.Base | PermissionTypes.ManageUsers,
                CreatorId = 0,
                CreatedDate = DateTime.Now,
                UpdaterId = null,
                LastUpdated = null
            });

            context.Accounts.Add(new AccountDbModel()
            {
                Id = 2,
                Email = "p.sokolovsky62@gmail.com",
                UserName = "user",
                Password = "user",
                Permissions = PermissionTypes.Base,
                CreatorId = 0,
                CreatedDate = DateTime.Now,
                UpdaterId = null,
                LastUpdated = null
            });
            base.Seed(context);
        }
    }
}