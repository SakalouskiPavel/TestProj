using System.Data.Entity;
using Ninject.Modules;
using TestProj.Common.Interfaces.Repositories.Users;
using TestProj.DAL.Context;
using TestProj.DAL.Repositories.Users;

namespace TestProj.DAL
{
    public class NInjectProfile : NinjectModule
    {
        public override void Load()
        {
            this.Bind<TestProjContext>().ToSelf();
            this.Bind<DbContext>().To<TestProjContext>();
            this.Bind<IAccountRepository>().To<AccountRepository>();
        }
    }
}