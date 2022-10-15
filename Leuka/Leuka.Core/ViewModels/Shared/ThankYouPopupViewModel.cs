using Leuka.Models.Generated;

namespace Leuka.Core.ViewModels.Shared
{
    public class ThankYouPopupViewModel : IContentViewModel
    {
        public ThankYouPopupViewModel(ThankyouPopup donatePopup)
        {
            Title = donatePopup.Title;
            Subtitle = donatePopup.Subtitle;
            Organization = donatePopup.Organization;
            Account = donatePopup.Account;
            ReferenceNumber = donatePopup.ReferenceNumber;
            RegistrationNumber = donatePopup.RegistrationNumber;
            ButtonDescription = donatePopup.ButtonDescription;
            Footnote = donatePopup.Footnote;
        }
        public string Title { get; }
        public string Subtitle { get; }
        public string Organization { get; }
        public string Account { get; }
        public string ReferenceNumber { get; }
        public string RegistrationNumber { get; }
        public string ButtonDescription { get; }
        public string Footnote { get; }

        public string PartialViewPath => "~/Views/Partials/NestedContent/_ThankyouPopup.cshtml";
    }
}
