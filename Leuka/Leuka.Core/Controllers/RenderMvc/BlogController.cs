using Leuka.Core.ViewModels.Pages;
using Leuka.Models.Generated;
using System.Web.Mvc;

namespace Leuka.Core.Controllers.RenderMvc
{
    public class BlogController : BasePageController<Blog>
    {
        public ActionResult Index(Blog model)
            => CurrentTemplate(new BlogViewModel(CreatePageContext(model)));
    }
}
