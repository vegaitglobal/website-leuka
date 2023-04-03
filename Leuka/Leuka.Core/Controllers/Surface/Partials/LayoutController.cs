using Leuka.Core.ViewModels.Partials.Layout;
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
    public class LayoutController : BaseSurfaceController
	{
        public LayoutController(IUmbracoContextAccessor umbracoContextAccessor, IUmbracoDatabaseFactory databaseFactory,
			ServiceContext services, AppCaches appCaches, IProfilingLogger profilingLogger,
			IPublishedUrlProvider publishedUrlProvider, IHttpContextAccessor httpContextAccessor) 
			: base(umbracoContextAccessor, databaseFactory, services, appCaches, profilingLogger, publishedUrlProvider, httpContextAccessor)
        {
        }

		public IActionResult MetaTags(MetaTagsViewModel viewModel) 
			=> PartialView(viewModel);

		public IActionResult OpenGraph(OpenGraphViewModel viewModel)
			=> PartialView(viewModel);

		public IActionResult Header(HeaderViewModel viewModel)
			=> PartialView(viewModel);

		public IActionResult Footer(FooterViewModel viewModel)
			=> PartialView(viewModel);
	}
}
