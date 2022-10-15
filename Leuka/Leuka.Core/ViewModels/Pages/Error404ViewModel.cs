using Leuka.Core.Contexts;
using Leuka.Models.Generated;
using System.Linq;

namespace Leuka.Core.ViewModels.Pages
{
	public class Error404ViewModel : PageViewModel
	{
		public Error404ViewModel(IPageContext<Error404> context) : base(context)
		{
			HomePageLinkDescription = context.Page.HomePageLinkDescription;
			DonatePopup = context.Page.DonatePopup.FirstOrDefault();
			DonatePopupViewModel = new Shared.DonatePopupViewModel(DonatePopup);
		}
		public string HomePageLinkDescription { get; set; }
		public DonatePopup DonatePopup { get; set; }
		public ViewModels.Shared.DonatePopupViewModel DonatePopupViewModel { get; set; }
	}
}
