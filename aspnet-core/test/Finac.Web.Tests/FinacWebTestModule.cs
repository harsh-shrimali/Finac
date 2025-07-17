using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Finac.EntityFrameworkCore;
using Finac.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace Finac.Web.Tests
{
    [DependsOn(
        typeof(FinacWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class FinacWebTestModule : AbpModule
    {
        public FinacWebTestModule(FinacEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(FinacWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(FinacWebMvcModule).Assembly);
        }
    }
}