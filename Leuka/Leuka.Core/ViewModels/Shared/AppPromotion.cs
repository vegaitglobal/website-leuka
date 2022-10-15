using Umbraco.Web;
using Umbraco.Web.Models;
using Leuka.Models.Generated;
using System.Web;
using Umbraco.Examine;

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
		}
		public string Title { get; }
		public string Description { get; }
		public ImageViewModel BackgroudImage { get; }
		public string AndroidAppLinkUrl { get; }
        public string AppleAppLinkUrl { get; }

        public string PartialViewPath => "~/Views/Partials/NestedContent/_AppPromotion.cshtml";
    }
}
