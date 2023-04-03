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

            AddTopText(context);
            AddSeparator(context);
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

        private void AddSeparator(IPageContext<JoinUs> context)
        {
            IEnumerable<Separator> splitBlocks = context.Page.Separator;

            if (splitBlocks != null)
            {
                IEnumerable<SeparatorViewModel> splitBlocksModels = splitBlocks.Select(x => new SeparatorViewModel(x));
                Components.AddRange(splitBlocksModels);
            }
        }

        private void AddTopText(IPageContext<JoinUs> context)
        {
            IEnumerable<TitleDescriptionAndButton> headlineInfo = context.Page.TopTextBlock;

            if (headlineInfo != null)
            {
                IEnumerable<TitleDescriptionAndButtonViewModel> headlineInfoModels
                    = headlineInfo.Select(x => new TitleDescriptionAndButtonViewModel(x));
                Components.AddRange(headlineInfoModels);
            }
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