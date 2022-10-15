namespace Leuka.Core.ViewModels.Pages
{
    public class BlogsViewModel : PageViewModel
    {
        public string Title { get; set; }

        public BlogsViewModel(IPageContext<Blogs> context) : base(context)
        {

        }
    }
}
