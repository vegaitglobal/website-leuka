using Leuka.Core.Contexts;
using Leuka.Core.ViewModels.Shared;
using Leuka.Models.Generated;
using System.Linq;
using Umbraco.Web;

namespace Leuka.Core.ViewModels.Pages
{
    public class BlogsViewModel : PageViewModel
    {
        public string Title { get; }
        public BlockGridViewModel Grid { get; }
        public TitleDescriptionAndButtonViewModel PageHeadline { get; }
        public HighlightedArticleViewModel HighlightedArticleViewModel { get; }

        public BlogsViewModel(IPageContext<Blogs> context) : base(context)
        {
            var contextPage = context.Page;

            var headlineInfo = contextPage.PageHeadline;
            if (headlineInfo != null)
            {
                PageHeadline = headlineInfo.Select(x => new TitleDescriptionAndButtonViewModel(x)).FirstOrDefault();
            }

            var highlightedArticle = context.Page.HighlightedArticle.FirstOrDefault();
            if (highlightedArticle != null)
            {
                HighlightedArticleViewModel = new HighlightedArticleViewModel(highlightedArticle);
            }

            var grid = contextPage.Grid.FirstOrDefault();
            if (grid != null)
            {
                Grid = new BlockGridViewModel(grid, contextPage);
            }
        }
    }
}
