using Leuka.Core.Contexts;
using Leuka.Models.Generated;

namespace Leuka.Core.ViewModels.Pages
{
    public class JoinUsViewModel : PageViewModel
    {
        public string Title { get; set; }
        public JoinUsViewModel(IPageContext<JoinUs> context) : base(context)
        {
            Title = context.Page.Title;
        }
    }
}
