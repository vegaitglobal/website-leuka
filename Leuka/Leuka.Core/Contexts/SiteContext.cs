using Leuka.Models.Generated;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Web.Common;

namespace Leuka.Core.Contexts
{
    public class SiteContext : ISiteContext
    {
        public SiteContext(UmbracoHelper umbracoHelper)
        {
            UmbracoHelper = umbracoHelper ?? throw new ArgumentNullException(nameof(umbracoHelper));

            LazyCurrentPage = new Lazy<IPage>(() => UmbracoHelper.AssignedContentItem as IPage);
            LazyHome = new Lazy<Home>(() => UmbracoHelper.AssignedContentItem?.AncestorOrSelf<Home>());
            LazySiteSettings = new Lazy<ISiteSettings>(() => LazyHome.Value);
        }

        public SiteContext(IPublishedContent page)
        {
            var currentPage = page as IPage;
            var home = page.Root<Home>();
            var siteSettings = home?.Descendant<ISiteSettings>();

            LazyCurrentPage = new Lazy<IPage>(() => currentPage);
            LazyHome = new Lazy<Home>(() => home);
            LazySiteSettings = new Lazy<ISiteSettings>(() => siteSettings);
        }

        public IPage CurrentPage => LazyCurrentPage.Value;
        public Home Home => LazyHome.Value;
        public ISiteSettings SiteSettings => LazySiteSettings.Value;

        protected UmbracoHelper UmbracoHelper { get; }

        private Lazy<IPage> LazyCurrentPage { get; }
        private Lazy<Home> LazyHome { get; }
        private Lazy<ISiteSettings> LazySiteSettings { get; }
    }
}