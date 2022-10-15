using Leuka.Models.Generated;
using System.Linq;

namespace Leuka.Core.ViewModels.Shared
{
	public class AppPromotionViewModel : IContentViewModel
    {
		public AppPromotionViewModel(AppPromotion appPromotion)
		{
            Title = appPromotion.Title;
			Description = appPromotion.Description;
			BackgroudImage = new ImageViewModel(appPromotion.BackgroundImage);
			AndroidAppLinkUrl = appPromotion.AndroidAppLink.Url;
			AppleAppLinkUrl = appPromotion.AppleAppLink.Url;

            var separator = appPromotion.Separator.FirstOrDefault();

            if (separator != null)
            {
                Separator = new SeparatorViewModel(separator);
            }
        }
		public string Title { get; }
		public string Description { get; }
		public ImageViewModel BackgroudImage { get; }
		public string AndroidAppLinkUrl { get; }
        public string AppleAppLinkUrl { get; }
        public SeparatorViewModel Separator { get; }

        public string PartialViewPath => "~/Views/Partials/NestedContent/_AppPromotion.cshtml";
    }
}
