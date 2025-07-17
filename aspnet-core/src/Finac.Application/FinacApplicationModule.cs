using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Finac.Authorization;

namespace Finac
{
    [DependsOn(
        typeof(FinacCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class FinacApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<FinacAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(FinacApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
