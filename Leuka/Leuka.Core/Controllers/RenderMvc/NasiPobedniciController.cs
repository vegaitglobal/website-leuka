using Leuka.Core.ViewModels.Pages;
using Leuka.Models.Generated;
using System.Web.Mvc;

namespace Leuka.Core.Controllers.RenderMvc
{
    public class NasiPobedniciController : BasePageController<NasiPobednici>
    {
        public ActionResult Index(NasiPobednici model)
            => CurrentTemplate(new NasiPobedniciViewModel(CreatePageContext(model)));
    }
}
