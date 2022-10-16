using Leuka.Models.Generated;
using static Leuka.Core.Constants;

namespace Leuka.Core.ViewModels.Shared
{
    public class ContactusViewModel : IContentViewModel
    {
        public ContactusViewModel(Contactus contactus)
        {
            Enabled = contactus.ContactToggle;
            ContactUsFormClass = contactus.BackgroundColor == Colors.White
                ? "bg-white"
                : string.Empty;
        }

        public bool Enabled { get; set; }

        public string ContactUsFormClass { get; }

        public string PartialViewPath => "~/Views/Partials/NestedContent/_ContactUs.cshtml";
    }
}
