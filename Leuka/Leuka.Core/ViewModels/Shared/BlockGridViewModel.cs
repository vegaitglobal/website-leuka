using Leuka.Models.Generated;
using Umbraco.Cms.Core.Models.PublishedContent;

namespace Leuka.Core.ViewModels.Shared
{
    public class BlockGridViewModel : IContentViewModel
    {
        public BlockGridViewModel() { }
        public BlockGridViewModel(BlockGrid blockGrid, PublishedContentModel contextPage)
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
                    .Select(x => x.Tags)
                    .SelectMany(x => x)
                    .Distinct();


                var articlePages = contextPage
                    .ChildrenOfType("article")
                    .Take(BatchSize);

                Previews = articlePages
                    .Select(x => x as Article)
                    .Select(x => new ArticlePreviewViewModel
                    {
                        Description = x.PreviewText,
                        Image = new ImageViewModel(x.PreviewImage),
                        Link = new LinkViewModel(x.Url(), x.PageTitle),
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
