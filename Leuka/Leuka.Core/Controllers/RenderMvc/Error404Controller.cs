using System.Net;
using System.Web.Mvc;
using Leuka.Core.ViewModels.Pages;
using Leuka.Models.Generated;

namespace Leuka.Core.Controllers.RenderMvc
{
    public class Error404Controller : BasePageController<Error404>
    {
        public ActionResult Error404(Error404 model)
            => CurrentTemplate(new Error404ViewModel(CreatePageContext(model)));
    }
}