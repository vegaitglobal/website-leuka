using System.Collections.Generic;
using System.Linq;
using Leuka.Core.Contexts;
using Leuka.Core.ViewModels.Shared;
using Leuka.Models.Generated;

namespace Leuka.Core.ViewModels.Pages
{
    public class HowToHelpViewModel : PageViewModel
    {
        public HowToHelpViewModel(IPageContext<HowToHelp> context)
            : base(context)
        {
            Components = new List<IContentViewModel>();

            IEnumerable<TitleDescriptionAndButton> headlineInfo = context.Page.TopTextBlock;

            if (headlineInfo != null)
            {
                IEnumerable<TitleDescriptionAndButtonViewModel> headlineInfoModels
                    = headlineInfo.Select(x => new TitleDescriptionAndButtonViewModel(x));
                Components.AddRange(headlineInfoModels);
            }

            IEnumerable<Separator> splitBlocks = context.Page.Separator;

            if (splitBlocks != null)
            {
                IEnumerable<SeparatorViewModel> splitBlocksModels = splitBlocks.Select(x => new SeparatorViewModel(x));
                Components.AddRange(splitBlocksModels);
            }

            IEnumerable<MediumTextBlock> mediumTextBlocks = context.Page.MiddleText;

            if (mediumTextBlocks != null)
            {
                IEnumerable<MediumTextBlockViewModel> mediumTextBlocksModels = mediumTextBlocks.Select(x => new MediumTextBlockViewModel(x));
                Components.AddRange(mediumTextBlocksModels);
            }

            IEnumerable<Quote> quotes = context.Page.Quote;

            if (quotes != null)
            {
                IEnumerable<QuoteViewModel> quotesModels = quotes.Select(x => new QuoteViewModel(x));
                Components.AddRange(quotesModels);
            }

            IEnumerable<AppPromotion> appPromotion = context.Page.AppPromo;

            if (appPromotion != null)
            {
                IEnumerable<AppPromotionViewModel> appPromotionModels = appPromotion.Select(x => new AppPromotionViewModel(x));
                Components.AddRange(appPromotionModels);
            }

            IEnumerable<Contactus> contactUs = context.Page.ContactUs;

            if (contactUs != null)
            {
                IEnumerable<ContactusViewModel> contactUsViewModels = contactUs.Select(x => new ContactusViewModel(x));
                Components.AddRange(contactUsViewModels);
            }
        }

        public string Title { get; set; }
        public List<IContentViewModel> Components { get; set; }
    }
}