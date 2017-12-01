using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.TestBase;
using YunPian.Configuration;

namespace YunPian.Tests
{
    [DependsOn(typeof(YunPianModule), typeof(AbpTestBaseModule))]
    public class YunPianTestModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Modules.YunPian().ApiKey = "your api key";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(YunPianTestModule).GetAssembly());
        }
    }
}