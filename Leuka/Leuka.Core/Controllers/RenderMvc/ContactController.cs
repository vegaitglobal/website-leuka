using Leuka.Core.ViewModels.Pages;
using Leuka.Models.Generated;
using System.Web.Mvc;

namespace Leuka.Core.Controllers.RenderMvc
{
    public class ContactController : BasePageController<Contact>
    {
        public ActionResult Index(Contact model)
            => CurrentTemplate(new ContactViewModel(CreatePageContext(model)));
    }
}
