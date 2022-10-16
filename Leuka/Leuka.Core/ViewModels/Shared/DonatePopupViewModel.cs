using Leuka.Models.Generated;

namespace Leuka.Core.ViewModels.Shared
{
    public class DonatePopupViewModel : IContentViewModel
    {
        public DonatePopupViewModel(DonatePopup donatePopup)
        {
            Title = donatePopup.Title;
            Description = donatePopup.Description;
            Donor = donatePopup.Donor;
            Amount = donatePopup.Amount;
            CompanyName = donatePopup.CompanyName;
            Email = donatePopup.Email;
            Footnote = donatePopup.Footnote;
            ButtonText = donatePopup.ButtonText;
        }
        public string Title { get; }
        public string Description { get; }
        public string Donor { get; }
        public string Amount { get; }
        public string CompanyName { get; }
        public string Email { get; }
        public string Footnote { get;  }
        public string ButtonText { get;  }


        public string PartialViewPath => "~/Views/Partials/NestedContent/_DonatePopup.cshtml";
    }
}
