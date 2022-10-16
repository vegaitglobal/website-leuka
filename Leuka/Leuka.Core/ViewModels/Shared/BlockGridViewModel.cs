using Umbraco.Web;
using Umbraco.Web.Models;
using Leuka.Models.Generated;
using Leuka.Core.Contexts;
using System.Collections.Generic;
using System.Linq;

namespace Leuka.Core.ViewModels.Shared
{
    public class BlockGridViewModel : IContentViewModel
    {
        public BlockGridViewModel() { }
        public BlockGridViewModel(BlockGrid blockGrid, Blogs contextPage)
        {
            if (blockGrid != null)
            {
                Title = blockGrid.Title;
                Path = contextPage.Url();
                TotalNumberOfArticles = contextPage
                    .ChildrenOfType("article")
                    .Count();

                Tags = contextPage
                    .ChildrenOfType("article")
                    .Select(x => x as Article)
                    .Select(x => x.Tags).SelectMany(x => x);


                var articlePages = contextPage
                    .ChildrenOfType("article")
                    .Take(BatchSize);

                Previews = articlePages
                    .Select(x => x as Article)
                    .Select(x => new ArticlePreviewViewModel
                    {
                        Description = x.PreviewText,
                        Image = new ImageViewModel(x.PreviewImage),
                        Link = x.Url(),
                        Title = x.PageTitle,
                        Tags = string.Join(",", x.Tags)
                    });

                NumberOfDispalyedArticles = Previews.Count();
            }
        }

        public string Title { get; set; }
        public string Path { get; set; }
        public IEnumerable<ArticlePreviewViewModel> Previews { get; set; }
        public int TotalNumberOfArticles { get; set; }
        public int NumberOfDispalyedArticles { get; set; }
        private const int BatchSize = 9;
        public IEnumerable<string> Tags { get; set; }
        public string PartialViewPath => "~/Views/Partials/NestedContent/_BlockGridViewModel.cshtml";
    }
}
