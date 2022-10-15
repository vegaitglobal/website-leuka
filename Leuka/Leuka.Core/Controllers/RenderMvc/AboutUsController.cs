using System.Web.Mvc;
using Leuka.Core.Controllers.RenderMvc;
using Leuka.Core.ViewModels.Pages;
using Leuka.Models.Generated;

namespace Leuka.Core.Controllers
{
    public class AboutUsController : BasePageController<AboutUs>
    {
        public ActionResult Index(AboutUs model) 
            => CurrentTemplate(new AboutUsViewModel(CreatePageContext(model)));
    }
}