using Leuka.Core.Contexts;
using Leuka.Core.ViewModels.Shared;
using Leuka.Models.Generated;
using System.Collections.Generic;
using System.Linq;

namespace Leuka.Core.ViewModels.Pages
{
    public class NasiPobedniciViewModel : PageViewModel
    {

        public List<IContentViewModel> Components { get; set; }
        public string Title { get; set; }

        public TitleDescriptionAndButtonViewModel TitleDescriptionAndButton { get; set; }
        public NasiPobedniciViewModel(IPageContext<NasiPobednici> context) : base(context)
        {
            Title = context.Page.Title;

            Components = new List<IContentViewModel>();
            var titleDescriptionAndButton = context.Page.TitleDescriptionAndButton;
            if (titleDescriptionAndButton != null)
            {
                var titleDescriptionAndButtonModels = titleDescriptionAndButton.Select(x => new TitleDescriptionAndButtonViewModel(x));
                Components.AddRange(titleDescriptionAndButtonModels);
            }

            var highlightedArticle = context.Page.HighlightedArticle;
            if (highlightedArticle != null)
            {
                var highlightedArticleModels = highlightedArticle.Select(x => new HighlightedArticleViewModel(x));
                Components.AddRange(highlightedArticleModels);
            }
        }
    }
}
