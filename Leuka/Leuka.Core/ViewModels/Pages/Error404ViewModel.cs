using Leuka.Core.Contexts;
using Leuka.Models.Generated;

namespace Leuka.Core.ViewModels.Pages
{
	public class Error404ViewModel : PageViewModel
	{
		public Error404ViewModel(IPageContext<Error404> context) : base(context)
		{
			HomePageLinkDescription = context.Page.HomePageLinkDescription;
		}
		public string HomePageLinkDescription { get; set; }
	}
}
