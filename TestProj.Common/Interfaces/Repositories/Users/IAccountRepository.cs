using TestProj.Common.Interfaces.Repositories.Base;
using TestProj.Common.Models.DALModels.Users;

namespace TestProj.Common.Interfaces.Repositories.Users
{
    public interface IAccountRepository : IBaseRepository<AccountDbModel>
    {
    }
}