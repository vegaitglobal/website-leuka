using Leuka.Core.ViewModels.Pages;
using Leuka.Models.Generated;
using System.Web.Mvc;

namespace Leuka.Core.Controllers.RenderMvc
{
    public class ArticleController : BasePageController<Article>
    {
        public ActionResult Index(Article model)
            => CurrentTemplate(new ArticleViewModel(CreatePageContext(model)));
    }
}
