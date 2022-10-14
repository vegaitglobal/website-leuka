using Leuka.Core.Contexts;
using Leuka.Models.Generated;

namespace Leuka.Core.ViewModels.Pages
{
    public class ArticleViewModel : PageViewModel
    {
        public ArticleViewModel(IPageContext<Article> context) : base(context)
        {
        }
    }
}
