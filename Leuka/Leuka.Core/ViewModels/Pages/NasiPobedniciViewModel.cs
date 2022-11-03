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
            var contextPage = context.Page;
            Title = contextPage.Title;

            Components = new List<IContentViewModel>();
            var titleDescriptionAndButton = contextPage.TitleDescriptionAndButton;
            if (titleDescriptionAndButton != null)
            {
                var titleDescriptionAndButtonModels = titleDescriptionAndButton.Select(x => new TitleDescriptionAndButtonViewModel(x));
                Components.AddRange(titleDescriptionAndButtonModels);
            }

            var highlightedArticle = contextPage.HighlightedArticle;
            if (highlightedArticle != null)
            {
                var highlightedArticleModels = highlightedArticle.Select(x => new HighlightedArticleViewModel(x));
                Components.AddRange(highlightedArticleModels);
            }

            var grid = contextPage.BlogsGrid.FirstOrDefault();
            if (grid != null)
            {
                var gridViewModel = new BlockGridViewModel(grid, contextPage);
                Components.Add(gridViewModel);
            }
         
            var blogSignUp = contextPage.BlogSignUp;
            if (blogSignUp != null)
            {
                var blogSignUpModels = blogSignUp.Select(x => new BlogSignUpViewModel(x));
                Components.AddRange(blogSignUpModels);
            }
        }
    }
}
