using Abp.AspNetCore.Mvc.ViewComponents;

namespace Boilerplate.Web.Views
{
    public abstract class BoilerplateViewComponent : AbpViewComponent
    {
        protected BoilerplateViewComponent()
        {
            LocalizationSourceName = BoilerplateConsts.LocalizationSourceName;
        }
    }
}
