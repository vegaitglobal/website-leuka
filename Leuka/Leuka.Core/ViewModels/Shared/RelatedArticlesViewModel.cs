using Leuka.Models.Generated;
using Microsoft.Extensions.DependencyInjection;
using Umbraco.Cms.Core.Models;
using Umbraco.Cms.Core.Web;
using Umbraco.Cms.Web.Common.DependencyInjection;

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
            var umbracoContextFactory = StaticServiceProvider.Instance.GetRequiredService<IUmbracoContextFactory>();
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
