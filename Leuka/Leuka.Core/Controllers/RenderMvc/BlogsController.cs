using Leuka.Core.ViewModels.Pages;
using Leuka.Models.Generated;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using Microsoft.Extensions.Logging;
using Umbraco.Cms.Core.Web;
using Umbraco.Cms.Web.Common.Controllers;

namespace Leuka.Core.Controllers.RenderMvc
{
    public class BlogsController : BasePageController<Blogs>
    {
        public BlogsController(ILogger<RenderController> logger, ICompositeViewEngine compositeViewEngine, IUmbracoContextAccessor umbracoContextAccessor, IHttpContextAccessor httpContextAccessor) : base(logger, compositeViewEngine, umbracoContextAccessor, httpContextAccessor)
        {
        }

        public override IActionResult Index() => CurrentTemplate(new BlogsViewModel(CreatePageContext()));
    }
}
