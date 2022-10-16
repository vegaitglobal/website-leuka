using System.Collections.Generic;
using System.Linq;
using Leuka.Core.Contexts;
using Leuka.Core.ViewModels.Shared;
using Leuka.Models.Generated;

namespace Leuka.Core.ViewModels.Pages
{
    public class ContactViewModel : PageViewModel
    {
        public List<IContentViewModel> Components;

        public ContactViewModel(IPageContext<Contact> context)
            : base(context)
        {
            Components = new List<IContentViewModel>();

            AddTopText(context);
            AddMediumText(context);
            AddQuote(context);
            AddContactUs(context);
            AddAppPromotion(context);
        }

        private void AddAppPromotion(IPageContext<Contact> context)
        {
            IEnumerable<AppPromotion> appPromotions = context.Page.AppPromo;

            IEnumerable<AppPromotionViewModel> appPromotionViewModels = appPromotions.Select(x => new AppPromotionViewModel(x));

            Components.AddRange(appPromotionViewModels);
        }

        private void AddTopText(IPageContext<Contact> context)
        {
            IEnumerable<TitleDescriptionAndButton> pageTopTextBlock = context.Page.TopTextBlock;

            IEnumerable<TitleDescriptionAndButtonViewModel> titleDescriptionAndButtonViewModels
                = pageTopTextBlock.Select(x => new TitleDescriptionAndButtonViewModel(x));

            Components.AddRange(titleDescriptionAndButtonViewModels);
        }

        private void AddContactUs(IPageContext<Contact> context)
        {
            IEnumerable<Contactus> contactUs = context.Page.ContactUs;

            IEnumerable<ContactusViewModel> contactusViewModels = contactUs.Select(x => new ContactusViewModel(x));
            Components.AddRange(contactusViewModels);
        }

        private void AddMediumText(IPageContext<Contact> context)
        {
            IEnumerable<MediumTextBlock> mediumTextBlocks = context.Page.MediumTextBlock;

            IEnumerable<MediumTextBlockViewModel> contactusViewModels = mediumTextBlocks.Select(x => new MediumTextBlockViewModel(x));

            Components.AddRange(contactusViewModels);
        }

        private void AddQuote(IPageContext<Contact> context)
        {
            IEnumerable<Quote> notification = context.Page.Quote;

            IEnumerable<QuoteViewModel> donationsModels = notification.Select(x => new QuoteViewModel(x));
            Components.AddRange(donationsModels);
        }
    }
}