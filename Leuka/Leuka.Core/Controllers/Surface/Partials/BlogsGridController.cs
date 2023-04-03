using Leuka.Core.ViewModels.Shared;
using Leuka.Models.Generated;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Umbraco.Cms.Core.Cache;
using Umbraco.Cms.Core.Logging;
using Umbraco.Cms.Core.Routing;
using Umbraco.Cms.Core.Services;
using Umbraco.Cms.Core.Web;
using Umbraco.Cms.Infrastructure.Persistence;

namespace Leuka.Core.Controllers.Surface.Partials
{
    public class BlogsGridController : BaseSurfaceController
    {
        private const int BatchSize = 9;

        public BlogsGridController(IUmbracoContextAccessor umbracoContextAccessor, IUmbracoDatabaseFactory databaseFactory,
            ServiceContext services, AppCaches appCaches, IProfilingLogger profilingLogger, IPublishedUrlProvider publishedUrlProvider,
            IHttpContextAccessor httpContextAccessor) 
            : base(umbracoContextAccessor, databaseFactory, services, appCaches, profilingLogger, publishedUrlProvider, httpContextAccessor)
        {
        }

        [HttpPost]
        [IgnoreAntiforgeryToken]
        public IActionResult Blogs(int numberOfDispalyedArticles, string filter, string path)
        {
            var page = UmbracoContext.Content.GetByRoute(path);
            if (page != null)
            {
                var model = new BlockGridViewModel();

                model.TotalNumberOfArticles = page
                    .ChildrenOfType("article")
                    .Select(x => x as Article)
                    .Count(FilterResults(filter));

                var articlePages = page
                    .ChildrenOfType("article")
                    .Select(x => x as Article)
                    .Where(FilterResults(filter))
                    .Skip(numberOfDispalyedArticles)
                    .Take(BatchSize);

                model.Previews = articlePages
                    .Select(x => new ArticlePreviewViewModel
                    {
                        Description = x.PreviewText,
                        Image = new ImageViewModel(x.PreviewImage),
                        Link = new LinkViewModel(x.Url(), x.PageTitle),
                        Title = x.PageTitle,
                        Tags = string.Join(",", x.Tags)
                    });

                model.NumberOfDispalyedArticles = numberOfDispalyedArticles + model.Previews.Count();

                return PartialView("~/Views/Partials/NestedContent/_BlockGridViewModelPartial.cshtml", model);
            }
            return null;
        }


        private Func<Article, bool> FilterResults(string filter)
        {
            return !string.IsNullOrEmpty(filter) ? FilterResultsContains(filter) : x => true;
        }
        private Func<Article, bool> FilterResultsContains(string filter)
        {
            return x => x.Tags.Contains(filter);
        }
    }
}
