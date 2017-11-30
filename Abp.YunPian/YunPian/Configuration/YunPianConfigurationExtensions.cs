using Abp.Configuration.Startup;

namespace YunPian.Configuration
{
    public static class YunPianConfigurationExtensions
    {
        public static IYunPianConfiguration YunPianSms(this IModuleConfigurations configurations)
        {
            return configurations.AbpConfiguration.Get<IYunPianConfiguration>();
        }
    }
}