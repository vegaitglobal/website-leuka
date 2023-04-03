using Leuka.Models.Generated;
using Umbraco.Cms.Web.Common;

namespace Leuka.Core.Contexts
{
    public class PageContext<T> : SiteContext, IPageContext<T> where T : class, IPage
    {
        public PageContext(T page, UmbracoHelper umbracoHelper) : base(umbracoHelper)
        {
            Page = page ?? throw new ArgumentNullException(nameof(page));
        }

        public PageContext(T page) : base(page)
        {
            Page = page ?? throw new ArgumentNullException(nameof(page));
        }

        public T Page { get; }
    }
}
