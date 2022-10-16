using System.Collections.Generic;
using System.Linq;
using System.Web;
using Leuka.Core.Contexts;
using Leuka.Core.ViewModels.Shared;
using Generated = Leuka.Models.Generated;

namespace Leuka.Core.ViewModels.Pages
{
    public class AboutUsViewModel  : PageViewModel
    {
        public AboutUsViewModel(IPageContext<Generated.AboutUs> context) : base(context)
        {
            //ContactUsModals = context.Page.ContactUs.Select(x => new ContactusViewModel(x));
            //Buttons = context.Page.Buttons.Select(x => new ButtonViewModel(x));
            //Sponsors = context.Page.Sponsors.Select(x => new SponsorsViewModel(x));
            //HighlightedArticles = context.Page.HighlightedArticles.Select(x => new HighlightedArticleViewModel(x));
        }

        public IEnumerable<ContactusViewModel> ContactUsModals { get; }
        public IEnumerable<ButtonViewModel> Buttons { get; }
        public IEnumerable<SponsorsViewModel> Sponsors { get; }
        public IEnumerable<HighlightedArticleViewModel> HighlightedArticles { get; }
    }
}