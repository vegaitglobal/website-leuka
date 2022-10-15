using Leuka.Models.Generated;
using System.Linq;

namespace Leuka.Core.ViewModels.Shared
{
	public class SplitBlockViewModel : IContentViewModel
    {
		public SplitBlockViewModel(SplitBlock splitBlock)
		{
			Title = splitBlock.Title;
			Description = splitBlock.Description;
			Tag = splitBlock.Tag;
			Image = new ImageViewModel(splitBlock.Image.FirstOrDefault());
		}
		public string Title { get; }
		public string Description { get; }
		public string Tag { get; }
		public ImageViewModel Image { get; }

        public string PartialViewPath => "~/Views/Partials/NestedContent/_SplitBlock.cshtml";
    }
}
