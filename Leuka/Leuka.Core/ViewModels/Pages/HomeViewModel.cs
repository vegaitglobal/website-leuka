using Leuka.Core.Contexts;
using Leuka.Core.ViewModels.Shared;
using Leuka.Models.Generated;
using System.Collections.Generic;
using System.Linq;

namespace Leuka.Core.ViewModels.Pages
{
	public class HomeViewModel : PageViewModel
	{
		public HomeViewModel(IPageContext<Home> context) : base(context)
		{
            Components = new List<IContentViewModel>();

            var mediumTextBlocks = context.Page.MediumText;
            if (mediumTextBlocks != null)
            {
                var mediumTextBlocksModels =  mediumTextBlocks.Select(x =>  new MediumTextBlockViewModel(x));
                Components.AddRange(mediumTextBlocksModels);
            }

            var splitBlocks = context.Page.SplitBlock;
            if (splitBlocks != null)
            {
                var splitBlocksModels = splitBlocks.Select(x => new SplitBlockViewModel(x));
                Components.AddRange(splitBlocksModels);
            }

            var quotes = context.Page.Quote;
            if (quotes != null)
            {
                var quotesModels = quotes.Select(x => new QuoteViewModel(x));
                Components.AddRange(quotesModels);
            }

            var donations = context.Page.Donations;
            if (donations != null)
            {
                var donationsModels = donations.Select(x => new SplitBlockViewModel(x));
                Components.AddRange(donationsModels);
            }

            var gallery = context.Page.Gallery;
            if (gallery != null)
            {
                var galleryModels = gallery.Select(x => new GalleryViewModel(x));
                Components.AddRange(galleryModels);
            }

            var sponsors = context.Page.Sponsors;
            if (sponsors != null)
            {
                var sponsorsModels = sponsors.Select(x => new SponsorsViewModel(x));
                Components.AddRange(sponsorsModels);
            }


            var blogCarousel = context.Page.BlogCarousel;
            if (blogCarousel != null)
            {
                var blogCarouselModels = blogCarousel.Select(x => new BlogCarouselViewModel(x));
                Components.AddRange(blogCarouselModels);
            }
        }

        public List<IContentViewModel> Components { get; set; }
	}
}
