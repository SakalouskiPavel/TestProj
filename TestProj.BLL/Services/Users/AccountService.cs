using System.Threading.Tasks;
using AutoMapper;
using TestProj.Common.DTO.Users;
using TestProj.Common.Interfaces.Repositories.Users;
using TestProj.Common.Interfaces.Services.Users;
using TestProj.Common.Models.DALModels.Users;

namespace TestProj.BLL.Services.Users
{
    public class AccountService : IAccountService
    {
        private IAccountRepository _repository;

        public AccountService(IAccountRepository repository)
        {
            this._repository = repository;
        }

        public async Task RegisterAsync(RegisterUserDto registerData)
        {
            var mappedEntity = Mapper.Map<AccountDbModel>(registerData);
            await this._repository.AddAsync(mappedEntity);
        }
    }
}