using Leuka.Core.Contexts;
using Leuka.Models.Generated;
using Umbraco.Cms.Web.Common;

namespace Leuka.Core.Extensions
{
    public static class UmbracoHelperExtensions
    {
        public static ISiteContext CreateSiteContext(this UmbracoHelper helper)
            => new SiteContext(helper);

        public static IPageContext<T> CreatePageContext<T>(this UmbracoHelper helper, T page) where T : class, IPage
            => new PageContext<T>(page, helper);
    }
}
