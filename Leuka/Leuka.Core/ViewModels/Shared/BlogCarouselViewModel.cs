using Leuka.Models.Generated;
using System.Collections.Generic;
using System.Linq;
using Umbraco.Core.Composing;
using Umbraco.Web;
using Umbraco.Web.Models;

namespace Leuka.Core.ViewModels.Shared
{
    public class BlogCarouselViewModel : IContentViewModel
    {
        public BlogCarouselViewModel(BlogCarousel blogCarousel)
        {
            Articles = blogCarousel.BlogsPages.Select(x => MapToArticlePreview(x)).ToArray();
            NumberOfDisplayedPreviews = blogCarousel.NumberOfDisplayedPreviews;
        }

        private ArticlePreviewViewModel MapToArticlePreview(Link articleLink)
        {
            var umbracoContextFactory = Current.Factory.GetInstance(typeof(IUmbracoContextFactory)) as IUmbracoContextFactory;
            using (var contextReference = umbracoContextFactory.EnsureUmbracoContext())
            {
                var umbracoContext = contextReference.UmbracoContext;
                var article = umbracoContext.Content.GetByRoute(articleLink.Url) as Article;

                var viewModel = new ArticlePreviewViewModel
                {
                    Description = article.PreviewText,
                    Image = new ImageViewModel(article.PreviewImage),
                    Link = articleLink.Url,
                    Title = article.PageTitle,
                    Tags = string.Join(",", article.Tags)
                };

                return viewModel;
            }
        }

        public string PartialViewPath => "~/Views/Partials/NestedContent/_BlogCarousel.cshtml";

        public IEnumerable<ArticlePreviewViewModel> Articles { get; }

        public int? NumberOfDisplayedPreviews { get; }
    }
}
