using Leuka.Models.Generated;

namespace Leuka.Core.ViewModels.Shared
{
    public class HeaderViewModel : IContentViewModel
    {
        public HeaderViewModel(Blogs page)
        {
            PageDescription = page.UnderPageTitleDescription;
            Title = page.PageTitle;
        }

        public string Title { get; set; }

        public string PageDescription { get; set; }

        public string PartialViewPath { get; }
    }
}