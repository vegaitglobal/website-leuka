using Leuka.Models.Generated;

namespace Leuka.Core.ViewModels.Shared
{
    public class DonatePopupViewModel : IContentViewModel
    {
        public DonatePopupViewModel(DonatePopup donatePopup)
        {
            Title = donatePopup.Title;
            Description = donatePopup.Description;
            DonatorString = donatePopup.DonatorString;
            ValueString = donatePopup.ValueString;
            CompanyString = donatePopup.CompanyString;
            EmailString = donatePopup.EmailString;
        }
        public string Title { get; }
        public string Description { get; }
        public string DonatorString { get; }
        public string ValueString { get; }
        public string CompanyString { get; }
        public string EmailString { get; }

        public string PartialViewPath => "~/Views/Partials/NestedContent/_DonatePopup.cshtml";
    }
}
