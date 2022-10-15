using Leuka.Models.Generated;

namespace Leuka.Core.ViewModels.Shared
{
    public class ContactusViewModel : IContentViewModel
    {
        public ContactusViewModel(Contactus contactus)
        {
            Enabled = contactus.ContactToggle;
        }

        public bool Enabled { get; set; }

        public string PartialViewPath => "~/Views/Partials/NestedContent/_ContactUs.cshtml";
    }
}