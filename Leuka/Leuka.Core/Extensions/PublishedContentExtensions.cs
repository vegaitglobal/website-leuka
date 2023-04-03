using Leuka.Core.Contexts;
using Leuka.Models.Generated;
using Umbraco.Cms.Core.Models.PublishedContent;

namespace Leuka.Core.Extensions
{
    public static class PublishedContentExtensions
    {
        public static IPageContext<T> AsPageContext<T>(this IPublishedContent currentPage) where T : class, IPage
        {
            var model = currentPage as T;
            return new PageContext<T>(model);
        }
    }
}
