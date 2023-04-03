using Leuka.Models.Generated;

namespace Leuka.Core.ViewModels.Shared
{
    public class TitleDescriptionAndButtonViewModel : IContentViewModel
    {
		public TitleDescriptionAndButtonViewModel(TitleDescriptionAndButton titleDescriptionAndButton)
		{
			Title = titleDescriptionAndButton.Title;
			Description = titleDescriptionAndButton.Description;

			if (titleDescriptionAndButton.Button.Any())
			{
               Button = new ButtonViewModel(titleDescriptionAndButton.Button.First());
            }
			
		}
		public string Title { get; }
		public string Description { get; }
		public ButtonViewModel Button { get; }

        public string PartialViewPath => "~/Views/Partials/NestedContent/_TitleDescriptionAndButton.cshtml";
    }
}
