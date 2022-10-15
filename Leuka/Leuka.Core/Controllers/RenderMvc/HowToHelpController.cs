using Leuka.Core.ViewModels.Pages;
using Leuka.Models.Generated;
using System.Web.Mvc;

namespace Leuka.Core.Controllers.RenderMvc
{
    public class HowToHelpController : BasePageController<HowToHelp>
    {
        public ActionResult Index(HowToHelp model)
            => CurrentTemplate(new HowToHelpViewModel(CreatePageContext(model)));
    }
}
