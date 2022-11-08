using Leuka.Core.ViewModels.Shared;
using Leuka.Models.Generated;
using System;
using System.Linq;
using System.Web.Mvc;
using Umbraco.Core.Composing;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;

namespace Leuka.Core.Controllers.Surface.Partials
{
    public class BlogsGridController : BaseSurfaceController
    {
        private const int BatchSize = 9;

        [HttpPost]
        public ActionResult Blogs(int numberOfDispalyedArticles, string filter, string path)
        {
            PublishedContentModel page = null;
            var umbracoContextFactory = Current.Factory.GetInstance(typeof(IUmbracoContextFactory)) as IUmbracoContextFactory;
            using (var contextReference = umbracoContextFactory.EnsureUmbracoContext())
            {
                var umbracoContext = contextReference.UmbracoContext;
                page = umbracoContext.Content.GetByRoute(path) as PublishedContentModel;
            }

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
