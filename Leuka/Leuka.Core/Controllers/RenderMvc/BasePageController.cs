using Leuka.Core.Contexts;
using Leuka.Core.Extensions;
using Leuka.Models.Generated;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Umbraco.Cms.Core.Web;
using Umbraco.Cms.Web.Common;
using Umbraco.Cms.Web.Common.Controllers;

namespace Leuka.Core.Controllers.RenderMvc
{
    public abstract class BasePageController<T> : RenderController where T : class, IPage
    {
        private readonly UmbracoHelper umbracoHelper;
        protected BasePageController(ILogger<RenderController> logger, ICompositeViewEngine compositeViewEngine, IUmbracoContextAccessor umbracoContextAccessor, IHttpContextAccessor httpContextAccessor) 
            : base(logger, compositeViewEngine, umbracoContextAccessor)
        {
            umbracoHelper = httpContextAccessor.HttpContext.RequestServices.GetRequiredService<UmbracoHelper>();
        }

        protected IPageContext<T> CreatePageContext() => CurrentPage.AsPageContext<T>();
    }
}
