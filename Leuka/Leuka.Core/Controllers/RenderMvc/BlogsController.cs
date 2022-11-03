using Leuka.Core.ViewModels.Pages;
using Leuka.Models.Generated;
using System.Web.Mvc;

namespace Leuka.Core.Controllers.RenderMvc
{
    public class BlogsController : BasePageController<Blogs>
    {
        public ActionResult Index(Blogs model)
            => CurrentTemplate(new BlogsViewModel(CreatePageContext(model)));
    }
}
