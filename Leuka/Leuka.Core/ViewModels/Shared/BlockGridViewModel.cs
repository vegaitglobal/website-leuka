using Umbraco.Web;
using Umbraco.Web.Models;
using Leuka.Models.Generated;

namespace Leuka.Core.ViewModels.Shared
{
	public class BlockGridViewModel : IContentViewModel
    {
		public BlockGridViewModel(BlockGrid blockGrid)
		{
            Title = blockGrid.Title;
		}
		public string Title { get; }

		public string PartialViewPath => "~/Views/Partials/NestedContent/_BlockGridViewModel.cshtml";
    }
}
