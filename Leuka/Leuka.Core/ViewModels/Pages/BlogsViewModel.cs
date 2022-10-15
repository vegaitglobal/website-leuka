using Leuka.Core.Contexts;
using Leuka.Models.Generated;

namespace Leuka.Core.ViewModels.Pages
{
    public class BlogsViewModel : PageViewModel
    {
        public string Title { get; set; }

        public BlogsViewModel(IPageContext<Blogs> context) : base(context)
        {
            Title = context.Page.Title;
        }
    }
}
