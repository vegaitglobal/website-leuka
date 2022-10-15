using System.Collections.Generic;
using System.Linq;
using Leuka.Core.Contexts;
using Leuka.Core.ViewModels.Shared;
using Leuka.Models.Generated;

namespace Leuka.Core.ViewModels.Pages
{
    public class BlogsViewModel : PageViewModel
    {
        public BlogsViewModel(IPageContext<Blogs> context)
            : base(context)
        {
            Components = new List<IContentViewModel>();

            AddHeader(context);
            AddBlogContent(context);
        }

        public List<IContentViewModel> Components { get; set; }

        private void AddHeader(IPageContext<Blogs> context)
        {
            Blogs headerContent = context.Page;

            var headerViewModel = new HeaderViewModel(headerContent);
            Components.Add(headerViewModel);
        }

        private void AddBlogContent(IPageContext<Blogs> context)
        {
            IEnumerable<BlogContentList> blogContentList = context.Page.BlogContentList.Select(s => s.Content as BlogContentList);

            if (!blogContentList.Any())
            {
                return;
            }

            var blogContentListViewModel = new BlogContentListViewModel(blogContentList);
            Components.Add(blogContentListViewModel);
        }
    }
}