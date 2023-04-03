using Leuka.Core.Contexts;
using Leuka.Core.Extensions;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Umbraco.Cms.Core.Cache;
using Umbraco.Cms.Core.Logging;
using Umbraco.Cms.Core.Routing;
using Umbraco.Cms.Core.Services;
using Umbraco.Cms.Core.Web;
using Umbraco.Cms.Infrastructure.Persistence;
using Umbraco.Cms.Web.Common;
using Umbraco.Cms.Web.Website.Controllers;

namespace Leuka.Core.Controllers.Surface
{
    public abstract class BaseSurfaceController : SurfaceController
	{
		private UmbracoHelper umbracoHelper;
        protected BaseSurfaceController(IUmbracoContextAccessor umbracoContextAccessor, IUmbracoDatabaseFactory databaseFactory, ServiceContext services,
			AppCaches appCaches, IProfilingLogger profilingLogger, IPublishedUrlProvider publishedUrlProvider,
            IHttpContextAccessor httpContextAccessor) 
			: base(umbracoContextAccessor, databaseFactory, services, appCaches, profilingLogger, publishedUrlProvider)
        {
			umbracoHelper = httpContextAccessor.HttpContext.RequestServices.GetRequiredService<UmbracoHelper>();
        }
        protected ISiteContext CreateSiteContext()
			=> umbracoHelper.CreateSiteContext();
	}
}
