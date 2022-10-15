using Leuka.Core.ViewModels.Pages;
using Leuka.Models.Generated;
using System.Web.Mvc;

namespace Leuka.Core.Controllers.RenderMvc
{
    public class JoinUsController : BasePageController<JoinUs>
    {
        public ActionResult Index(JoinUs model)
            => CurrentTemplate(new JoinUsViewModel(CreatePageContext(model)));
    }
}
