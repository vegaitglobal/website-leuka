using Leuka.Core.Contexts;
using Leuka.Core.ViewModels.Shared;
using Leuka.Models.Generated;
using System.Collections.Generic;
using System.Linq;

namespace Leuka.Core.ViewModels.Pages
{
    public class HowToHelpViewModel : PageViewModel
    {
        public string Title { get; set; }
        public HowToHelpViewModel(IPageContext<HowToHelp> context) : base(context)
        {
            Components = new List<IContentViewModel>();

            var headlineInfo = context.Page.TopTextBlock;
            if (headlineInfo != null)
            {
                var headlineInfoModels = headlineInfo.Select(x => new TitleDescriptionAndButtonViewModel(x));
                Components.AddRange(headlineInfoModels);
            }

            var splitBlocks = context.Page.Separator1;
            if (splitBlocks != null)
            {
                var splitBlocksModels = splitBlocks.Select(x => new SeparatorViewModel(x));
                Components.AddRange(splitBlocksModels);
            }

            var mediumTextBlocks = context.Page.MiddleText;
            if (mediumTextBlocks != null)
            {
                var mediumTextBlocksModels = mediumTextBlocks.Select(x => new MediumTextBlockViewModel(x));
                Components.AddRange(mediumTextBlocksModels);
            }

            var quotes = context.Page.Quote;
            if (quotes != null)
            {
                var quotesModels = quotes.Select(x => new QuoteViewModel(x));
                Components.AddRange(quotesModels);
            }

            var appPromotion = context.Page.AppPromo;
            if (appPromotion != null)
            {
                var appPromotionModels = appPromotion.Select(x => new AppPromotionViewModel(x));
                Components.AddRange(appPromotionModels);
            }

            var contactUs = context.Page.ContactUs;
            if (contactUs != null)
            {
                var contactUsViewModels = contactUs.Select(x => new ContactusViewModel(x));
                Components.AddRange(contactUsViewModels);
            }
        }
        public List<IContentViewModel> Components { get; set; }
    }
}
