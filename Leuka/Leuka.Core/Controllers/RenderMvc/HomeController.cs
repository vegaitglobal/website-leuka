using System.Web.Mvc;
using Leuka.Core.ViewModels.Pages;
using Leuka.Models.Generated;

namespace Leuka.Core.Controllers.RenderMvc
{
	public class HomeController : BasePageController<Home>
	{
		public ActionResult Index(Home model) 
			=> CurrentTemplate(new HomeViewModel(CreatePageContext(model)));
	}
}
