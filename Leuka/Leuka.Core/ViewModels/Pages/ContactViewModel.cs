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
            AddSeparator(context);
            AddMediumText(context);
            AddQuote(context);
            AddContactUs(context);
            AddAppPromotion(context);
        }

        private void AddAppPromotion(IPageContext<Contact> context)
        {
            IEnumerable<AppPromotion> appPromotion = context.Page.AppPromotion;

            if (appPromotion != null)
            {
                IEnumerable<AppPromotionViewModel> appPromotionModels = appPromotion.Select(x => new AppPromotionViewModel(x));
                Components.AddRange(appPromotionModels);
            }
        }

        private void AddSeparator(IPageContext<Contact> context)
        {
            IEnumerable<Separator> splitBlocks = context.Page.Separator;

            if (splitBlocks != null)
            {
                IEnumerable<SeparatorViewModel> splitBlocksModels = splitBlocks.Select(x => new SeparatorViewModel(x));
                Components.AddRange(splitBlocksModels);
            }
        }

        private void AddTopText(IPageContext<Contact> context)
        {
            IEnumerable<TitleDescriptionAndButton> headlineInfo = context.Page.TopTextBlock;

            if (headlineInfo != null)
            {
                IEnumerable<TitleDescriptionAndButtonViewModel> headlineInfoModels
                    = headlineInfo.Select(x => new TitleDescriptionAndButtonViewModel(x));
                Components.AddRange(headlineInfoModels);
            }
        }

        private void AddContactUs(IPageContext<Contact> context)
        {
            IEnumerable<Contactus> contactUs = context.Page.ContactUs;

            IEnumerable<ContactusViewModel> contactusViewModels = contactUs.Select(x => new ContactusViewModel(x));
            Components.AddRange(contactusViewModels);
        }

        private void AddMediumText(IPageContext<Contact> context)
        {
            IEnumerable<MediumTextBlock> mediumTextBlocks = context.Page.MiddleText;

            if (mediumTextBlocks != null)
            {
                IEnumerable<MediumTextBlockViewModel> mediumTextBlocksModels = mediumTextBlocks.Select(x => new MediumTextBlockViewModel(x));
                Components.AddRange(mediumTextBlocksModels);
            }
        }

        private void AddQuote(IPageContext<Contact> context)
        {
            IEnumerable<Quote> quotes = context.Page.Quote;

            if (quotes != null)
            {
                IEnumerable<QuoteViewModel> quotesModels = quotes.Select(x => new QuoteViewModel(x));
                Components.AddRange(quotesModels);
            }
        }
    }
}