using System.Web.Mvc;
using Leuka.Core.Extensions;
using Leuka.Core.ViewModels.Pages;
using Leuka.Models.Generated;

namespace Leuka.Core.Controllers.RenderMvc
{
	public class SearchResultsController : BasePageController<SearchResults>
	{
		public ActionResult Index(SearchResults model)
			=> CurrentTemplate(
				new SearchResultsViewModel(CreatePageContext(model), 
				Request.GetQueryParameter(),
				Request.GetPageParameter()));
	}
}
