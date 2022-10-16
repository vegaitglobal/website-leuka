using Leuka.Core.Contexts;
using Leuka.Models.Generated;
using System.Linq;
using Umbraco.Web;

namespace Leuka.Core.ViewModels.Pages
{
    public class BlogsViewModel : PageViewModel
    {
        public string Title { get; set; }

        public BlogsViewModel(IPageContext<Blogs> context) : base(context)
        {
            var blockGrid = context.Page.Grid;
            if (blockGrid != null)
            {
                var blogs = context.Page.ChildrenOfType("article").Take(9);
                //TODO: kreirati blog preview kao sto je u blog carouselu - videti sa jovom da ne dupliramo kod
            }
        }
    }
}
