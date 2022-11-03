using Leuka.Models.Generated;
using System.Collections.Generic;
using System.Linq;
using Umbraco.Core.Composing;
using Umbraco.Web;
using Umbraco.Web.Models;

namespace Leuka.Core.ViewModels.Shared
{
    public class RelatedArticlesViewModel : IContentViewModel
    {
        public RelatedArticlesViewModel(RelatedArticles relatedArticles)
        {
            Articles = relatedArticles.Articles.Select(x => MapToArticlePreview(x)).ToArray();
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
                    Link = new LinkViewModel(articleLink),
                    Title = article.PageTitle,
                    Tags = string.Join(",", article.Tags)
                };

                return viewModel;
            }
        }

        public string PartialViewPath => "~/Views/Partials/NestedContent/_RelatedArticles.cshtml";

        public IEnumerable<ArticlePreviewViewModel> Articles { get; }

    }
}
