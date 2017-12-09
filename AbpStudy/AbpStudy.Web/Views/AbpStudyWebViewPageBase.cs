using Abp.Web.Mvc.Views;

namespace AbpStudy.Web.Views
{
    public abstract class AbpStudyWebViewPageBase : AbpStudyWebViewPageBase<dynamic>
    {

    }

    public abstract class AbpStudyWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected AbpStudyWebViewPageBase()
        {
            LocalizationSourceName = AbpStudyConsts.LocalizationSourceName;
        }
    }
}