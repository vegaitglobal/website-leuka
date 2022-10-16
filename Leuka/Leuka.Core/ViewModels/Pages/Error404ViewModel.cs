using Leuka.Core.Contexts;
using Leuka.Core.ViewModels.Shared;
using Leuka.Models.Generated;
using System.Collections.Generic;
using System.Linq;

namespace Leuka.Core.ViewModels.Pages
{
	public class Error404ViewModel : PageViewModel
	{
		public Error404ViewModel(IPageContext<Error404> context) : base(context)
		{
			Components = new List<IContentViewModel>();

			HomePageLinkDescription = context.Page.HomePageLinkDescription;
			var donatePopup = context.Page.DonatePopup.FirstOrDefault();
			if (donatePopup != null)
			{
				Components.Add(new DonatePopupViewModel(donatePopup));
			}
			var thankyouPopup = context.Page.ThankyouPopup.FirstOrDefault();
			if (thankyouPopup != null)
			{
				Components.Add(new ThankYouPopupViewModel(thankyouPopup));
			}
		}
		public string HomePageLinkDescription { get; set; }
		public List<IContentViewModel> Components { get; set; }
	}
}
