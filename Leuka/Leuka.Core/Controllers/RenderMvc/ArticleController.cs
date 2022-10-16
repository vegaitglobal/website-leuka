using Leuka.Core.ViewModels.Pages;
using Leuka.Core.ViewModels.Shared;
using Leuka.Models.Generated;
using System.Linq;
using System.Web.Mvc;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;

namespace Leuka.Core.Controllers.RenderMvc
{
    public class ArticleController : BasePageController<Article>
    {
        public ActionResult Index(Article model)
             => CurrentTemplate(new ArticleViewModel(CreatePageContext(model), GetBreadCrumbs(model)));

        private BreadcrumbsViewModel GetBreadCrumbs(Article page)
        {
            var rootId = page.Root().Id;
            var breadcrumbs = new BreadcrumbsViewModel();
            GetItemPath(page, rootId, breadcrumbs);

            breadcrumbs.Chain = breadcrumbs.Chain.Reverse().ToList();
            return breadcrumbs;
        }

        private void GetItemPath(IPublishedContent page, int rootId, BreadcrumbsViewModel breadcrumbs)
        {
            if (page.Id != rootId)
            {
                breadcrumbs.Chain.Add(new ButtonViewModel(page.Name, page.Url()));
                GetItemPath(page.Parent, rootId, breadcrumbs);
            }
        }
    }
}
