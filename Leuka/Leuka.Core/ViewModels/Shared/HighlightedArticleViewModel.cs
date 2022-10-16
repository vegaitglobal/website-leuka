using Umbraco.Web;
using Umbraco.Web.Models;
using Leuka.Models.Generated;
using System.Linq;

namespace Leuka.Core.ViewModels.Shared
{
	public class HighlightedArticleViewModel : IContentViewModel
    {
		public HighlightedArticleViewModel(HighlightedArticle highlightedArticle)
		{
            HighlightTitle = highlightedArticle.HighlightTitle;
            Category = highlightedArticle.Category;
            Title = highlightedArticle.Title;
            Description = highlightedArticle.Description;
            Image = new ImageViewModel(highlightedArticle.Image);

            if (highlightedArticle.LinkButton.Any())
            {
                Button = new ButtonViewModel(highlightedArticle.LinkButton.First());
            }

            if (highlightedArticle.Separator.Any())
            {
                Separator = new SeparatorViewModel(highlightedArticle.Separator.First());
            }
        }


		public string HighlightTitle { get; }
		public string Category { get; }
		public string Title { get; }
        public string Description { get; }
        public ImageViewModel Image { get; }
        public ButtonViewModel Button { get; }
        public SeparatorViewModel Separator { get; }

        public string PartialViewPath => "~/Views/Partials/NestedContent/_HighlightedArticle.cshtml";
    }
}
