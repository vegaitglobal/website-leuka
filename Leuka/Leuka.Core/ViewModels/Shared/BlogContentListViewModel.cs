using System.Collections.Generic;
using System.Linq;
using Leuka.Models.Generated;

namespace Leuka.Core.ViewModels.Shared
{
    public class BlogContentListViewModel : IContentViewModel
    {
        private BlogContentListViewModel()
        {
        }

        public BlogContentListViewModel(IEnumerable<BlogContentList> blogContentList)
        {
            BlogList = new List<BlogContentListViewModel>();
            BlogList.AddRange(CreateBlogContent(blogContentList));
        }

        public List<BlogContentListViewModel> BlogList { get; }

        public string Title { get; set; }

        public string BlogDescription { get; set; }

        public ImageViewModel Image { get; set; }

        public string BlogCategory { get; set; }

        public bool BlogTopNews { get; set; }

        public string PartialViewPath => "~/Views/Partials/NestedContent/_BlogList.cshtml";

        private static IEnumerable<BlogContentListViewModel> CreateBlogContent(IEnumerable<BlogContentList> blogContentLists)
        {
            return blogContentLists.Select(
                blogContent => new BlogContentListViewModel
                {
                    Image = new ImageViewModel(blogContent.Image),
                    Title = blogContent.Title,
                    BlogDescription = blogContent.BlogDescription,
                    BlogCategory = blogContent.BlogCategory,
                    BlogTopNews = blogContent.BlogTopNewsIzdvajamo,
                });
        }
    }
}