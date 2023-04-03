using Leuka.Core.Contexts;
using Leuka.Core.ViewModels.Shared;
using Leuka.Models.Generated;
using Microsoft.AspNetCore.Html;

namespace Leuka.Core.ViewModels.Pages
{
    public class ArticleViewModel : PageViewModel
    {
        public ArticleViewModel(IPageContext<Article> context, BreadcrumbsViewModel breadcrumbs = null) : base(context)
        {
            var contextPage = context.Page;
            var headlineInfo = contextPage.HeadlineInfo;
            if (headlineInfo != null)
            {
                HeadlineInfo = headlineInfo.Select(x => new TitleDescriptionAndButtonViewModel(x)).FirstOrDefault();
            }

            var pageDetails = contextPage.PageDetails;
            if (pageDetails != null)
            {
                PageDetails = new HtmlString(pageDetails.ToHtmlString());
            }

            var authorDetails = contextPage.AuthorDetails;
            if (authorDetails != null)
            {
                AuthorDetails = authorDetails.Select(x => new AuthorDetailsViewModel(x)).FirstOrDefault();
            }

            Breadcrumbs = breadcrumbs;

            var relatedArticles = contextPage.RelatedArticles;
            if (relatedArticles != null)
            {
                RelatedArticles = relatedArticles.Select(x => new RelatedArticlesViewModel(x)).FirstOrDefault();
            }

        }

        public TitleDescriptionAndButtonViewModel HeadlineInfo { get; }
        public HtmlString PageDetails { get; }
        public AuthorDetailsViewModel AuthorDetails { get; }
        public BreadcrumbsViewModel Breadcrumbs { get; }
        public RelatedArticlesViewModel RelatedArticles { get; }
    }
}
