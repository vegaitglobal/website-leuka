using System.Collections.Generic;
using System.Linq;
using Leuka.Core.Contexts;
using Leuka.Core.ViewModels.Shared;
using Leuka.Models.Generated;

namespace Leuka.Core.ViewModels.Pages
{
    public class JoinUsViewModel : PageViewModel
    {
        public JoinUsViewModel(IPageContext<JoinUs> context)
            : base(context)
        {
            Components = new List<IContentViewModel>();

            AddOrganizationInfoBanner(context);
            AddBeforeContactUsBlock(context);
            AddContactUs(context);
        }

        public List<IContentViewModel> Components { get; set; }

        private void AddBeforeContactUsBlock(IPageContext<JoinUs> context)
        {
            IEnumerable<JoinUsPreContactPage> preContactField = context.Page.PreContactField;

            if (preContactField == null)
            {
                return;
            }

            IEnumerable<PreContactFieldViewModel> contactusViewModels = preContactField.Select(x => new PreContactFieldViewModel(x));
            Components.AddRange(contactusViewModels);
        }

        private void AddContactUs(IPageContext<JoinUs> context)
        {
            IEnumerable<Contactus> contactUs = context.Page.ContactUs;

            if (contactUs == null)
            {
                return;
            }

            IEnumerable<ContactusViewModel> contactusViewModels = contactUs.Select(x => new ContactusViewModel(x));
            Components.AddRange(contactusViewModels);
        }

        private void AddOrganizationInfoBanner(IPageContext<JoinUs> context)
        {
            IEnumerable<OrganizationInfoBanner> banner = context.Page.OrganizationInfoBanner;

            if (banner == null)
            {
                return;
            }

            var galleryModels = banner.Select(x => new OrganizationInfoBannerViewModel(x));
            Components.AddRange(galleryModels);
        }
    }
}