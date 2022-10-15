using Leuka.Core.Contexts;
using Leuka.Models.Generated;

namespace Leuka.Core.ViewModels.Pages
{
    public class HowToHelpViewModel : PageViewModel
    {
        public string Title { get; set; }
        public HowToHelpViewModel(IPageContext<HowToHelp> context) : base(context)
        {
            Title = context.Page.Title;
        }
    }
}
