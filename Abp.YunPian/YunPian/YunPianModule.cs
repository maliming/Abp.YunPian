using Abp;
using Abp.Dependency;
using Abp.Modules;
using Abp.Reflection.Extensions;
using YunPian.Account;
using YunPian.Configuration;
using YunPian.Sms;

namespace YunPian
{
    [DependsOn(typeof(AbpKernelModule))]
    public class YunPianModule : AbpModule
    {
        public override void PreInitialize()
        {
            IocManager.Register<IYunPianConfiguration, YunPianConfiguration>();

            IocManager.Register<IAccountManager, AccountManager>(DependencyLifeStyle.Transient);

            IocManager.Register<ISmsManager, SmsManager>(DependencyLifeStyle.Transient);
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(YunPianModule).GetAssembly());
        }
    }
}