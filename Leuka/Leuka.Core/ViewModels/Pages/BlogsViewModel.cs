using Leuka.Core.Contexts;
using Leuka.Core.ViewModels.Shared;
using Leuka.Models.Generated;
using System.Linq;
using Umbraco.Web;

namespace Leuka.Core.ViewModels.Pages
{
    public class BlogsViewModel : PageViewModel
    {
        public string Title { get; }
        public BlockGridViewModel Grid { get; }

        public BlogsViewModel(IPageContext<Blogs> context) : base(context)
        {
            var contextPage = context.Page;
            var grid = contextPage.Grid.FirstOrDefault();
            if (grid != null)
            {
                Grid = new BlockGridViewModel(grid, contextPage);
            }

        }
    }
}
