using System.Data.Entity;
using TestProj.Common.Interfaces.Repositories.Users;
using TestProj.Common.Models.DALModels.Users;
using TestProj.DAL.Repositories.Base;

namespace TestProj.DAL.Repositories.Users
{
    public class AccountRepository : BaseRepository<AccountDbModel>, IAccountRepository
    {
        public AccountRepository(DbContext context) : base(context)
        {
        }
    }
}