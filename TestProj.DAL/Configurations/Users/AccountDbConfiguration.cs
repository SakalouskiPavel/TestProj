using System.Data.Entity.ModelConfiguration;
using TestProj.Common.Models.DALModels.Users;

namespace TestProj.DAL.Configurations.Users
{
    public class AccountDbConfiguration : EntityTypeConfiguration<AccountDbModel>
    {
        public AccountDbConfiguration()
        {
            ToTable("accounts");

            HasKey(account => account.Id);

            Property(account => account.Id).IsRequired().HasColumnName("account_id");
            Property(account => account.UserName).IsRequired().HasColumnName("account_username");
            Property(account => account.Password).IsRequired().HasColumnName("account_password");
            Property(account => account.Email).IsRequired().HasColumnName("account_email");
            Property(account => account.Permissions).IsRequired().HasColumnName("account_permissions");
            Property(account => account.CreatedDate).IsRequired().HasColumnName("account_created_date");
            Property(account => account.CreatorId).IsRequired().HasColumnName("account_creator_id");
            Property(account => account.LastUpdated).IsOptional().HasColumnName("account_last_updated");
            Property(account => account.UpdaterId).IsOptional().HasColumnName("account_updater_id");
        }
    }
}