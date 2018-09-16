using Ninject.Modules;
using TestProj.BLL.Services.Users;
using TestProj.Common.Interfaces.Services.Users;

namespace TestProj.BLL
{
    public class NInjectProfile : NinjectModule
    {
        public override void Load()
        {
            this.Bind<IAccountService>().To<AccountService>();
        }
    }
}