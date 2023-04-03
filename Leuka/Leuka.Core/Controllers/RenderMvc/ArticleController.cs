using Leuka.Core.ViewModels.Pages;
using Leuka.Core.ViewModels.Shared;
using Leuka.Models.Generated;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using Microsoft.Extensions.Logging;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Core.Web;
using Umbraco.Cms.Web.Common.Controllers;

namespace Leuka.Core.Controllers.RenderMvc
{
    public class ArticleController : BasePageController<Article>
    {
        public ArticleController(ILogger<RenderController> logger, ICompositeViewEngine compositeViewEngine, IUmbracoContextAccessor umbracoContextAccessor, IHttpContextAccessor httpContextAccessor) : base(logger, compositeViewEngine, umbracoContextAccessor, httpContextAccessor)
        {
        }

        public override IActionResult Index()
        {
            return View("~/Views/Article.cshtml", new ArticleViewModel(CreatePageContext(), GetBreadCrumbs()));
        }

        private BreadcrumbsViewModel GetBreadCrumbs()
        {
            var rootId = CurrentPage.Root().Id;
            var breadcrumbs = new BreadcrumbsViewModel();
            GetItemPath(CurrentPage, rootId, breadcrumbs);

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
