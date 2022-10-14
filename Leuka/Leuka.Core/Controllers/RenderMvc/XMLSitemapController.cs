using System.Web.Mvc;
using Umbraco.Web.Mvc;
using Leuka.Core.ViewModels.Pages;
using Leuka.Models.DocumentTypes;

namespace Leuka.Core.Controllers.RenderMvc
{
	public class XMLSitemapController : RenderMvcController
	{
		public ActionResult XMLSitemap(IDomainRoot model)
			=> CurrentTemplate(new XMLSitemapViewModel(model));
	}
}
