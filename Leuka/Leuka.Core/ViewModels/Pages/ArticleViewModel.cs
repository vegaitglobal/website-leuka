using Leuka.Core.Contexts;
using Leuka.Core.ViewModels.Shared;
using Leuka.Models.Generated;
using System.Linq;
using System.Web;

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
                PageDetails = pageDetails;
            }

            var authorDetails = contextPage.AuthorDetails;
            if (authorDetails != null)
            {
                AuthorDetails = authorDetails.Select(x => new AuthorDetailsViewModel(x)).FirstOrDefault();
            }

            Breadcrumbs = breadcrumbs;
        }

        public TitleDescriptionAndButtonViewModel HeadlineInfo { get; }
        public IHtmlString PageDetails { get; }
        public AuthorDetailsViewModel AuthorDetails { get; }
        public BreadcrumbsViewModel Breadcrumbs { get; }
    }
}
