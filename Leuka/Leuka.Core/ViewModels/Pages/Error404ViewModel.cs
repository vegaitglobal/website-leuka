using Leuka.Core.Contexts;
using Leuka.Core.ViewModels.Shared;
using Leuka.Models.Generated;

namespace Leuka.Core.ViewModels.Pages
{
    public class Error404ViewModel : PageViewModel
	{
		public Error404ViewModel(IPageContext<Error404> context) : base(context)
		{
			Components = new List<IContentViewModel>();

			var errorDescription = context.Page.ErrorDescription.FirstOrDefault();
			if (errorDescription != null)
			{
				Components.Add(new TitleDescriptionAndButtonViewModel(errorDescription));
			}
		}
		public List<IContentViewModel> Components { get; set; }
	}
}
