using Leuka.Models.Generated;

namespace Leuka.Core.ViewModels.Shared
{
    public class ThankyouPopupViewModel : IContentViewModel
    {
        public ThankyouPopupViewModel(ThankyouPopup donatePopup)
        {
            Title = donatePopup.Title;
            Description = donatePopup.Description;
            OrganizationSubtitle = donatePopup.OrganizationSubtitle;
            OrganizationValue = donatePopup.OrganizationValue;
            BankAccountSubtitle = donatePopup.BankAccountSubtitle;
            BankAccountValue = donatePopup.BankAccountValue;
            CallNumberSubtitle = donatePopup.CallNumberSubtitle;
            CallNumberValue = donatePopup.CallNumberValue;
            RegistrationNumberSubtitle = donatePopup.RegistrationNumberSubtitle;
            RegistrationNumberValue = donatePopup.RegistrationNumberValue;
            ButtonDescription = donatePopup.ButtonDescription;
            Footnote = donatePopup.Footnote;
        }
        public string Title { get; }
        public string Description { get; }
        public string OrganizationSubtitle { get; }
        public string OrganizationValue { get; }
        public string BankAccountSubtitle { get; }
        public string BankAccountValue { get; }
        public string CallNumberSubtitle { get; }
        public string CallNumberValue { get; }
        public string RegistrationNumberSubtitle { get; }
        public string RegistrationNumberValue { get; }
        public string ButtonDescription { get; }
        public string Footnote { get; }

        public string PartialViewPath => "~/Views/Partials/NestedContent/_ThankyouPopup.cshtml";
    }
}
