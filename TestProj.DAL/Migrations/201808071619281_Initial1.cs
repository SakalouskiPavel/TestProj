namespace TestProj.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial1 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.AccountDbModels", newName: "accounts");
            RenameColumn(table: "dbo.accounts", name: "Id", newName: "account_id");
            RenameColumn(table: "dbo.accounts", name: "UserName", newName: "account_username");
            RenameColumn(table: "dbo.accounts", name: "Email", newName: "account_email");
            RenameColumn(table: "dbo.accounts", name: "Password", newName: "account_password");
            RenameColumn(table: "dbo.accounts", name: "Permissions", newName: "account_permissions");
            RenameColumn(table: "dbo.accounts", name: "CreatedDate", newName: "account_created_date");
            RenameColumn(table: "dbo.accounts", name: "CreatorId", newName: "account_creator_id");
            RenameColumn(table: "dbo.accounts", name: "LastUpdated", newName: "account_last_updated");
            RenameColumn(table: "dbo.accounts", name: "UpdaterId", newName: "account_updater_id");
            AlterColumn("dbo.accounts", "account_username", c => c.String(nullable: false));
            AlterColumn("dbo.accounts", "account_email", c => c.String(nullable: false));
            AlterColumn("dbo.accounts", "account_password", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.accounts", "account_password", c => c.String());
            AlterColumn("dbo.accounts", "account_email", c => c.String());
            AlterColumn("dbo.accounts", "account_username", c => c.String());
            RenameColumn(table: "dbo.accounts", name: "account_updater_id", newName: "UpdaterId");
            RenameColumn(table: "dbo.accounts", name: "account_last_updated", newName: "LastUpdated");
            RenameColumn(table: "dbo.accounts", name: "account_creator_id", newName: "CreatorId");
            RenameColumn(table: "dbo.accounts", name: "account_created_date", newName: "CreatedDate");
            RenameColumn(table: "dbo.accounts", name: "account_permissions", newName: "Permissions");
            RenameColumn(table: "dbo.accounts", name: "account_password", newName: "Password");
            RenameColumn(table: "dbo.accounts", name: "account_email", newName: "Email");
            RenameColumn(table: "dbo.accounts", name: "account_username", newName: "UserName");
            RenameColumn(table: "dbo.accounts", name: "account_id", newName: "Id");
            RenameTable(name: "dbo.accounts", newName: "AccountDbModels");
        }
    }
}
