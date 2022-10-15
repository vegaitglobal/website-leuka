using Leuka.Core.Contexts;
using Leuka.Models.Generated;

namespace Leuka.Core.ViewModels.Pages
{
    public class NasiPobedniciViewModel : PageViewModel
    {
        public string Title { get; set; }
        public NasiPobedniciViewModel(IPageContext<NasiPobednici> context) : base(context)
        {
            Title = context.Page.Title;
        }
    }
}
