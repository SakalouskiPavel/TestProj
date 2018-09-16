using System.Threading.Tasks;
using TestProj.Common.DTO.Users;

namespace TestProj.Common.Interfaces.Services.Users
{
    public interface IAccountService
    {
        Task RegisterAsync(RegisterUserDto registerData);
    }
}