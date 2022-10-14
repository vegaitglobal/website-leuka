using Leuka.Core.Contexts;
using Leuka.Models.Generated;

namespace Leuka.Core.ViewModels.Pages
{
    public class BlogViewModel : PageViewModel
    {
        public BlogViewModel(IPageContext<Blog> context) : base(context)
        {
        }
    }
}
