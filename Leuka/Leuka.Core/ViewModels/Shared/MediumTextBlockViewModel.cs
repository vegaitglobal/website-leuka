using Umbraco.Web;
using Umbraco.Web.Models;
using Leuka.Models.Generated;

namespace Leuka.Core.ViewModels.Shared
{
	public class MediumTextBlockViewModel : IContentViewModel
    {
		public MediumTextBlockViewModel(MediumTextBlock mediumTextBlock)
		{
				Text = mediumTextBlock.Text;
		}
		public string Text { get; }

		public string PartialViewPath => "~/Views/Partials/NestedContent/_MediumTextBlock.cshtml";
    }
}
